using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tikshuv.Logic;
using Tikshuv.Logic.DataAccess;
using Tikshuv.SubForms.LogicSubForms;


namespace Tikshuv.SubForms
{
    public partial class Solider : Form
    {
        private static bool ReservistList = false;
        private static bool RegulatoryList = false;
        private static bool MandatoryList = false;
        private static bool OutsidersList = false;
        private Point mouseLocation;

        public DataManager dataManager;
        public Solider()
        {
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
            closeButton.Click += (s, e) => { this.Close(); CloseSidePanle(); };

            titleBar.Controls.Add(closeButton);
            this.Controls.Add(titleBar);

            Label titleLabel = new Label
            {
                Text = "רשימת בעלי גישה",
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


            ConnectionHandler.SendRequest("solider", "getAllExistingSoliders", "");
            dgvTable.Rows.Clear();

            searchbutton.Click += new EventHandler(searchbutton_Click);

        }

        //SearchBar
        private void SearchBar_MouseClick(object sender, MouseEventArgs e)
        {
            SearchBar.Text = "";
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            SearchData(SearchBar.Text); //Run a search with the text from the field
        }

        private void SearchData(string filter)
        {
            dgvTable.Rows.Clear(); //Clear the table

            // If search is empty - exit without doing anything
            if (string.IsNullOrWhiteSpace(filter))
            {
                return;
            }

            //Filter all existing lists in memory
            foreach (var soldier in publicData.existingRegulatorySoliders
                                            .Concat(publicData.existingMandatorySoliders)
                                            .Concat(publicData.existingResrvistsSoliders)
                                            .Concat(publicData.existingOutsidersSoliders)
                                            .Where(s => s.Name.Contains(filter) ||
                                                        s.FamilyName.Contains(filter)))
            {
                //Add the matching soldier to the table.
                dgvTable.Rows.Add(soldier.ID,
                                 soldier.Name,
                                 soldier.FamilyName,
                                 soldier.PhoneNumber,
                                 soldier.DateofBirth,
                                 soldier.premissionLevel);
            }
        }



        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void dgvTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //throw new NotImplementedException();
        }
        //Buttons
      
        private void NewSolider_Click(object sender, EventArgs e)
        {
            Console.WriteLine("NewSolider clicked - starting timer");
            animationTimer.Start();
            //var addForm = new AddingSolidersForm();

            //addForm.FormClosed += (s, args) => CloseSidePanle();
            //openChildForm(addForm);
            ////openChildForm(new AddingSolidersForm());
        }

        private void ReservePersonnel_Click(object sender, EventArgs e)
        {
            dgvTable.Rows.Clear();
            foreach (var x in publicData.existingResrvistsSoliders)
            {
                dgvTable.Rows.Add(x.ID, x.Name, x.FamilyName, x.PhoneNumber, x.DateofBirth, x.premissionLevel);

            }
        }
        private void RegulatoryPersonnel_Click(object sender, EventArgs e)
        {
            dgvTable.Rows.Clear();
            foreach (var x in publicData.existingRegulatorySoliders)
            {
                dgvTable.Rows.Add(x.ID, x.Name, x.FamilyName, x.PhoneNumber, x.DateofBirth, x.premissionLevel);
            }
        }
        private void MendetorButton_Click(object sender, EventArgs e)
        {
            dgvTable.Rows.Clear();
            foreach(var x in publicData.existingMandatorySoliders)
            {
                dgvTable.Rows.Add(x.ID,x.Name,x.FamilyName,x.PhoneNumber,x.DateofBirth,x.premissionLevel);

            }
        }
        private void OutsidersPersonnel_Click(object sender, EventArgs e)
        {
            dgvTable.Rows.Clear();
            foreach (var x in publicData.existingOutsidersSoliders)
            {
                dgvTable.Rows.Add(x.ID, x.Name, x.FamilyName, x.PhoneNumber, x.DateofBirth, x.premissionLevel);

            }
        }

        //Logic
        private void LoadFilteredSoldierData(int serviceType)
        {
           
        }
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine($"Current sidePanel width: {sidePanel.Width}");

            if (sidePanel.Width >= 24)
            {
                sidePanel.Width = 200;
                Console.WriteLine("Reached target width - opening form");
                animationTimer.Stop();
                var addForm = new AddingSolidersForm();

                addForm.FormClosed += (s, args) => CloseSidePanle();
                openChildForm(addForm);


            }
            else
            {
                sidePanel.Width += 4;
            }
        }

        private void LoadSoldierData()
        {
            
        }
        private void openChildForm(Form childForm)
        {
            try
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

                sidePanel.Controls.Clear(); //
                sidePanel.Controls.Add(childForm);
                sidePanel.BringToFront(); sidePanel.BringToFront();
                childForm.Show();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening form: {ex.Message}");
            }
        }

        public void CloseSidePanle()
        {
            sidePanel.Width = 0;
        }

        private void SearchBar_Enter(object sender, EventArgs e)
        {
            if (SearchBar.Text == "חיפוש")
            {
                SearchBar.Text = "";
                SearchBar.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void SearchBar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchBar.Text))
            {
                SearchBar.Text = "חיפוש";
                SearchBar.ForeColor = System.Drawing.Color.Gray;
            }
        }

    }

}

