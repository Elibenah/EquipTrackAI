using HandyControl.Controls;
using Microsoft.Office.Interop.Outlook;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using Tikshuv.FrontEnd;
using Tikshuv.Logic;
using Tikshuv.Logic.DataAccess;

namespace Tikshuv.SubForms
{
    public partial class signedMission : Form
    {
        public DataManager dataManager;
        private Point mouseLocation;

        public signedMission()
        {
            ConnectionHandler.SendRequest("signature", "GetMissionSummaries", "");
            InitializeComponent();
            // Top gray stripe
            titleBar = new Panel
            {
                Height = 30,
                Dock = DockStyle.Top,
                BackColor = Color.LightGray
            };

            // Button X
            closeButton = new Button
            {
                Text = "X",
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Width = 30,
                Height = 30,
                Dock = DockStyle.Right
            };

            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Click += (s, e) => { this.Close(); };

            titleBar.Controls.Add(closeButton);
            this.Controls.Add(titleBar);

            titleBar.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    mouseLocation = new Point(-e.X, -e.Y);
                }
            };

            titleBar.MouseMove += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    Point mousePose = Control.MousePosition;
                    mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                    Location = mousePose;
                }
            };

            Label titleLabel = new Label
            {
                Text = "משימות מוחתמות",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };

            titleLabel.Location = new Point(
                (titleBar.Width - titleLabel.Width) / 2,
                (titleBar.Height - titleLabel.Height) / 2
            );
            titleBar.Controls.Add(titleLabel);

            if (publicData.AllSignatureSummery.Count>0)
            {
                dgvTable.Rows.Clear();
                foreach(var signature in publicData.AllSignatureSummery)
                {
                    dgvTable.Rows.Add(signature.missionName,signature.missionId, signature.isSigned);
                }
            }
            
        }
        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
        }

        private void dgvTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;



            // Check if this is the button column (by index or name)
            if (dgvTable.Columns[e.ColumnIndex].Name == "viewSign")
            {
                
                // Retrieve row data if needed
                var row = dgvTable.Rows[e.RowIndex];
                //var value = row.Cells["SomeColumn"].Value?.ToString();
                string missionId = row.Cells[1].Value?.ToString();
                //System.Windows.Forms.MessageBox.Show($"Button clicked for {value}");
                experimentalSndMessages.responseObject responseEx = Task.Run(async () =>
                {
                    return await experimentalSndMessages.ConnectionHandler.SendRequest("signature", "GetSignature", missionId);
                }).GetAwaiter().GetResult();

                Logic.DataAccsess.Signature signatureFromServer = new Logic.DataAccsess.Signature();
                signatureFromServer = (Logic.DataAccsess.Signature)Tikshuv.Logic.Handlers.SignatureResponse.SignatureResponseHandler(responseEx);
                
                Tikshuv.Logic.DataAccsess.mission matching_mission = publicData.missionsList.FirstOrDefault(m => m.missionId == missionId);
                
                if (matching_mission != null)
                {
                    SignatureForm.fillSignature(signatureFromServer,matching_mission);
                }
                else
                {
                    throw new System.Exception("not mission found");
                }

            }
        }
    }
}
