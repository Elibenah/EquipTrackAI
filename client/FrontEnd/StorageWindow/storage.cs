using Tikshuv.FrontEnd.StorageWindow.StorageManager;
using Tikshuv.Logic;
using Tikshuv.Logic.DataAccsess;

namespace Tikshuv.FrontEnd
{
    public partial class storage : Form
    {
        public static string equipmentDataBase;
        public static string existItemsByTypeDataBase;
        public storage()
        {
            InitializeComponent();
            customizeDesing();
            ConnectionHandler.SendRequest("equipment", "getExistingEquipmentByType", "");
            ConnectionHandler.SendRequest("equipment", "getExistsEquipmentsList", "");
            ConnectionHandler.SendRequest("equipment", "getExistsAttachmentList", "");
            //Logic.ConnectionHandler.WaitForAuthorization();

        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the warehouse window only.
        }


        private void manager_Click(object sender, EventArgs e)
        {
            showSubMenu(subpanalManager);
        }
        private void customizeDesing()
        {
            subpanalManager.Visible = false;
            submenuqures.Visible = false;
        }
        private void hideSubMenu()
        {
            if (subpanalManager.Visible == true)
                subpanalManager.Visible = false;
            if (submenuqures.Visible == true)
                submenuqures.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
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
            childForm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            activeForm = childForm;
            //childForm = BringToFront();
            childForm.Show();
            hideSubMenu();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new CreateNewEquipment());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new AddingNewEquipment());

        }
        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new EquipmentFinder());

        }
        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new DeleteEquipment());

        }
        private void reportsButton_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuqures);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new ItemHistory());
        }
        private void button8_Click(object sender, EventArgs e)
        {
            
        }
        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new AddAttachments());
        }
        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new EditEntityObject());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
