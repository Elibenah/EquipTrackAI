using System.Windows.Forms;

namespace Tikshuv.FrontEnd.StorageWindow.StorageManager
{
    partial class EquipmentFinder
    {
        private Panel topPanel;


        private System.ComponentModel.IContainer components = null;

   
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

 
        private void InitializeComponent()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentFinder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchByMIssion = new System.Windows.Forms.Button();
            this.selectionComboBox = new System.Windows.Forms.ComboBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DepositDataView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTable = new Tiferix.DotCoolGrid.DotCoolGridView();
            this.UpperPanel = new Tikshuv.FrontEnd.StorageWindow.StorageManager.RoundedPanel();
            this.LowerPanel = new Tikshuv.FrontEnd.StorageWindow.StorageManager.RoundedPanel();
            this.topPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepositDataView)).BeginInit();
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
            this.panel3.Controls.Add(this.searchByMIssion);
            this.panel3.Controls.Add(this.selectionComboBox);
            this.panel3.Controls.Add(this.Savebtn);
            this.panel3.Controls.Add(this.SearchButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(914, 67);
            this.panel3.TabIndex = 28;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // searchByMIssion
            // 
            this.searchByMIssion.BackgroundImage = global::Tikshuv.Properties.Resources.warehouse;
            this.searchByMIssion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchByMIssion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchByMIssion.Location = new System.Drawing.Point(776, 7);
            this.searchByMIssion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchByMIssion.Name = "searchByMIssion";
            this.searchByMIssion.Size = new System.Drawing.Size(52, 52);
            this.searchByMIssion.TabIndex = 10;
            this.searchByMIssion.UseVisualStyleBackColor = true;
            this.searchByMIssion.Click += searchByMission_Click;
            // 
            // selectionComboBox
            // 
            this.selectionComboBox.FormattingEnabled = true;
            this.selectionComboBox.Location = new System.Drawing.Point(233, 21);
            this.selectionComboBox.Name = "selectionComboBox";
            this.selectionComboBox.Size = new System.Drawing.Size(450, 28);
            this.selectionComboBox.TabIndex = 9;
            this.selectionComboBox.SelectedIndexChanged += new System.EventHandler(this.selectionComboBox_SelectedIndexChanged);
            // 
            // Savebtn
            // 
            this.Savebtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Savebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Savebtn.Location = new System.Drawing.Point(120, 7);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(86, 56);
            this.Savebtn.TabIndex = 3;
            this.Savebtn.Text = "מחק";
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(707, 7);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(52, 52);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += searchByItems_Click;
            // 
            // DepositDataView
            // 
            this.DepositDataView.AllowUserToAddRows = false;
            this.DepositDataView.AllowUserToDeleteRows = false;
            this.DepositDataView.AllowUserToResizeColumns = false;
            this.DepositDataView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.DepositDataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DepositDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DepositDataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.DepositDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DepositDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DepositDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(51)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DepositDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DepositDataView.ColumnHeadersHeight = 30;
            this.DepositDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DepositDataView.DefaultCellStyle = dataGridViewCellStyle9;
            this.DepositDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepositDataView.EnableHeadersVisualStyles = false;
            this.DepositDataView.Location = new System.Drawing.Point(34, 67);
            this.DepositDataView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepositDataView.Name = "DepositDataView";
            this.DepositDataView.ReadOnly = true;
            this.DepositDataView.RowHeadersVisible = false;
            this.DepositDataView.RowHeadersWidth = 40;
            this.DepositDataView.RowTemplate.Height = 50;
            this.DepositDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DepositDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepositDataView.Size = new System.Drawing.Size(846, 533);
            this.DepositDataView.TabIndex = 32;
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
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
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
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.DefaultCellStyle = dataGridViewCellStyle12;
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
            this.dgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // EquipmentFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.UpperPanel);
            this.Controls.Add(this.LowerPanel);
            this.Controls.Add(this.DepositDataView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EquipmentFinder";
            this.Text = "Equipment Finder";
            this.topPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DepositDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Implement search logic 
        }

        private Panel titleBar;
        private Button closeButton;
        private DataGridView DepositDataView;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Button Savebtn;
        private Button SearchButton;
        private Tiferix.DotCoolGrid.DotCoolGridView dgvTable;
        private RoundedPanel UpperPanel;
        private RoundedPanel LowerPanel;
        private ComboBox selectionComboBox;
        private Button searchByMIssion;
    }
}
