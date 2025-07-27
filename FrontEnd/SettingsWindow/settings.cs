using System.Drawing.Drawing2D;
using Tikshuv.FrontEnd.SettingsWindow;
using Tikshuv.FrontEnd.SettingsWindow.Equipment;
using Tikshuv.SubForms;

namespace Tikshuv.FrontEnd
{
    public partial class settings : Form
    {

        private int cornerRadius = 15;
        public Point mouseLocation;
        public settings()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Form_Resize);
        }
        private void Form_Resize(object sender, EventArgs e)
        {
            ApplyRoundedCorners(this.cornerRadius);
        }

        private void ApplyRoundedCorners(int radius)
        {
            var path = new GraphicsPath();
            int adjustedRadius = radius * 2;

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, adjustedRadius, adjustedRadius), 180, 90); // Top-left corner
            path.AddArc(new Rectangle(this.Width - adjustedRadius - 1, 0, adjustedRadius, adjustedRadius), 270, 90); // Top-right corner
            path.AddArc(new Rectangle(this.Width - adjustedRadius - 1, this.Height - adjustedRadius - 1, adjustedRadius, adjustedRadius), 0, 90); // Bottom-right corner
            path.AddArc(new Rectangle(0, this.Height - adjustedRadius - 1, adjustedRadius, adjustedRadius), 90, 90); // Bottom-left corner
            path.CloseFigure();

            this.Region = new Region(path);
            path.Dispose(); // Dispose of the GraphicsPath object to free resources
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void Solider_Click(object sender, EventArgs e)
        {
            openChildForm(new Solider());
        }


        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the warehouse window only.
        }

        private void ScreenSize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                ScreenSize.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Full_screen)); ;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                ScreenSize.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.small_screen)); ;
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            activeForm = childForm;
            //childForm = BringToFront();
            childForm.Show();
        }

        private void managequ_Click(object sender, EventArgs e)
        {
            openChildForm(new EquipmentSettings());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports());
        }
    }
}
