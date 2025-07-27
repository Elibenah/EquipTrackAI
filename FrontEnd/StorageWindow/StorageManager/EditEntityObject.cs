using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiferix.DotCoolGrid;
using Tikshuv.Logic;
using Tikshuv.Logic.DataAccsess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Tikshuv.FrontEnd.StorageWindow.StorageManager
{
    public partial class EditEntityObject : Form
    {
        Equipment newItem = new Equipment();
        private CustomDropdown currentDropdown;
        private Point mouseLocation;
        public EditEntityObject()
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


            Label titleLabel = new Label
            {
                Text = "עריכת ציוד",
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

            this.LocationChanged += dgvTable_LocationChanged;
            newItem = new Equipment();
            newItem.Addons = new List<Attachment>();
            foreach(Equipment equipment in publicData.existsEquipmentsList)
            {
                equipmentItemBox.Items.Add(equipment.type);
            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string key = "", value = "";

            newItem.specialAttributes = new Dictionary<string, object>();
            for (int rows = 0; rows < dgvTable.Rows.Count - 1; rows++)
            {
                //newItem.serialNumber = dataGridView1.Rows[rows].Cells[1].Value.ToString();
          

                key = dgvTable.Rows[rows].Cells[0].Value.ToString();
                if (!dgvTable.Rows[rows].Cells[1].Value.ToString().Contains("תוספות"))
                {
                    value = "_string";
                    newItem.specialAttributes.Add(key, value);
                }
            }
            newItem.lastChange = DateTime.Now;
            ConnectionHandler.SendRequest("equipment", "updateEquipment", newItem);
            ConnectionHandler.SendRequest("equipment", "getExistingEquipmentByType", "");
        }
        private void addAddons_Click(object sender, EventArgs e)
        {
            List<string> attachmentList = new List<string>();
            foreach (Attachment attachment in publicData.existingAttachments)
            {
                attachmentList.Add(attachment.name);
            }
            int cellX = dgvTable.Location.X;
            int cellY = dgvTable.Location.Y;
            int cellWidth = dgvTable.Width;
            int cellHeight = dgvTable.Height;

            var dropdown = new CustomDropdown(attachmentList);
            if (newItem.Addons.Count > 0)
            {
                List<string> optionsToCheck = new List<string>();
                foreach (Attachment attachmentInItem in newItem.Addons)
                {
                    optionsToCheck.Add(attachmentInItem.name);
                }
                dropdown.SetCheckedOptions(optionsToCheck);

            }
            // Subscribe to the Closed event of the dropdown
            dropdown.SubscribeClosingEvent((s, ev) =>
            {
                var checkedStates = dropdown.GetCheckedStates();
                string cellValue = string.Join(", ", Enumerable.Range(0, dropdown.options.Count).Where(i => checkedStates[i]).Select(i => dropdown.options[i]));

                List<Attachment> addonList = new List<Attachment>();
                string[] result = cellValue.Split(new string[] { ", " }, StringSplitOptions.None);
                foreach (Attachment iterator in publicData.existingAttachments)
                {
                    if (result.Contains(iterator.name))
                    {
                        Attachment attachment = new Attachment();
                        attachment.name = iterator.name;
                        attachment.isCredited = false;
                        attachment.inMission = false;
                        if(!newItem.Addons.Contains(attachment))
                        {
                            newItem.Addons.Add(attachment);
                        }
                    }
                }
                

            });
            // Show the dropdown menu
            dropdown.ShowMenu(this, new Point(cellX, cellY),cellWidth,cellHeight);
            //currentDropdown = dropdown;
            
            
        }
        private void EquipmentItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           dgvTable.Rows.Clear();
            foreach(Equipment current in publicData.existsEquipmentsList)
            {
                if(current.type == equipmentItemBox.SelectedItem.ToString())
                {
                    newItem = current;
                    break;
                }
            }
            int i = 0;
            foreach(var item in newItem.specialAttributes)
            {

                dgvTable.Rows.Add();

                DataGridViewTextBoxCell specialAttributes = (DataGridViewTextBoxCell)(dgvTable.Rows[i].Cells[0]);
                DataGridViewComboBoxCell specialAttributesType = (DataGridViewComboBoxCell)(dgvTable.Rows[i].Cells[1]);

                DataGridViewTextBoxCell specialAttributesTextBoxCell = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell specialAttributesTypeTextBoxCell = new DataGridViewTextBoxCell();


                specialAttributes.Value = item.Key;
                specialAttributesType.Items.Add(item.Value);

                specialAttributes.Value = item.Key.ToString();
                specialAttributesType.Value = item.Value;


                specialAttributesTextBoxCell.Value = specialAttributes.Value;
                specialAttributesTextBoxCell.Style = specialAttributes.Style;
                specialAttributesTextBoxCell.Tag = specialAttributes.Tag;

                specialAttributesTypeTextBoxCell.Value = specialAttributesType.Value;
                specialAttributesTypeTextBoxCell.Style = specialAttributesType.Style;
                specialAttributesTypeTextBoxCell.Tag = specialAttributesType.Tag;





                dgvTable.Rows[i].Cells[0] = specialAttributesTextBoxCell;
                dgvTable.Rows[i].Cells[1] = specialAttributesTypeTextBoxCell;
                i++;
            }
            
        }
        private void DgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvTable_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvTable.CurrentCell.ColumnIndex >= 0 && dgvTable.Columns[dgvTable.CurrentCell.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                ComboBox comboBox = e.Control as ComboBox;
                if (comboBox != null)
                {
                    comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                    comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
                }
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dgvTable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the current cell is a DataGridViewComboBoxCell
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
                (sender as DataGridView)[e.ColumnIndex, e.RowIndex] is DataGridViewComboBoxCell)
            {
                // Customize the appearance of the DataGridViewComboBoxCell
                DataGridViewComboBoxCell comboBoxCell = (sender as DataGridView)[e.ColumnIndex, e.RowIndex] as DataGridViewComboBoxCell;

                // Set custom colors, font, etc.
                comboBoxCell.Style.ForeColor = Color.Magenta;
                comboBoxCell.Style.BackColor = Color.Yellow;


               
            }
        }
        private void dgvTable_LocationChanged(object sender, EventArgs e)
        {
            if (currentDropdown != null && currentDropdown.IsMenuOpen())
            {
                currentDropdown.HideMenu();
            }
        }
        private void dgvTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(e.RowIndex - 1 > 0)
            {
                dgvTable.TabIndex = e.RowIndex - 1;
            }
            else
            {
                dgvTable.TabIndex = 0;
            }
        }
        private void dgvTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
