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
    public class CustomDropdown
    {
        public readonly List<string> options;
        private CheckedListBox checkedListBox;
        private ToolStripDropDown dropdownMenu;
        private ToolStripControlHost host;
        
        public CustomDropdown(List<string> options)
        {
            this.options = new List<string>();
            this.options = options;
            InitializeControls();

        }

        private void InitializeControls()
        {
            checkedListBox = new CheckedListBox();
            checkedListBox.CheckOnClick = true;
            checkedListBox.Dock = DockStyle.Fill;
            checkedListBox.BackColor = Color.FromArgb(25, 30, 60);
            checkedListBox.ForeColor = Color.FromArgb(255, 255, 255);
            checkedListBox.Font = new Font("microsoft sans serif", 12);
            foreach (var option in options)
            {
                checkedListBox.Items.Add(option);
            }

            dropdownMenu = new ToolStripDropDown();
            host = new ToolStripControlHost(checkedListBox);
            host.AutoSize = false;
            host.Size = checkedListBox.Size;
            dropdownMenu.Items.Add(host);
        }

        public List<bool> GetCheckedStates()
        {
            List<bool> checkedStates = new List<bool>();
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedStates.Add(checkedListBox.GetItemChecked(i));
            }
            return checkedStates;
        }

        public void ShowMenu(Control control, Point location, int width, int height)
        {
            host.Size = new Size(width, height);
            Point screenLocation = control.PointToScreen(location);
            dropdownMenu.Show(screenLocation);
        }

        public void HideMenu()
        {
            dropdownMenu.Close();
        }

        public bool IsMenuOpen()
        {
            return dropdownMenu.Visible;
        }

        public void SubscribeClosingEvent(ToolStripDropDownClosedEventHandler eventHandler)
        {
            dropdownMenu.Closed += eventHandler;
        }
        public void SetCheckedOptions(List<string> checkedOptions)
        {
            // Iterate through all items in the CheckedListBox
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                // Get the option text at the current index
                string option = checkedListBox.Items[i].ToString();

                // Check if this option is in the list of checked options
                if (checkedOptions.Contains(option))
                {
                    // Mark the item as checked
                    checkedListBox.SetItemChecked(i, true);
                }
                else
                {
                    // Optionally, you can also mark items as unchecked if they are not in the list
                    checkedListBox.SetItemChecked(i, false);
                }
            }
        }
    }














    public partial class CreateNewEquipment : Form
    {
        Equipment newItem = new Equipment();
        private CustomDropdown currentDropdown;
        private Point mouseLocation;
        public CreateNewEquipment()
        {
            this.LocationChanged += dgvTable_LocationChanged;
            newItem = new Equipment();
            newItem.Addons = new List<Attachment>();
            //options = currentDropdown.options;
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
                Text = "יצירת ציוד",
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

        }
        private void clnbtn_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string key = "", value = "";

            // Set equipment type from textbox
            newItem.type = txtName.Text.Trim();
            newItem.specialAttributes = new Dictionary<string, object>();

            for (int row = 0; row < dgvTable.Rows.Count - 1; row++)
            {
                var cellKey = dgvTable.Rows[row].Cells[0].Value;
                var cellType = dgvTable.Rows[row].Cells[1].Value;

                // Skip empty rows
                if (cellKey == null || cellType == null)
                    continue;

                key = cellKey.ToString();

                if (cellType.ToString().Contains("הערות") || cellType.ToString().Contains("טקסט חופשי"))
                {
                    // Free text field
                    value = "_string";
                    newItem.specialAttributes[key] = value;
                }
                else
                {
                    // Parse as list of attachments
                    List<Attachment> addonList = new List<Attachment>();
                    string[] selectedNames = cellType.ToString().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var name in selectedNames)
                    {
                        var match = publicData.existingAttachments.FirstOrDefault(a => a.name == name);
                        if (match != null)
                        {
                            addonList.Add(new Attachment
                            {
                                name = match.name,
                                isCredited = false,
                                inMission = false
                            });
                        }
                    }

                    if (addonList.Count > 0)
                        newItem.specialAttributes[key] = addonList;
                }
            }

            newItem.lastChange = DateTime.Now;

            // Prevent duplicates
            if (!publicData.existItemsByType.ContainsKey(newItem.type))
            {
                ConnectionHandler.SendRequest("equipment", "addEquipment", newItem);
                ConnectionHandler.SendRequest("equipment", "getExistingEquipmentByType", "");

                MessageBox.Show("פריט הוסף בהצלחה", "התראה");
                this.Close();
            }
            else
            {
                MessageBox.Show("פריט כבר קיים", "התראה");
                this.Close();
            }
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
            if(newItem.Addons.Count >0)
            {
                List<string> optionsToCheck = new List<string> ();
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
        private void clearText()
        {
            ClearTextBoxes(this);
        }
        private void ClearTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // If the control is a TextBox, clear its text
                if (ctrl is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                // If the control contains other controls, recursively clear them
                else if (ctrl.HasChildren)
                {
                    ClearTextBoxes(ctrl);
                }
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


                // You can customize other properties as needed
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
    }



//

}
