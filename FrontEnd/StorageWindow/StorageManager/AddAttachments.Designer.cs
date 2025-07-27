using System;
using System.Windows.Forms;

namespace Tikshuv.FrontEnd.StorageWindow.StorageManager
{
    partial class AddAttachments
    {
     


        private System.ComponentModel.IContainer components = null;
        private TextBox txtDescription;
        private ComboBox cmbType;
        private ComboBox cmbEquipment;
        private Label lblDesc;
        private Label lblType;
        private Label lblEquipment;


        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbEquipment = new System.Windows.Forms.ComboBox();
            this.attachmentsListBox = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.lblExisting = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(34, 600);
            this.LeftPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(880, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(34, 600);
            this.panel4.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("David", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(171, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 34);
            this.txtName.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("David", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(171, 75);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(261, 60);
            this.txtDescription.TabIndex = 3;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("David", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbType.Items.AddRange(new object[] {
            "חשמל",
            "ציוד עזר",
            "בטיחות",
            "תקשורת",
            "תחזוקה",
            "חלק חילוף",
            "אחר"});
            this.cmbType.Location = new System.Drawing.Point(171, 150);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(261, 31);
            this.cmbType.TabIndex = 4;
            // 
            // cmbEquipment
            // 
            this.cmbEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipment.Font = new System.Drawing.Font("David", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbEquipment.Location = new System.Drawing.Point(171, 195);
            this.cmbEquipment.Name = "cmbEquipment";
            this.cmbEquipment.Size = new System.Drawing.Size(261, 31);
            this.cmbEquipment.TabIndex = 5;
            // 
            // attachmentsListBox
            // 
            this.attachmentsListBox.Font = new System.Drawing.Font("David", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attachmentsListBox.ItemHeight = 23;
            this.attachmentsListBox.Location = new System.Drawing.Point(171, 240);
            this.attachmentsListBox.Name = "attachmentsListBox";
            this.attachmentsListBox.Size = new System.Drawing.Size(261, 165);
            this.attachmentsListBox.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(448, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 32);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "שם תוספת";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDesc.Location = new System.Drawing.Point(448, 75);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(160, 32);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "תיאור";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblType.Location = new System.Drawing.Point(448, 150);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(160, 32);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "סוג תוספת";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEquipment
            // 
            this.lblEquipment.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEquipment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEquipment.Location = new System.Drawing.Point(448, 195);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(160, 32);
            this.lblEquipment.TabIndex = 10;
            this.lblEquipment.Text = "ציוד (אופציונלי)";
            this.lblEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExisting
            // 
            this.lblExisting.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExisting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExisting.Location = new System.Drawing.Point(448, 240);
            this.lblExisting.Name = "lblExisting";
            this.lblExisting.Size = new System.Drawing.Size(160, 32);
            this.lblExisting.TabIndex = 11;
            this.lblExisting.Text = "תוספות קיימות";
            this.lblExisting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(280, 440);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 35);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "הוסף";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddAttachments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbEquipment);
            this.Controls.Add(this.attachmentsListBox);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.lblExisting);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAttachments";
            this.Text = "Add New Attachment";
            this.Load += new System.EventHandler(this.AddAttachments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private Panel titleBar;
        private Button closeButton;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox attachmentsListBox;
        private System.Windows.Forms.Label lblExisting;
    }
}

