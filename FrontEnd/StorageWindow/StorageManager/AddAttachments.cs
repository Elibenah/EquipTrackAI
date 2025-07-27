using System;
using System.Windows.Forms;
using Tikshuv.Logic;
using Tikshuv.Logic.DataAccsess;

namespace Tikshuv.FrontEnd.StorageWindow.StorageManager
{
    public partial class AddAttachments : Form
    {
        private string connectionString = @"D:\FP\TikshuvServer-master\TikshuvServer\bin\Debug\net6.0\Files\mainDataBase.db;Version=3;";
        private Point mouseLocation;
        public AddAttachments()
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
                Text = "הוספת תוספות",
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
            LoadAttachments(); // Load list when form opens
        }
        private void AddAttachments_Load(object sender, EventArgs e)
        {
            // Send request to get all equipment (assuming you have such endpoint)
            Tikshuv.Logic.ConnectionHandler.SendRequest("equipment", "getExistsEquipmentsList", "");

            // Fill equipment dropdown with dummy data (example)
            cmbEquipment.Items.Clear();
            foreach (var eq in publicData.existsEquipmentsList)
            {
                cmbEquipment.Items.Add($"{eq.id} - {eq.type}");
            }
        }



        // Load existing attachments from publicData (after fetching from server)
        public void LoadAttachments()
        {
            attachmentsListBox.Items.Clear();

            if (publicData.existingAttachments != null)
            {
                foreach (var attachment in publicData.existingAttachments)
                {
                    attachmentsListBox.Items.Add(attachment.name);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            string type = cmbType.SelectedItem?.ToString() ?? "אחר";
            string equipmentIdText = cmbEquipment.SelectedItem?.ToString();
            int? equipmentId = null;

            string message;
            string title = "התראה";

            // Validate required field: name
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("יש להזין שם תוספת", title);
                return;
            }

            // Check if name already exists in the list
            foreach (var item in attachmentsListBox.Items)
            {
                if (item.ToString().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("תוספת כבר קיימת", title);
                    return;
                }
            }

            // Try to parse equipment ID 
            if (!string.IsNullOrEmpty(equipmentIdText) && int.TryParse(equipmentIdText, out int parsedId))
            {
                equipmentId = parsedId;
            }

            // Create new attachment object
            var newAttachment = new Tikshuv.Logic.DataAccsess.Attachment
            {
                name = name,
                description = description,
                type = type,
                dateAdded = DateTime.Now,
                equipmentId = equipmentId
            };

            // Send the request to the server
            Tikshuv.Logic.ConnectionHandler.SendRequest("equipment", "addAttachment", newAttachment);

            // Immediately fetch updated list
            Tikshuv.Logic.ConnectionHandler.SendRequest("equipment", "getExistsAttachmentList", "");

            // Notify success
            MessageBox.Show("תוספת נשמרה בהצלחה", title);

            // Clear input fields
            txtName.Clear();
            txtDescription.Clear();
            cmbType.SelectedIndex = -1;
            cmbEquipment.SelectedIndex = -1;
            txtName.Focus();

            // Optionally reload existing attachments (if response hasn't updated yet)
            LoadAttachments();
        }

    }
}
