using Tikshuv.Logic;
using Tikshuv.Logic.DataAccsess;
using Tikshuv.SubForms;

namespace Tikshuv.FrontEnd
{
    public partial class Missions : Form
    {

        public static Dictionary<string, List<string>> availableEquimpments;
        private Point mouseLocation;
        public Missions()
        {
            ConnectionHandler.SendRequest("mission", "getAllMissions", "");
            ConnectionHandler.SendRequest("mission", "getAllHistoryMission", "");
            ConnectionHandler.SendRequest("equipment", "getExistingEquipmentByType", "");
            ConnectionHandler.SendRequest("signature", "GetMissionSummaries", "");
            //ConnectionHandler.SendRequest("equipment", "getExistsEquipmentsList", "");
            //ConnectionHandler.SendRequest("equipment", "getExistsAttachmentList", "");


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

            // Allows you to drag the window by clicking on the panel
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

            updateAvailableEquipment();
            customizeDesing();
        }
        public static void updateAvailableEquipment()
        {
            availableEquimpments = new Dictionary<string, List<string>>();
            foreach (KeyValuePair<string, List<Equipment>> entry in publicData.existItemsByType)
            {
                foreach (Equipment iterator in entry.Value)
                {
                    if (iterator.tempMissionName == null)
                    {
                        if (availableEquimpments.ContainsKey(iterator.type))
                        {
                            if (!availableEquimpments[iterator.type].Contains(iterator.serialNumber))
                            {
                                availableEquimpments[iterator.type].Add(iterator.serialNumber);
                            }
                        }
                        else
                        {
                            availableEquimpments.Add(iterator.type, new List<string> { iterator.serialNumber });
                        }
                    }
                    ///
                    /// need to add full integration of in order to add items that are both in temporary and in fixed missions
                    /// marking items that  are currently in fixed missions with * at the end
                    /// 
                    if (iterator.fixedMissionName != null)
                    {
                        if (availableEquimpments.ContainsKey(iterator.type))
                        {
                            if (!availableEquimpments[iterator.type].Contains(iterator.serialNumber))
                            {
                                availableEquimpments[iterator.type].Add(iterator.serialNumber + "*");
                            }
                        }
                        else
                        {
                            availableEquimpments.Add(iterator.type, new List<string> { iterator.serialNumber + "*" });
                        }
                    }
                }
            }
        }

        private void missionbutton_Click(object sender, EventArgs e)
        {
            showSubMenu(mission_subpanel);
        }

        private void missions_Click(object sender, EventArgs e)
        {
            openChildForm(new missions());
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); // סוגר את חלון המחסן בלבד
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

        private void customizeDesing()
        {
            mission_subpanel.Visible = false;
        }
        private void hideSubMenu()
        {
            if (mission_subpanel.Visible == true)
                mission_subpanel.Visible = false;
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
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            activeForm = childForm;
            childForm.Show();
            hideSubMenu();
        }

        private void Promotional_Click(object sender, EventArgs e)
        {
            openChildForm(new Promotional());

        }
        //Deposit_Click
        private void signedMission_Click(object sender, EventArgs e)
        {
            openChildForm(new signedMission());
        }

        private void Preparedness_Click(object sender, EventArgs e)
        {
            openChildForm(new Preparedness());
        }

        private void RepeteMissions_Click(object sender, EventArgs e)
        {
            openChildForm(new RepeteMissions());
        }

        private void new_mission_Click(object sender, EventArgs e)
        {

        }
    }
}
