using System.Drawing.Drawing2D;
using Tikshuv.FrontEnd.StorageWindow.StorageManager;
namespace Tikshuv.SubForms
{
    partial class Solider
    {
       
 

        private System.ComponentModel.IContainer components = null;
        

        // Clean up any resources being used.
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

 
       
       
  
        private void InitializeComponent()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solider));
            this.dgvTable = new Tiferix.DotCoolGrid.DotCoolGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewSolider = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReservePersonnel = new System.Windows.Forms.Button();
            this.RegulatoryPersonnel = new System.Windows.Forms.Button();
            this.MendetorButton = new System.Windows.Forms.Button();
            this.OutsidersPersonnel = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.UpperPanel = new Tikshuv.FrontEnd.StorageWindow.StorageManager.RoundedPanel();
            this.LowerPanel = new Tikshuv.FrontEnd.StorageWindow.StorageManager.RoundedPanel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SearchBar.Enter += new System.EventHandler(this.SearchBar_Enter);
            this.SearchBar.Leave += new System.EventHandler(this.SearchBar_Leave);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
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
            this.ID,
            this.Name,
            this.FamilyName,
            this.PhoneNumber,
            this.DateOfBirth,
            this.Premision});
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
            this.dgvTable.Location = new System.Drawing.Point(29, 132);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 29;
            this.dgvTable.SelectedCellTransAlpha = 0;
            this.dgvTable.SelectedCellTransColor = System.Drawing.SystemColors.Control;
            this.dgvTable.Size = new System.Drawing.Size(856, 362);
            this.dgvTable.TabIndex = 27;
            this.dgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellClick);
            this.dgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellValueChanged);
            this.dgvTable.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dgvTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.NewSolider);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.SearchBar);
            this.panel1.Controls.Add(this.searchbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 89);
            this.panel1.TabIndex = 28;
            // 
            // NewSolider
            // 
            this.NewSolider.Click += new System.EventHandler(this.NewSolider_Click);
            this.NewSolider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewSolider.BackgroundImage")));
            this.NewSolider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewSolider.FlatAppearance.BorderSize = 0;
            this.NewSolider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewSolider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewSolider.Location = new System.Drawing.Point(286, 29);
            this.NewSolider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewSolider.Name = "NewSolider";
            this.NewSolider.Size = new System.Drawing.Size(34, 33);
            this.NewSolider.TabIndex = 7;
            this.NewSolider.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.ReservePersonnel);
            this.panel2.Controls.Add(this.RegulatoryPersonnel);
            this.panel2.Controls.Add(this.MendetorButton);
            this.panel2.Controls.Add(this.OutsidersPersonnel);
            this.panel2.Location = new System.Drawing.Point(646, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 33);
            this.panel2.TabIndex = 6;
            // 
            // ReservePersonnel
            // 
            this.ReservePersonnel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReservePersonnel.FlatAppearance.BorderSize = 0;
            this.ReservePersonnel.Font = new System.Drawing.Font("Monotype Corsiva", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ReservePersonnel.Location = new System.Drawing.Point(166, 0);
            this.ReservePersonnel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReservePersonnel.Name = "ReservePersonnel";
            this.ReservePersonnel.Size = new System.Drawing.Size(62, 33);
            this.ReservePersonnel.TabIndex = 0;
            this.ReservePersonnel.Text = "מילואים";
            this.ReservePersonnel.UseVisualStyleBackColor = true;
            this.ReservePersonnel.Click += ReservePersonnel_Click;
            // 
            // RegulatoryPersonnel
            // 
            this.RegulatoryPersonnel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RegulatoryPersonnel.FlatAppearance.BorderSize = 0;
            this.RegulatoryPersonnel.Font = new System.Drawing.Font("Monotype Corsiva", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.RegulatoryPersonnel.Location = new System.Drawing.Point(120, 0);
            this.RegulatoryPersonnel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegulatoryPersonnel.Name = "RegulatoryPersonnel";
            this.RegulatoryPersonnel.Size = new System.Drawing.Size(46, 33);
            this.RegulatoryPersonnel.TabIndex = 1;
            this.RegulatoryPersonnel.Text = "קבע";
            this.RegulatoryPersonnel.UseVisualStyleBackColor = true;
            this.RegulatoryPersonnel.Click += RegulatoryPersonnel_Click;
            // 
            // MendetorButton
            // 
            this.MendetorButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MendetorButton.FlatAppearance.BorderSize = 0;
            this.MendetorButton.Font = new System.Drawing.Font("Monotype Corsiva", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.MendetorButton.Location = new System.Drawing.Point(69, 0);
            this.MendetorButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MendetorButton.Name = "MendetorButton";
            this.MendetorButton.Size = new System.Drawing.Size(51, 33);
            this.MendetorButton.TabIndex = 2;
            this.MendetorButton.Text = "סדיר";
            this.MendetorButton.UseVisualStyleBackColor = true;
            this.MendetorButton.Click += MendetorButton_Click;
            // 
            // OutsidersPersonnel
            // 
            this.OutsidersPersonnel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OutsidersPersonnel.FlatAppearance.BorderSize = 0;
            this.OutsidersPersonnel.Font = new System.Drawing.Font("Monotype Corsiva", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.OutsidersPersonnel.Location = new System.Drawing.Point(0, 0);
            this.OutsidersPersonnel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutsidersPersonnel.Name = "OutsidersPersonnel";
            this.OutsidersPersonnel.Size = new System.Drawing.Size(69, 33);
            this.OutsidersPersonnel.TabIndex = 3;
            this.OutsidersPersonnel.Text = "אנשי חוץ";
            this.OutsidersPersonnel.UseVisualStyleBackColor = true;
            this.OutsidersPersonnel.Click += OutsidersPersonnel_Click;
            // 
            // SearchBar
            // 
            this.SearchBar.AutoCompleteCustomSource.AddRange(new string[] {
            "MAX,KHMELNITSKY,"});
            this.SearchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBar.Location = new System.Drawing.Point(14, 33);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(225, 23);
            this.SearchBar.TabIndex = 5;
            this.SearchBar.Text = "חיפוש";
            this.SearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // searchbutton
            // 
            this.searchbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchbutton.BackgroundImage")));
            this.searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchbutton.FlatAppearance.BorderSize = 0;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchbutton.Location = new System.Drawing.Point(245, 29);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(34, 33);
            this.searchbutton.TabIndex = 4;
            this.searchbutton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LeftPanel);
            this.panel3.Controls.Add(this.RightPanel);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 89);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(914, 462);
            this.panel3.TabIndex = 29;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(23, 413);
            this.LeftPanel.TabIndex = 30;
            // 
            // RightPanel
            // 
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(891, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(23, 413);
            this.RightPanel.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 413);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(914, 49);
            this.panel4.TabIndex = 28;
            // 
            // sidePanel
            // 
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel.Location = new System.Drawing.Point(914, 89);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(0, 462);
            this.sidePanel.Visible = true;
            this.sidePanel.TabIndex = 28;
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 10;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.UpperPanel.CornerRadius = 10;
            this.UpperPanel.Location = new System.Drawing.Point(29, 87);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(857, 181);
            this.UpperPanel.TabIndex = 41;
            // 
            // LowerPanel
            // 
            this.LowerPanel.BackColor = System.Drawing.Color.White;
            this.LowerPanel.CornerRadius = 10;
            this.LowerPanel.Location = new System.Drawing.Point(29, 321);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(857, 181);
            this.LowerPanel.TabIndex = 42;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "מספר אישי";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 118;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Name.HeaderText = "שם פרטי";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // FamilyName
            // 
            this.FamilyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FamilyName.HeaderText = "שם משפחה";
            this.FamilyName.MinimumWidth = 6;
            this.FamilyName.Name = "FamilyName";
            this.FamilyName.Width = 119;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneNumber.HeaderText = "מספר טלפון";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 124;

            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DateOfBirth.HeaderText = "תאריך לידה";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Width = 123;
            // 
            // Premision
            // 
            this.Premision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Premision.HeaderText = "רמת הרשאה";
            this.Premision.MinimumWidth = 6;
            this.Premision.Name = "Premision";
            this.Premision.Width = 128;
            // 
            // Solider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(914, 551);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.UpperPanel);
            this.Controls.Add(this.LowerPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text = "Solider";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void MendetorButton_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }







        #endregion

        private Tiferix.DotCoolGrid.DotCoolGridView dgvTable;
        private RoundedPanel UpperPanel;
        private RoundedPanel LowerPanel;
        private Panel titleBar;
        private Button closeButton;
        private Panel panel1;
        private Button ReservePersonnel;
        private Button searchbutton;
        private Button OutsidersPersonnel;
        private Button MendetorButton;
        private Button RegulatoryPersonnel;
        private TextBox SearchBar;
        private Panel panel2;
        private Panel panel3;
        private Button NewSolider;
        private Panel panel4;
        private Panel LeftPanel;
        private Panel RightPanel;
        private Panel sidePanel;
        private System.Windows.Forms.Timer animationTimer;
        private Form activeForm = null;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn FamilyName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Premision;
    }
}