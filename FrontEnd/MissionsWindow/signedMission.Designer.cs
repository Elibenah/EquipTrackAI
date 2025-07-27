namespace Tikshuv.SubForms
{
    partial class signedMission
    {
        private Panel topPanel;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTable = new Tiferix.DotCoolGrid.DotCoolGridView();
            this.UpperPanel = new Tikshuv.FrontEnd.StorageWindow.StorageManager.RoundedPanel();
            this.LowerPanel = new Tikshuv.FrontEnd.StorageWindow.StorageManager.RoundedPanel();
            this.MissionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSigned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.viewSign = new System.Windows.Forms.DataGridViewButtonColumn();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.panel3);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(914, 67);
            this.topPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(914, 67);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(880, 67);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(34, 533);
            this.panel4.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 533);
            this.panel2.TabIndex = 30;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTable.BackGradientOffset = new System.Drawing.Point(0, 0);
            this.dgvTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTable.BackgroundGradientColor1 = System.Drawing.SystemColors.Control;
            this.dgvTable.BackgroundGradientColor2 = System.Drawing.SystemColors.Control;
            this.dgvTable.BackgroundImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.dgvTable.BackgroundImageOffset = new System.Drawing.Point(0, 0);
            this.dgvTable.BackgroundImageSizeMode = Tiferix.Global.CoolImageSizeMode.Normal;
            this.dgvTable.BackgroundImageTransColor = System.Drawing.Color.Transparent;
            this.dgvTable.BackgroundImageTransparent = false;
            this.dgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTable.CellTransAlpha = 0;
            this.dgvTable.CellTransColor = System.Drawing.SystemColors.Control;
            this.dgvTable.ColHeaderGradientBorderColor = System.Drawing.Color.Black;
            this.dgvTable.ColHeaderGradientColor1 = System.Drawing.SystemColors.Control;
            this.dgvTable.ColHeaderGradientColor2 = System.Drawing.SystemColors.Control;
            this.dgvTable.ColHeaderGradientOffset = new System.Drawing.Point(0, 0);
            this.dgvTable.ColHeadersFont = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvTable.ColHeaderTransAlpha = 0;
            this.dgvTable.ColHeaderTransColor = System.Drawing.SystemColors.Control;
            this.dgvTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MissionName,
            this.missionId,
            this.isSigned,
            this.viewSign});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTable.EnableHeadersVisualStyles = false;
            this.dgvTable.GridColor = System.Drawing.Color.White;
            this.dgvTable.Location = new System.Drawing.Point(34, 99);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 29;
            this.dgvTable.SelectedCellTransAlpha = 0;
            this.dgvTable.SelectedCellTransColor = System.Drawing.SystemColors.Control;
            this.dgvTable.Size = new System.Drawing.Size(846, 451);
            this.dgvTable.TabIndex = 40;
            this.dgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellClick);
            this.dgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellContentClick);
            this.dgvTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellValueChanged);
            this.dgvTable.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.UpperPanel.CornerRadius = 10;
            this.UpperPanel.Location = new System.Drawing.Point(34, 84);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(846, 191);
            this.UpperPanel.TabIndex = 41;
            // 
            // LowerPanel
            // 
            this.LowerPanel.BackColor = System.Drawing.Color.White;
            this.LowerPanel.CornerRadius = 10;
            this.LowerPanel.Location = new System.Drawing.Point(34, 389);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(846, 181);
            this.LowerPanel.TabIndex = 42;
            // 
            // MissionName
            // 
            this.MissionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MissionName.HeaderText = "שם משימה";
            this.MissionName.MinimumWidth = 6;
            this.MissionName.Name = "MissionName";
            this.MissionName.ReadOnly = true;
            this.MissionName.Width = 300;
            // 
            // missionId
            // 
            this.missionId.HeaderText = "מזהה משימה";
            this.missionId.MinimumWidth = 6;
            this.missionId.Name = "missionId";
            this.missionId.Width = 300;
            // 
            // isSigned
            // 
            this.isSigned.HeaderText = "חתום דיגיטלי?";
            this.isSigned.MinimumWidth = 6;
            this.isSigned.Name = "isSigned";
            this.isSigned.ReadOnly = true;
            // 
            // viewSign
            // 
            this.viewSign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.viewSign.HeaderText = "חתימה";
            this.viewSign.MinimumWidth = 6;
            this.viewSign.Name = "viewSign";
            this.viewSign.ReadOnly = true;
            this.viewSign.Text = "חתימה";
            // 
            // signedMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.UpperPanel);
            this.Controls.Add(this.LowerPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "signedMission";
            this.Text = "Equipment Finder";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        



        #endregion

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Implement search logic here
        }

        private Panel titleBar;
        private Button closeButton;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Tiferix.DotCoolGrid.DotCoolGridView dgvTable;
        private Tikshuv.FrontEnd.StorageWindow.StorageManager.RoundedPanel UpperPanel;
        private Tikshuv.FrontEnd.StorageWindow.StorageManager.RoundedPanel LowerPanel;
        private DataGridViewTextBoxColumn MissionName;
        private DataGridViewTextBoxColumn missionId;
        private DataGridViewCheckBoxColumn isSigned;
        private DataGridViewButtonColumn viewSign;
    }
}