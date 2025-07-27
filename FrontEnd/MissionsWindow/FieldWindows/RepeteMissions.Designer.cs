namespace Tikshuv.SubForms
{
    partial class RepeteMissions
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
            this.FormBorderStyle = FormBorderStyle.None;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepeteMissions));
            panel1 = new Panel();
            Mail = new Button();
            Print = new Button();
            Save = new Button();
            dataGridView = new DataGridView();
            IAF_ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            B_ID = new DataGridViewTextBoxColumn();
            addons = new DataGridViewTextBoxColumn();
            state = new DataGridViewTextBoxColumn();
            button5 = new Button();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 30, 60);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(Mail);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(Print);
            panel1.Controls.Add(Save);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 24;
            // 
            // Mail
            // 
            Mail.Location = new Point(124, 5);
            Mail.Name = "Mail";
            Mail.Size = new Size(50, 40);
            Mail.TabIndex = 12;
            Mail.Text = "Mail";
            Mail.UseVisualStyleBackColor = true;
            // 
            // Print
            // 
            Print.Location = new Point(68, 5);
            Print.Name = "Print";
            Print.Size = new Size(50, 40);
            Print.TabIndex = 11;
            Print.Text = "Print";
            Print.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            Save.Location = new Point(12, 5);
            Save.Name = "Save";
            Save.Size = new Size(50, 40);
            Save.TabIndex = 10;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(23, 21, 35);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(25, 30, 60);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 51, 88);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(27, 51, 88);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 30;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { IAF_ID, Name, B_ID, addons, state });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(25, 30, 60);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(47, 43, 63);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Dock = DockStyle.Top;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(0, 50);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 40;
            dataGridView.RowTemplate.Height = 50;
            dataGridView.ScrollBars = ScrollBars.Vertical;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(800, 388);
            dataGridView.TabIndex = 25;
            // 
            // IAF_ID
            // 
            IAF_ID.HeaderText = "מק\"ט";
            IAF_ID.Name = "IAF_ID";
            IAF_ID.ReadOnly = true;
            // 
            // Name
            // 
            Name.HeaderText = "שם";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // B_ID
            // 
            B_ID.HeaderText = "מס\"ד";
            B_ID.Name = "B_ID";
            B_ID.ReadOnly = true;
            // 
            // addons
            // 
            addons.HeaderText = "ציוד נלווה";
            addons.Name = "addons";
            addons.ReadOnly = true;
            // 
            // state
            // 
            state.HeaderText = "סטטוס";
            state.Name = "state";
            state.ReadOnly = true;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(616, 5);
            button5.Name = "button5";
            button5.Size = new Size(40, 39);
            button5.TabIndex = 27;
            button5.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("David", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.Location = new Point(216, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(394, 36);
            txtSearch.TabIndex = 26;
            // 
            // RepeteMissions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 30, 60);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            
            ShowInTaskbar = false;
            Text = "RepeteMissions";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel titleBar;
        private Button closeButton;
        private Panel panel1;
        private Button Mail;
        private Button Print;
        private Button Save;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn IAF_ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn B_ID;
        private DataGridViewTextBoxColumn addons;
        private DataGridViewTextBoxColumn state;
        private Button button5;
        private TextBox txtSearch;
    }
}