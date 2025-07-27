namespace Tikshuv.FrontEnd
{
    partial class SignatureForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCommanderName;
        private System.Windows.Forms.Label lblCommanderId;
        private System.Windows.Forms.Label lblSigneeName;
        private System.Windows.Forms.Label lblSigneeId;
        private System.Windows.Forms.Label lblSigneeDate;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.Label lblDeployment;
        private System.Windows.Forms.Label lblGridTitle;

        public System.Windows.Forms.TextBox txtCommanderName;
        public System.Windows.Forms.TextBox txtCommanderId;

        public System.Windows.Forms.TextBox txtSigneeName;
        public System.Windows.Forms.TextBox txtSigneeId;
        public System.Windows.Forms.DateTimePicker dtpSigneeDate;
        public System.Windows.Forms.Panel signaturePanel;
        public System.Windows.Forms.DataGridView equipmentGrid;
        private System.Windows.Forms.DataGridView depositsGrid;

        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCommanderName = new System.Windows.Forms.Label();
            this.lblCommanderId = new System.Windows.Forms.Label();
            this.lblSigneeName = new System.Windows.Forms.Label();
            this.lblSigneeId = new System.Windows.Forms.Label();
            this.lblSigneeDate = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.lblDeployment = new System.Windows.Forms.Label();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.txtCommanderName = new System.Windows.Forms.TextBox();
            this.txtCommanderId = new System.Windows.Forms.TextBox();
            this.txtSigneeName = new System.Windows.Forms.TextBox();
            this.txtSigneeId = new System.Windows.Forms.TextBox();
            this.dtpSigneeDate = new System.Windows.Forms.DateTimePicker();
            this.signaturePanel = new System.Windows.Forms.Panel();
            this.equipmentGrid = new System.Windows.Forms.DataGridView();
            this.depositsGrid = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMissionName = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(50, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(400, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "טופס חתימה על ציוד מסווג";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCommanderName
            // 
            this.lblCommanderName.Location = new System.Drawing.Point(400, 60);
            this.lblCommanderName.Name = "lblCommanderName";
            this.lblCommanderName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCommanderName.Size = new System.Drawing.Size(100, 23);
            this.lblCommanderName.TabIndex = 1;
            this.lblCommanderName.Text = "שם מחתים:";
            this.lblCommanderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCommanderId
            // 
            this.lblCommanderId.Location = new System.Drawing.Point(400, 90);
            this.lblCommanderId.Name = "lblCommanderId";
            this.lblCommanderId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCommanderId.Size = new System.Drawing.Size(100, 23);
            this.lblCommanderId.TabIndex = 3;
            this.lblCommanderId.Text = "מ.א מחתים:";
            this.lblCommanderId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSigneeName
            // 
            this.lblSigneeName.Location = new System.Drawing.Point(130, 60);
            this.lblSigneeName.Name = "lblSigneeName";
            this.lblSigneeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSigneeName.Size = new System.Drawing.Size(100, 23);
            this.lblSigneeName.TabIndex = 7;
            this.lblSigneeName.Text = "שם החותם:";
            this.lblSigneeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSigneeId
            // 
            this.lblSigneeId.Location = new System.Drawing.Point(130, 90);
            this.lblSigneeId.Name = "lblSigneeId";
            this.lblSigneeId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSigneeId.Size = new System.Drawing.Size(100, 23);
            this.lblSigneeId.TabIndex = 9;
            this.lblSigneeId.Text = "מ.א חותם:";
            this.lblSigneeId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSigneeDate
            // 
            this.lblSigneeDate.Location = new System.Drawing.Point(379, 125);
            this.lblSigneeDate.Name = "lblSigneeDate";
            this.lblSigneeDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSigneeDate.Size = new System.Drawing.Size(100, 23);
            this.lblSigneeDate.TabIndex = 11;
            this.lblSigneeDate.Text = "תאריך חתימה:";
            this.lblSigneeDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSignature
            // 
            this.lblSignature.Location = new System.Drawing.Point(420, 154);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSignature.Size = new System.Drawing.Size(100, 23);
            this.lblSignature.TabIndex = 13;
            this.lblSignature.Text = "חתימה:";
            this.lblSignature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeployment
            // 
            this.lblDeployment.Location = new System.Drawing.Point(400, 290);
            this.lblDeployment.Name = "lblDeployment";
            this.lblDeployment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDeployment.Size = new System.Drawing.Size(100, 23);
            this.lblDeployment.TabIndex = 15;
            this.lblDeployment.Text = "שם פריסה:";
            this.lblDeployment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.Location = new System.Drawing.Point(400, 324);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGridTitle.Size = new System.Drawing.Size(100, 23);
            this.lblGridTitle.TabIndex = 17;
            this.lblGridTitle.Text = "טבלת ציוד:";
            this.lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCommanderName
            // 
            this.txtCommanderName.Location = new System.Drawing.Point(280, 60);
            this.txtCommanderName.Name = "txtCommanderName";
            this.txtCommanderName.Size = new System.Drawing.Size(114, 27);
            this.txtCommanderName.TabIndex = 2;
            // 
            // txtCommanderId
            // 
            this.txtCommanderId.Location = new System.Drawing.Point(280, 90);
            this.txtCommanderId.Name = "txtCommanderId";
            this.txtCommanderId.Size = new System.Drawing.Size(114, 27);
            this.txtCommanderId.TabIndex = 4;
            // 
            // txtSigneeName
            // 
            this.txtSigneeName.Location = new System.Drawing.Point(10, 60);
            this.txtSigneeName.Name = "txtSigneeName";
            this.txtSigneeName.Size = new System.Drawing.Size(114, 27);
            this.txtSigneeName.TabIndex = 8;
            // 
            // txtSigneeId
            // 
            this.txtSigneeId.Location = new System.Drawing.Point(10, 90);
            this.txtSigneeId.Name = "txtSigneeId";
            this.txtSigneeId.Size = new System.Drawing.Size(114, 27);
            this.txtSigneeId.TabIndex = 10;
            // 
            // dtpSigneeDate
            // 
            this.dtpSigneeDate.Location = new System.Drawing.Point(120, 125);
            this.dtpSigneeDate.Name = "dtpSigneeDate";
            this.dtpSigneeDate.Size = new System.Drawing.Size(237, 27);
            this.dtpSigneeDate.TabIndex = 12;
            // 
            // signaturePanel
            // 
            this.signaturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signaturePanel.Location = new System.Drawing.Point(30, 180);
            this.signaturePanel.Name = "signaturePanel";
            this.signaturePanel.Size = new System.Drawing.Size(460, 100);
            this.signaturePanel.TabIndex = 14;
            this.signaturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.signaturePanel_MouseDown);
            this.signaturePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.signaturePanel_MouseMove);
            this.signaturePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.signaturePanel_MouseUp);
            // 
            // equipmentGrid
            // 
            this.equipmentGrid.AllowUserToAddRows = false;
            this.equipmentGrid.AllowUserToDeleteRows = false;
            this.equipmentGrid.AllowUserToResizeRows = false;
            this.equipmentGrid.ColumnHeadersHeight = 29;
            this.equipmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.serialNumber,
            this.addons});
            this.equipmentGrid.Location = new System.Drawing.Point(30, 350);
            this.equipmentGrid.Name = "equipmentGrid";
            this.equipmentGrid.RowHeadersWidth = 51;
            this.equipmentGrid.Size = new System.Drawing.Size(460, 120);
            this.equipmentGrid.TabIndex = 18;
            // 
            // depositsGrid
            // 
            this.depositsGrid.ColumnHeadersHeight = 29;
            this.depositsGrid.Location = new System.Drawing.Point(30, 480);
            this.depositsGrid.Name = "depositsGrid";
            this.depositsGrid.RowHeadersWidth = 51;
            this.depositsGrid.Size = new System.Drawing.Size(460, 100);
            this.depositsGrid.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 600);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "שמירה";
            this.btnSave.Click += BtnSave_Click;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(120, 600);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 38);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "שליחה";
            this.btnSend.Click += btnSend_Click;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(210, 600);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "ניקוי";
            this.btnClear.Click += btnClearSignature_Click;
            // 
            // txtMissionName
            // 
            this.txtMissionName.Location = new System.Drawing.Point(30, 290);
            this.txtMissionName.Name = "txtMissionName";
            this.txtMissionName.Size = new System.Drawing.Size(360, 27);
            this.txtMissionName.TabIndex = 16;
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.HeaderText = "שם פריט";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            // 
            // serialNumber
            // 
            this.serialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serialNumber.HeaderText = "מס\"ד";
            this.serialNumber.MinimumWidth = 6;
            this.serialNumber.Name = "serialNumber";
            // 
            // addons
            // 
            this.addons.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addons.HeaderText = "תוספות";
            this.addons.MinimumWidth = 6;
            this.addons.Name = "addons";
            // 
            // SignatureForm
            // 
            this.ClientSize = new System.Drawing.Size(540, 650);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCommanderName);
            this.Controls.Add(this.txtCommanderName);
            this.Controls.Add(this.lblCommanderId);
            this.Controls.Add(this.txtCommanderId);
            this.Controls.Add(this.lblSigneeName);
            this.Controls.Add(this.txtSigneeName);
            this.Controls.Add(this.lblSigneeId);
            this.Controls.Add(this.txtSigneeId);
            this.Controls.Add(this.lblSigneeDate);
            this.Controls.Add(this.dtpSigneeDate);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.signaturePanel);
            this.Controls.Add(this.lblDeployment);
            this.Controls.Add(this.txtMissionName);
            this.Controls.Add(this.lblGridTitle);
            this.Controls.Add(this.equipmentGrid);
            this.Controls.Add(this.depositsGrid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClear);
            this.Name = "SignatureForm";
            this.Text = "טופס חתימה דיגיטלית";
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public TextBox txtMissionName;
        private DataGridViewTextBoxColumn itemName;
        private DataGridViewTextBoxColumn serialNumber;
        private DataGridViewTextBoxColumn addons;
    }
}