using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiferix.DotCoolGrid;
using Tikshuv.Logic;
using Tikshuv.Logic.DataAccsess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Tikshuv.FrontEnd.StorageWindow.StorageManager
{
    public partial class AddingNewEquipment : Form
    {
        private Point mouseLocation;
        public AddingNewEquipment()
        {
            InitializeComponent();

            titleBar = new Panel
            {
                Height = 30,
                Dock = DockStyle.Top,
                BackColor = Color.LightGray
            };

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
                Text = "הוספת ציוד",
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

            foreach (Equipment iterator in publicData.existsEquipmentsList)
            {
                equipmentItemBox.Items.Add(iterator.type);
            }
        }
        private void clnbtn_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string key = "", value = "";
            string message = "פריט הוסף בהצלחה";
            string title = "התראה";
            Equipment addedItem = new Equipment();
            addedItem.type = equipmentItemBox.SelectedItem.ToString();
            addedItem.catalogNumber = catalogNumberBox.Text;
            addedItem.serialNumber = serialNumberBox.Text.ToUpper();
            addedItem.specialAttributes = new Dictionary<string, object>();



            Equipment obj = publicData.existsEquipmentsList.Cast<Equipment>().FirstOrDefault(c => c.type == addedItem.type);
            if (obj.specialAttributes.ContainsKey("תוספות"))
            {
                addedItem.specialAttributes.Add("תוספות", obj.specialAttributes["תוספות"]);
            }

            if (Equipment.checkIfItemExists(serialNumberBox.Text) && serialNumberBox.Text != "" && serialNumberBox.Text != "N/A" && serialNumberBox.Text != "N\\A")
            {
                message = "בעיה במספר סידורי";
                MessageBox.Show(message, title);
                return;
            }
            for (int rows = 0; rows < dgvTable.Rows.Count-1; rows++)
            {
                try
                {
                    key = dgvTable.Rows[rows].Cells[0].Value.ToString();
                    value = dgvTable.Rows[rows].Cells[1].Value.ToString();
                }
                catch (Exception ex)
                {
                    message = "אחד או יותר מהתאים לא מלאים";
                    MessageBox.Show(message, title);
                    return;
                }
                addedItem.specialAttributes.Add(key, value);
            }
            addedItem.lastChange = DateTime.Now;
            ConnectionHandler.SendRequest("equipment", "addItemsToEquipment", addedItem);
            MessageBox.Show(message, title);
        }
        private void equipmentItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTable.Rows.Clear();
            Equipment specifiedItem = new Equipment();
            specifiedItem.specialAttributes = new Dictionary<string, object>();
            foreach (Equipment iterator in publicData.existsEquipmentsList)
            {
                if (iterator.type == equipmentItemBox.SelectedItem.ToString())
                {
                    specifiedItem = iterator;
                    break;
                }
            }
            foreach (var attribute in specifiedItem.specialAttributes)
            {
                System.Type type = attribute.Value.GetType();
                if (attribute.Key == "תוספות")
                {

                    //string addon = "";
                    //foreach(Attachment attachment in ((JArray)attribute.Value).Select(item => JsonConvert.DeserializeObject<Attachment>(item.ToString())).ToList())
                    //{
                    //    addon = attachment.name + ", " + addon;
                    //}
                    
                    //dgvTable.Rows.Add(attribute.Key.ToString(),attribute.Value);
                }
                else
                {
                    dgvTable.Rows.Add(attribute.Key.ToString());
                }
                
            }
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

    }
}
