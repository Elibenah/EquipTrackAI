using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Tikshuv.Logic;
using Tikshuv.Logic.DataAccsess;

namespace Tikshuv.FrontEnd
{
    public partial class SignatureForm : Form
    {
        private bool isDrawing = false;
        private Point lastPoint;
        mission loadedMission;
        private Bitmap signatureBitmap;

        public SignatureForm(mission missionToDigitalSignature)
        {
            InitializeComponent();
            signatureBitmap = new Bitmap(signaturePanel.Width, signaturePanel.Height);
            signaturePanel.Paint += SignaturePanel_Paint;
            this.DoubleBuffered = true;

            loadedMission = missionToDigitalSignature;
            txtMissionName.Text = loadedMission.missionName;

            string attachments = "";
            string itemName;
            string serialNumber;
            foreach (var item in loadedMission.itemsInMissions)
            {
                
                foreach (var obj in item.Value)
                {
                    itemName = item.Key;
                    serialNumber = obj.serialNumber;
                    if (obj.attachmentOfEquiment != null && obj.attachmentOfEquiment.Count > 0)
                    {
                        attachments = string.Join(", ", obj.attachmentOfEquiment
                                    .Where(item => item.inMission)         // Filter items where 'in' is true
                                    .Select(item => item.name));           // Project the 'name' property
                    }
                    equipmentGrid.Rows.Add(itemName,serialNumber,attachments);

                    ////string cellValue = string.Join(", ", Enumerable.Range(0, obj.attachmentOfEquiment.Count);
                    //if (obj.serialNumber != "N\\A" && obj.serialNumber != "N/A")
                    //{
                    //    AttachmentForEeachItem.Add(obj.serialNumber, cellValue);
                    //}
                }
            }
                
        }

        private void signaturePanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastPoint = e.Location;
        }

        private void signaturePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(signatureBitmap))
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location);
                }
                lastPoint = e.Location;
                signaturePanel.Invalidate();
            }
        }

        private void signaturePanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void btnClearSignature_Click(object sender, EventArgs e)
        {
            signatureBitmap = new Bitmap(signaturePanel.Width, signaturePanel.Height);
            using (Graphics g = Graphics.FromImage(signatureBitmap))
            {
                g.Clear(Color.White);
            }
            signaturePanel.Invalidate();
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Files (.png)|.png";
            saveFileDialog.DefaultExt = "png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a new bitmap with a white background
                using (Bitmap whiteBgBitmap = new Bitmap(signatureBitmap.Width, signatureBitmap.Height))
                {
                    using (Graphics g = Graphics.FromImage(whiteBgBitmap))
                    {
                        g.Clear(Color.White); // Fill with white
                        g.DrawImage(signatureBitmap, Point.Empty); // Draw the signature on top
                    }
                    whiteBgBitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
                }
                MessageBox.Show("החתימה נשמרה בהצלחה.");
            }
        }


        public byte[] GetSignatureBytes()
        {
            using (Bitmap whiteBgBitmap = new Bitmap(signatureBitmap.Width, signatureBitmap.Height))
            {
                using (Graphics g = Graphics.FromImage(whiteBgBitmap))
                {
                    g.Clear(Color.White); // Fill with white
                    g.DrawImage(signatureBitmap, Point.Empty); // Draw the signature on top
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    whiteBgBitmap.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // ולידציה
                if (string.IsNullOrWhiteSpace(txtSigneeId.Text) ||
                    string.IsNullOrWhiteSpace(txtCommanderName.Text) ||
                    string.IsNullOrWhiteSpace(txtSigneeName.Text) ||
                    string.IsNullOrWhiteSpace(txtSigneeId.Text) ||
                    string.IsNullOrWhiteSpace(txtMissionName.Text
                    ))
                {
                    MessageBox.Show("יש למלא את כל השדות החיוניים לפני שליחה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                byte[] signatureBytes = GetSignatureBytes();
                if (signatureBytes.Length < 1000) // סינון לחתימה ריקה
                {
                    MessageBox.Show("יש להוסיף חתימה לפני השליחה.", "חתימה חסרה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string base64Signature = Convert.ToBase64String(signatureBytes);

                Signature missionSignature = new Signature();

                //var payload = new
                //{
                //    missionId = loadedMission.missionId,
                //    signerId = txtSigneeId.Text,
                //    commanderName = txtCommanderName.Text,
                //    signeeName = txtSigneeName.Text,
                //    signeeId = txtSigneeId.Text,
                //    missionName = txtMissionName.Text,
                //    signeeSignDate = dtpSigneeDate.Value.ToString("yyyy-MM-dd"),
                //    signature = base64Signature
                //};
                missionSignature.missionId = loadedMission.missionId;
                missionSignature.missionName = loadedMission.missionName;
                missionSignature.signingPerson = txtSigneeName.Text;
                missionSignature.signingPersonNumber = txtSigneeId.Text;
                missionSignature.stampeerPerson = txtCommanderName.Text;
                missionSignature.stampeerPersonNumber = txtCommanderId.Text;
                missionSignature.isSigned = true;
                missionSignature.date = dtpSigneeDate.Value.ToString("yyyy-MM-dd");
                missionSignature.signatureBase64 = base64Signature;

                

                ConnectionHandler.SendRequest("signature", "UpsertSignature", missionSignature);
                MessageBox.Show("החתימה נשלחה בהצלחה!", "אישור", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();

                //if (result.ToString().Contains("ok"))
                //{
                //    MessageBox.Show("החתימה נשלחה בהצלחה!", "אישור", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    this.DialogResult = DialogResult.OK;
                //    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show("שליחה נכשלה: " + result.ToString(), "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה במהלך השליחה: " + ex.Message);
            }
        }
        private void SignaturePanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(signatureBitmap, Point.Empty);
        }
        public static void fillSignature(Signature fillSignature, mission missionToDigitalSignature)
        {
            var digitalSignature = new SignatureForm(missionToDigitalSignature);
            if (missionToDigitalSignature.isSigned == true)
            {
                
                digitalSignature.txtSigneeName.Text = fillSignature.signingPerson;
                digitalSignature.txtSigneeId.Text = fillSignature.signingPersonNumber;
                digitalSignature.txtCommanderName.Text = fillSignature.stampeerPerson;
                digitalSignature.txtCommanderId.Text = fillSignature.stampeerPersonNumber;
                try
                {
                    byte[] imageBytes = Convert.FromBase64String(fillSignature.signatureBase64);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Bitmap bitmap = new Bitmap(ms);
                        digitalSignature.signaturePanel.BackgroundImage = bitmap; // Set the panel's background image
                        digitalSignature.signaturePanel.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Adjust layout (Stretch, Center, Tile, etc.)
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show($"אין חתימה דיגיטלית");
            }
            digitalSignature.Show();
        }
    }
}