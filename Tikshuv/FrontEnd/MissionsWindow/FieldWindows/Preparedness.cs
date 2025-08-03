using System.DirectoryServices;
using Tikshuv.Logic.DataAccess;
using System.Data;
using System.Diagnostics;

namespace Tikshuv.SubForms
{
    public partial class Preparedness : Form
    {
        public DataManager dataManager;
        private System.Data.DataTable searchResults;
        private Point mouseLocation;


        public Preparedness()
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

            dataManager = new DataManager();
        }


        private System.Data.DataTable SearchMissions(string input)
        {
            string query = @"
                    SELECT M.Name, M.StartDate, M.EndDate 
                    FROM Missions M
                    INNER JOIN Equipment E ON M.Name = E.Location 
                    WHERE E.State = @PreparednessState";

            var parameters = new Dictionary<string, object>
    {
        { "@PreparednessState", "כוננות" }
    };

            return dataManager.ExecuteParameterizedQuery(query, parameters);
        }
        private void LoadTable(string missionName)
        {
            string query = @"
        SELECT M.Name, M.StartDate, M.EndDate 
        FROM Missions M
        INNER JOIN Equipment E ON M.Name = E.Location 
        WHERE E.State = @PreparednessState";

            var parameters = new Dictionary<string, object>
        {
            { "@PreparednessState", "כוננות" }
        };
            dataGridView.DataSource = dataManager.ExecuteParameterizedQuery(query, parameters);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.TextLength >= 3)
            {
                string input = txtSearch.Text.Trim();
                searchResults = SearchMissions(input);
                searchResult.DataSource = searchResults;

                if (searchResults != null && searchResult.Rows.Count > 0)
                {
                    searchResult.Height = searchResult.Rows.Count * 30;
                }
                else
                {
                    searchResult.Height = 0;
                }
            }
            else if (txtSearch.TextLength <= 0)
            {
                searchResult.Height = 0;
            }
        }

        private void searchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row index is valid
            if (e.RowIndex >= 0 && e.RowIndex < searchResult.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = searchResult.Rows[e.RowIndex];
                string missionName = selectedRow.Cells["Name"].Value?.ToString() ?? "N/A";
                MissionName.Text = missionName;

                txtSearch.Text = missionName;
                MissionPanel.Visible = true;
                searchResult.Height = 0;
                LoadTable(missionName);
            }
        }

    }
}
