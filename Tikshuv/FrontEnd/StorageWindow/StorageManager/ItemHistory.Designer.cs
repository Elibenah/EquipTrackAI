using System.Windows.Forms;

namespace Tikshuv.FrontEnd.StorageWindow.StorageManager
{
    partial class ItemHistory
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            topPanel = new Panel();
            panel3 = new Panel();
            missionHistorySelectionComboBox = new ComboBox();
            DepositDataView = new DataGridView();
            panel4 = new Panel();
            panel2 = new Panel();
            missionHistoryGridView = new Tiferix.DotCoolGrid.DotCoolGridView();
            typeColumn = new DataGridViewTextBoxColumn();
            serialNumberColumn = new DataGridViewTextBoxColumn();
            timeAdded = new DataGridViewTextBoxColumn();
            UpperPanel = new RoundedPanel();
            LowerPanel = new RoundedPanel();
            missionIdTextBox = new TextBox();
            timeAddedTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            topPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DepositDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)missionHistoryGridView).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(panel3);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(3, 4, 3, 4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(914, 67);
            topPanel.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(25, 30, 60);
            panel3.Controls.Add(missionHistorySelectionComboBox);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(914, 67);
            panel3.TabIndex = 28;
            // 
            // missionHistorySelectionComboBox
            // 
            missionHistorySelectionComboBox.FormattingEnabled = true;
            missionHistorySelectionComboBox.Location = new Point(233, 21);
            missionHistorySelectionComboBox.Name = "missionHistorySelectionComboBox";
            missionHistorySelectionComboBox.Size = new Size(450, 28);
            missionHistorySelectionComboBox.TabIndex = 9;
            missionHistorySelectionComboBox.SelectedIndexChanged += selectionComboBox_SelectedIndexChanged;
            // 
            // DepositDataView
            // 
            DepositDataView.AllowUserToAddRows = false;
            DepositDataView.AllowUserToDeleteRows = false;
            DepositDataView.AllowUserToResizeColumns = false;
            DepositDataView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(23, 21, 35);
            DepositDataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            DepositDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DepositDataView.BackgroundColor = Color.FromArgb(25, 30, 60);
            DepositDataView.BorderStyle = BorderStyle.None;
            DepositDataView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DepositDataView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(27, 51, 88);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(27, 51, 88);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DepositDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DepositDataView.ColumnHeadersHeight = 30;
            DepositDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(25, 30, 60);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(47, 43, 63);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            DepositDataView.DefaultCellStyle = dataGridViewCellStyle9;
            DepositDataView.Dock = DockStyle.Fill;
            DepositDataView.EnableHeadersVisualStyles = false;
            DepositDataView.Location = new Point(34, 67);
            DepositDataView.Margin = new Padding(3, 4, 3, 4);
            DepositDataView.Name = "DepositDataView";
            DepositDataView.ReadOnly = true;
            DepositDataView.RowHeadersVisible = false;
            DepositDataView.RowHeadersWidth = 40;
            DepositDataView.RowTemplate.Height = 50;
            DepositDataView.ScrollBars = ScrollBars.Vertical;
            DepositDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DepositDataView.Size = new Size(846, 533);
            DepositDataView.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(25, 30, 60);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(880, 67);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(34, 533);
            panel4.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(25, 30, 60);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 67);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(34, 533);
            panel2.TabIndex = 30;
            // 
            // missionHistoryGridView
            // 
            missionHistoryGridView.AllowUserToAddRows = false;
            missionHistoryGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = Color.PowderBlue;
            dataGridViewCellStyle10.Font = new Font("David", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.ActiveCaption;
            missionHistoryGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            missionHistoryGridView.BackGradientOffset = new Point(0, 0);
            missionHistoryGridView.BackgroundColor = Color.White;
            missionHistoryGridView.BackgroundGradientColor1 = SystemColors.Control;
            missionHistoryGridView.BackgroundGradientColor2 = SystemColors.Control;
            missionHistoryGridView.BackgroundImageAlign = ContentAlignment.BottomRight;
            missionHistoryGridView.BackgroundImageOffset = new Point(0, 0);
            missionHistoryGridView.BackgroundImageSizeMode = Tiferix.Global.CoolImageSizeMode.Normal;
            missionHistoryGridView.BackgroundImageTransColor = Color.Transparent;
            missionHistoryGridView.BackgroundImageTransparent = false;
            missionHistoryGridView.BorderStyle = BorderStyle.None;
            missionHistoryGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            missionHistoryGridView.CellTransAlpha = 0;
            missionHistoryGridView.CellTransColor = SystemColors.Control;
            missionHistoryGridView.ColHeaderGradientBorderColor = Color.Black;
            missionHistoryGridView.ColHeaderGradientColor1 = SystemColors.Control;
            missionHistoryGridView.ColHeaderGradientColor2 = SystemColors.Control;
            missionHistoryGridView.ColHeaderGradientOffset = new Point(0, 0);
            missionHistoryGridView.ColHeadersFont = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            missionHistoryGridView.ColHeaderTransAlpha = 0;
            missionHistoryGridView.ColHeaderTransColor = SystemColors.Control;
            missionHistoryGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.BlueViolet;
            dataGridViewCellStyle11.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.Window;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            missionHistoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            missionHistoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            missionHistoryGridView.Columns.AddRange(new DataGridViewColumn[] { typeColumn, serialNumberColumn, timeAdded });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("David", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            missionHistoryGridView.DefaultCellStyle = dataGridViewCellStyle12;
            missionHistoryGridView.EnableHeadersVisualStyles = false;
            missionHistoryGridView.GridColor = Color.White;
            missionHistoryGridView.Location = new Point(34, 175);
            missionHistoryGridView.Name = "missionHistoryGridView";
            missionHistoryGridView.ReadOnly = true;
            missionHistoryGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            missionHistoryGridView.RowHeadersVisible = false;
            missionHistoryGridView.RowHeadersWidth = 51;
            missionHistoryGridView.RowTemplate.Height = 29;
            missionHistoryGridView.SelectedCellTransAlpha = 0;
            missionHistoryGridView.SelectedCellTransColor = SystemColors.Control;
            missionHistoryGridView.Size = new Size(846, 375);
            missionHistoryGridView.TabIndex = 40;
            // 
            // typeColumn
            // 
            typeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            typeColumn.HeaderText = "סוג פריט";
            typeColumn.MinimumWidth = 6;
            typeColumn.Name = "typeColumn";
            typeColumn.ReadOnly = true;
            typeColumn.Width = 101;
            // 
            // serialNumberColumn
            // 
            serialNumberColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            serialNumberColumn.HeaderText = "מספר סידורי";
            serialNumberColumn.MinimumWidth = 6;
            serialNumberColumn.Name = "serialNumberColumn";
            serialNumberColumn.ReadOnly = true;
            serialNumberColumn.Width = 130;
            // 
            // timeAdded
            // 
            timeAdded.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            timeAdded.HeaderText = "נוסף ב";
            timeAdded.MinimumWidth = 6;
            timeAdded.Name = "timeAdded";
            timeAdded.ReadOnly = true;
            timeAdded.Width = 82;
            // 
            // UpperPanel
            // 
            UpperPanel.BackColor = Color.BlueViolet;
            UpperPanel.CornerRadius = 10;
            UpperPanel.Location = new Point(34, 155);
            UpperPanel.Name = "UpperPanel";
            UpperPanel.Size = new Size(846, 120);
            UpperPanel.TabIndex = 41;
            // 
            // LowerPanel
            // 
            LowerPanel.BackColor = Color.White;
            LowerPanel.CornerRadius = 10;
            LowerPanel.Location = new Point(34, 389);
            LowerPanel.Name = "LowerPanel";
            LowerPanel.Size = new Size(846, 181);
            LowerPanel.TabIndex = 42;
            // 
            // missionIdTextBox
            // 
            missionIdTextBox.Location = new Point(318, 74);
            missionIdTextBox.Name = "missionIdTextBox";
            missionIdTextBox.Size = new Size(267, 27);
            missionIdTextBox.TabIndex = 10;
            // 
            // timeAddedTextBox
            // 
            timeAddedTextBox.Location = new Point(318, 107);
            timeAddedTextBox.Name = "timeAddedTextBox";
            timeAddedTextBox.Size = new Size(267, 27);
            timeAddedTextBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(25, 30, 60);
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(613, 74);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(108, 29);
            label1.TabIndex = 10;
            label1.Text = "מספר ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(25, 30, 60);
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(634, 107);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(87, 29);
            label2.TabIndex = 11;
            label2.Text = "נוסף ב:";
            // 
            // ItemHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(timeAddedTextBox);
            Controls.Add(missionIdTextBox);
            Controls.Add(missionHistoryGridView);
            Controls.Add(UpperPanel);
            Controls.Add(LowerPanel);
            Controls.Add(DepositDataView);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ItemHistory";
            Text = "Equipment Finder";
            topPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DepositDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)missionHistoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Tiferix.DotCoolGrid.DotCoolGridView missionHistoryGridView;
        private RoundedPanel UpperPanel;
        private RoundedPanel LowerPanel;
        private ComboBox missionHistorySelectionComboBox;
        private DataGridViewTextBoxColumn typeColumn;
        private DataGridViewTextBoxColumn serialNumberColumn;
        private DataGridViewTextBoxColumn timeAdded;
        private TextBox missionIdTextBox;
        private TextBox timeAddedTextBox;
        private Label label1;
        private Label label2;
    }
}
