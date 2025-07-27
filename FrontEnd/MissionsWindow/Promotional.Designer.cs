namespace Tikshuv.SubForms
{
    partial class Promotional
    {
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
            this.missionGridView = new Tiferix.DotCoolGrid.DotCoolGridView();
            this.itemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditItems = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Addons = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DownPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.missionName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.Button();
            this.UpperPanel = new Tikshuv.FrontEnd.StorageWindow.StorageManager.RoundedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.missionGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // missionGridView
            // 
            this.missionGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.missionGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.missionGridView.BackGradientOffset = new System.Drawing.Point(0, 0);
            this.missionGridView.BackgroundColor = System.Drawing.Color.White;
            this.missionGridView.BackgroundGradientColor1 = System.Drawing.SystemColors.Control;
            this.missionGridView.BackgroundGradientColor2 = System.Drawing.SystemColors.Control;
            this.missionGridView.BackgroundImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.missionGridView.BackgroundImageOffset = new System.Drawing.Point(0, 0);
            this.missionGridView.BackgroundImageSizeMode = Tiferix.Global.CoolImageSizeMode.Normal;
            this.missionGridView.BackgroundImageTransColor = System.Drawing.Color.Transparent;
            this.missionGridView.BackgroundImageTransparent = false;
            this.missionGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.missionGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.missionGridView.CellTransAlpha = 0;
            this.missionGridView.CellTransColor = System.Drawing.SystemColors.Control;
            this.missionGridView.ColHeaderGradientBorderColor = System.Drawing.Color.Black;
            this.missionGridView.ColHeaderGradientColor1 = System.Drawing.SystemColors.Control;
            this.missionGridView.ColHeaderGradientColor2 = System.Drawing.SystemColors.Control;
            this.missionGridView.ColHeaderGradientOffset = new System.Drawing.Point(0, 0);
            this.missionGridView.ColHeadersFont = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.missionGridView.ColHeaderTransAlpha = 0;
            this.missionGridView.ColHeaderTransColor = System.Drawing.SystemColors.Control;
            this.missionGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.missionGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.missionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.missionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemColumn,
            this.serialColumn,
            this.creditItems,
            this.Addons});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.missionGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.missionGridView.EnableHeadersVisualStyles = false;
            this.missionGridView.GridColor = System.Drawing.Color.White;
            this.missionGridView.Location = new System.Drawing.Point(159, 129);
            this.missionGridView.Name = "missionGridView";
            this.missionGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.missionGridView.RowHeadersWidth = 51;
            this.missionGridView.RowTemplate.Height = 29;
            this.missionGridView.SelectedCellTransAlpha = 0;
            this.missionGridView.SelectedCellTransColor = System.Drawing.SystemColors.Control;
            this.missionGridView.Size = new System.Drawing.Size(580, 270);
            this.missionGridView.TabIndex = 46;
            // 
            // itemColumn
            // 
            this.itemColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemColumn.HeaderText = "סוג פריט";
            this.itemColumn.MinimumWidth = 6;
            this.itemColumn.Name = "itemColumn";
            this.itemColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // serialColumn
            // 
            this.serialColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serialColumn.HeaderText = "מס\"ד";
            this.serialColumn.MinimumWidth = 100;
            this.serialColumn.Name = "serialColumn";
            this.serialColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.serialColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // creditItems
            // 
            this.creditItems.HeaderText = "זיכוי";
            this.creditItems.MinimumWidth = 6;
            this.creditItems.Name = "creditItems";
            this.creditItems.Width = 50;
            // 
            // Addons
            // 
            this.Addons.HeaderText = "תוספות";
            this.Addons.MinimumWidth = 6;
            this.Addons.Name = "Addons";
            this.Addons.Text = "תוספות";
            this.Addons.UseColumnTextForButtonValue = true;
            this.Addons.Width = 125;
            // 
            // DownPanel
            // 
            this.DownPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownPanel.Location = new System.Drawing.Point(23, 524);
            this.DownPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DownPanel.Name = "DownPanel";
            this.DownPanel.Size = new System.Drawing.Size(868, 27);
            this.DownPanel.TabIndex = 30;
            // 
            // RightPanel
            // 
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(891, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(23, 551);
            this.RightPanel.TabIndex = 31;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(23, 551);
            this.LeftPanel.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.missionName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.credit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(23, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 67);
            this.panel1.TabIndex = 32;
            // 
            // missionName
            // 
            this.missionName.Font = new System.Drawing.Font("David", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.missionName.Location = new System.Drawing.Point(222, 11);
            this.missionName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.missionName.Name = "missionName";
            this.missionName.Size = new System.Drawing.Size(450, 43);
            this.missionName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(746, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 58);
            this.label2.TabIndex = 10;
            this.label2.Text = "זיכוי";
            // 
            // credit
            // 
            this.credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.credit.Location = new System.Drawing.Point(37, 8);
            this.credit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(122, 53);
            this.credit.TabIndex = 8;
            this.credit.Text = "זכה";
            this.credit.UseVisualStyleBackColor = true;
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.UpperPanel.CornerRadius = 10;
            this.UpperPanel.Location = new System.Drawing.Point(159, 117);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(580, 40);
            this.UpperPanel.TabIndex = 47;
            // 
            // Promotional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(914, 551);
            this.Controls.Add(this.missionGridView);
            this.Controls.Add(this.UpperPanel);
            this.Controls.Add(this.DownPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Promotional";
            this.Text = "Promotional";
            ((System.ComponentModel.ISupportInitialize)(this.missionGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel titleBar;
        private Button closeButton;
        private Panel DownPanel;
        private Panel RightPanel;
        private Panel LeftPanel;
        private Panel panel1;
        private Button credit;
        private Label label2;
        private ComboBox missionName;
        private Tiferix.DotCoolGrid.DotCoolGridView missionGridView;
        private FrontEnd.StorageWindow.StorageManager.RoundedPanel UpperPanel;
        private DataGridViewTextBoxColumn itemColumn;
        private DataGridViewTextBoxColumn serialColumn;
        private DataGridViewCheckBoxColumn creditItems;
        private DataGridViewButtonColumn Addons;
    }
}