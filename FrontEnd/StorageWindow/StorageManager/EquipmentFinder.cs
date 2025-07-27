using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tikshuv.Logic;
using Tikshuv.Logic.DataAccsess;

namespace Tikshuv.FrontEnd.StorageWindow.StorageManager
{
    public partial class EquipmentFinder : Form
    {
        private static bool isSearchByMission = false;
        private static bool isSearchByItems = false;
        private Point mouseLocation;
        public EquipmentFinder()
        {
            isSearchByMission = false;
            isSearchByItems = false;
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

            Label titleLabel = new Label
            {
                Text = "חיפוש ציוד לפי משימה/סוג",
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
            ConnectionHandler.SendRequest("equipment", "getExistingEquipmentByType", "");
            ConnectionHandler.SendRequest("equipment", "getExistsEquipmentsList", "");
            ConnectionHandler.SendRequest("equipment", "getExistsAttachmentList", "");
        }
        private void searchByMission_Click(object sender, EventArgs e)
        {
            isSearchByMission = true;
            isSearchByItems = false;
            selectionComboBox.Items.Clear();

            foreach (mission iterator in publicData.missionsList)
            {
                selectionComboBox.Items.Add(iterator.missionName);
            }
        }
        private void searchByItems_Click(object sender, EventArgs e)
        {
            isSearchByItems = true;
            isSearchByMission = false;
            selectionComboBox.Items.Clear();
            foreach (KeyValuePair<string, List<Equipment>> entry in publicData.existItemsByType)
            {
                selectionComboBox.Items.Add(entry.Key);
            }
        }
        private void selectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTable.Rows.Clear();
            dgvTable.Columns.Clear();
            //dgvTable = new DataGridView();
            dgvTable.AllowUserToAddRows = true;
            string x = selectionComboBox.Text;


   
            //search by mission
            if (isSearchByMission)
            {
                mission choosedMission = new mission();
                dgvTable.Columns.Add("items", "שם פריט");
                dgvTable.Columns.Add("serialNumber", "מס\"ד");
                dgvTable.Columns.Add("notes", "הערות");
                foreach (mission iterator in publicData.missionsList)
                {
                    if (selectionComboBox.Text == iterator.missionName)
                    {
                        choosedMission = iterator;
                        break;
                    }
                }
                foreach (KeyValuePair<string, List<EquipmentInMission>> item in choosedMission.itemsInMissions)
                {
                    //add support to sub items
                    //dgvTable.Rows.Add(entry.Value,entry.Key);
                    foreach (EquipmentInMission soloItem in item.Value)
                    {
                        dgvTable.Rows.Add(item.Key, soloItem.serialNumber);
                    }
                }
            }
     
            //search by items start here


            else if (isSearchByItems)
            {
                //missionObject choosedMission = new missionObject();
                List<Equipment> choosedItems = new List<Equipment>();
                Equipment specifiedItemType = new Equipment();
                foreach (KeyValuePair<string, List<Equipment>> entry in publicData.existItemsByType)
                {
                    //selectionComboBox.Items.Add(entry.Key);
                    if (selectionComboBox.Text == entry.Key)
                    {
                        choosedItems = entry.Value;
                        break;
                    }
                }
                foreach (Equipment specifiedType in publicData.existsEquipmentsList)
                {
                    if (selectionComboBox.Text == specifiedType.type)
                    {
                        specifiedItemType = specifiedType;
                        break;
                    }
                }

                dgvTable.Columns.Add("items", "שם פריט");
                dgvTable.Columns.Add("catalogNumber", "מק\"ט");
                dgvTable.Columns.Add("serialNumber", "מס\"ד");
                dgvTable.Columns.Add("tempMission", "משימה זמנית");
                dgvTable.Columns.Add("fixedMission", "משימת כוננות");
                dgvTable.Columns.Add("currentMission", "משימת נוכחית");
                dgvTable.Columns.Add("location", "מיקום");
                //7 cells, meaning 7 and above is special atrributes

                int i = 1;
                foreach (KeyValuePair<string, object> entry in specifiedItemType.specialAttributes)
                {

                    dgvTable.Columns.Add("specialAttributes" + i.ToString(), entry.Key);
                    i++;
                }

                foreach (Equipment item in choosedItems)
                {
                    int index = dgvTable.Rows.Add(item.type, item.catalogNumber, item.serialNumber, item.tempMissionName == null ? "N/A" : item.tempMissionName,
                    item.fixedMissionName == null ? "N/A" : item.fixedMissionName, item.currentMissionName == null ? "N/A" : item.currentMissionName, item.location);

                    foreach (KeyValuePair<string, object> entry in item.specialAttributes)
                    {

                        string columnHeader = entry.Key; // Specify the desired column header text
                        string newValue = entry.Value != null ? entry.Value.ToString() : "null"; // Specify the new value to be assigned

                        // Find the column by its header text
                        DataGridViewColumn column = dgvTable.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.HeaderText == columnHeader);

                        // Check if the column was found
                        if (column != null)
                        {
                            // Access the column index
                            int columnIndex = column.Index;

                            // Iterate over the rows
                            foreach (DataGridViewRow row in dgvTable.Rows)
                            {
                                // Check if it's the desired row where you want to set the value
                                // For example, let's say you want to set the value in the 3rd row
                                int desiredRowIndex = choosedItems.IndexOf(item); // 0-based index

                                if (row.Index == desiredRowIndex)
                                {
                                    // Set the value only in the desired cell
                                    row.Cells[columnIndex].Value = newValue;
                                    break; // Exit the loop since you found the desired row
                                }
                            }
                        }
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
        }
        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvTable.BeginEdit(true);
            }
        }

        // Handle the CellValueChanged event of the DataGridView
        private void dgvTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 1)
            {
                // Get the selected serial number from the serial number combo box
                string selectedSerialNumber = dgvTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                // Set the value of the next cell to the selected serial number
                if (!string.IsNullOrEmpty(selectedSerialNumber) && e.ColumnIndex < dgvTable.Columns.Count - 1)
                {
                    dgvTable.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = selectedSerialNumber;
                }
            }
        }

        private void exportToExcel_Click(object sender, EventArgs e)
        {
            //documentProcessing.excelProcess(dgvTable, selectionComboBox.Text);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
