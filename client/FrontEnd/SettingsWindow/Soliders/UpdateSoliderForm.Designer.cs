namespace Tikshuv.SubForms.LogicSubForms
{

    partial class UpdateSoliderForm
    {
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtFamilyName;
        private ComboBox cmbGender;
        private ComboBox cmbLevel;
        private TextBox txtPhoneNumber;
        private Button btnSave;
        private DateTimePicker dtpBirthDate;

        //private System.ComponentModel.IContainer components = null;
        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnClosePanel = new System.Windows.Forms.Button();
            this.btnClosePanel.Click += new System.EventHandler(this.btnClosePanel_Click);
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtFamilyName.Enter += new System.EventHandler(this.txtFamilyName_Enter);
            this.txtPhoneNumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(53, 27);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 27);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "מספר אישי";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(53, 80);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 27);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "שם פרטי";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Location = new System.Drawing.Point(53, 133);
            this.txtFamilyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(114, 27);
            this.txtFamilyName.TabIndex = 5;
            this.txtFamilyName.Text = "שם משפחה";
            this.txtFamilyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbGender
            // 
            this.cmbGender.Items.AddRange(new object[] {
            "זכר",
            "נקבה",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(41, 279);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbGender.Size = new System.Drawing.Size(138, 28);
            this.cmbGender.TabIndex = 7;
            this.cmbGender.Text = "מין";
            // 
            // cmbLevel
            // 
            this.cmbLevel.Items.AddRange(new object[] {
            "מילואים",
            "קבע",
            "סדיר",
            "חוץ"});
            this.cmbLevel.Location = new System.Drawing.Point(41, 240);
            this.cmbLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbLevel.Size = new System.Drawing.Size(138, 28);
            this.cmbLevel.TabIndex = 9;
            this.cmbLevel.Text = "תפקיד";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(53, 187);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(114, 27);
            this.txtPhoneNumber.TabIndex = 11;
            this.txtPhoneNumber.Text = "מספר קשר";
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(66, 397);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 33);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "עדכן";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.LightBlue;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(66, 436);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 33);
            this.exit.TabIndex = 13;
            this.exit.Text = "מחק\r\n";
            this.exit.UseVisualStyleBackColor = false;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(53, 320);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpBirthDate.Size = new System.Drawing.Size(137, 27);
            this.dtpBirthDate.TabIndex = 8;
            // 
            // btnClosePanel
            // 
            this.btnClosePanel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClosePanel.ForeColor = System.Drawing.Color.Red;
            this.btnClosePanel.Location = new System.Drawing.Point(173, 2);
            this.btnClosePanel.Name = "btnClosePanel";
            this.btnClosePanel.Size = new System.Drawing.Size(30, 30);
            this.btnClosePanel.TabIndex = 14;
            this.btnClosePanel.Text = "X";
            this.btnClosePanel.UseVisualStyleBackColor = true;
            // 
            // AddingSolidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(210, 499);
            this.Controls.Add(this.btnClosePanel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtFamilyName);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddingSolidersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New soliders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button exit;
        private Button btnClosePanel;
    }
}

