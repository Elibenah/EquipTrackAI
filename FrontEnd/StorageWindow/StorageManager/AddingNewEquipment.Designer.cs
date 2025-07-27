using Tiferix.DotCoolGrid;

namespace Tikshuv.FrontEnd.StorageWindow.StorageManager
{
    partial class AddingNewEquipment
    {

        private void InitializeComponent()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            LeftPanel = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            UpperPanel = new RoundedPanel();
            LowerPanel = new RoundedPanel();
            addButton = new Button();
            dgvTable = new DotCoolGridView();
            label1 = new Label();
            catalogNumberBox = new TextBox();
            label2 = new Label();
            serialNumberBox = new TextBox();
            equipmentItemBox = new ComboBox();
            VariableName = new DataGridViewTextBoxColumn();
            VariableType = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Margin = new Padding(3, 4, 3, 4);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(34, 600);
            LeftPanel.TabIndex = 33;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(880, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(34, 600);
            panel4.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(130, 241);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 296);
            panel1.TabIndex = 40;
            // 
            // UpperPanel
            // 
            UpperPanel.BackColor = Color.BlueViolet;
            UpperPanel.CornerRadius = 10;
            UpperPanel.Location = new Point(130, 215);
            UpperPanel.Name = "UpperPanel";
            UpperPanel.Size = new Size(580, 40);
            UpperPanel.TabIndex = 38;
            // 
            // LowerPanel
            // 
            LowerPanel.BackColor = Color.White;
            LowerPanel.CornerRadius = 10;
            LowerPanel.Location = new Point(130, 520);
            LowerPanel.Name = "LowerPanel";
            LowerPanel.Size = new Size(580, 30);
            LowerPanel.TabIndex = 39;
            // 
            // addButton
            // 
            addButton.Location = new Point(355, 553);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(114, 34);
            addButton.TabIndex = 43;
            addButton.Text = "הוסף";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // dgvTable
            // 
            dataGridViewCellStyle1.BackColor = Color.PowderBlue;
            dataGridViewCellStyle1.Font = new Font("David", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTable.BackGradientOffset = new Point(0, 0);
            dgvTable.BackgroundColor = Color.White;
            dgvTable.BackgroundGradientColor1 = SystemColors.Control;
            dgvTable.BackgroundGradientColor2 = SystemColors.Control;
            dgvTable.BackgroundImageAlign = ContentAlignment.BottomRight;
            dgvTable.BackgroundImageOffset = new Point(0, 0);
            dgvTable.BackgroundImageSizeMode = Tiferix.Global.CoolImageSizeMode.Normal;
            dgvTable.BackgroundImageTransColor = Color.Transparent;
            dgvTable.BackgroundImageTransparent = false;
            dgvTable.BorderStyle = BorderStyle.None;
            dgvTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTable.CellTransAlpha = 0;
            dgvTable.CellTransColor = SystemColors.Control;
            dgvTable.ColHeaderGradientBorderColor = Color.Black;
            dgvTable.ColHeaderGradientColor1 = SystemColors.Control;
            dgvTable.ColHeaderGradientColor2 = SystemColors.Control;
            dgvTable.ColHeaderGradientOffset = new Point(0, 0);
            dgvTable.ColHeadersFont = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvTable.ColHeaderTransAlpha = 0;
            dgvTable.ColHeaderTransColor = SystemColors.Control;
            dgvTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.BlueViolet;
            dataGridViewCellStyle2.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Columns.AddRange(new DataGridViewColumn[] { VariableName, VariableType });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("David", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvTable.DefaultCellStyle = dataGridViewCellStyle5;
            dgvTable.EnableHeadersVisualStyles = false;
            dgvTable.GridColor = Color.White;
            dgvTable.Location = new Point(130, 230);
            dgvTable.Name = "dgvTable";
            dgvTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTable.RowHeadersVisible = false;
            dgvTable.RowHeadersWidth = 51;
            dgvTable.RowTemplate.Height = 29;
            dgvTable.SelectedCellTransAlpha = 0;
            dgvTable.SelectedCellTransColor = SystemColors.Control;
            dgvTable.Size = new Size(580, 300);
            dgvTable.TabIndex = 35;
            // 
            // label1
            // 
            label1.Font = new Font("David", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(479, 78);
            label1.Name = "label1";
            label1.Padding = new Padding(6, 7, 6, 7);
            label1.Size = new Size(188, 47);
            label1.TabIndex = 45;
            label1.Text = "מק\"ט";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // catalogNumberBox
            // 
            catalogNumberBox.Font = new Font("David", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            catalogNumberBox.Location = new Point(193, 82);
            catalogNumberBox.Margin = new Padding(3, 4, 3, 4);
            catalogNumberBox.Name = "catalogNumberBox";
            catalogNumberBox.Size = new Size(261, 43);
            catalogNumberBox.TabIndex = 44;
            // 
            // label2
            // 
            label2.Font = new Font("David", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(479, 138);
            label2.Name = "label2";
            label2.Padding = new Padding(6, 7, 6, 7);
            label2.Size = new Size(188, 47);
            label2.TabIndex = 47;
            label2.Text = "מס\"ד";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // serialNumberBox
            // 
            serialNumberBox.Font = new Font("David", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            serialNumberBox.Location = new Point(193, 142);
            serialNumberBox.Margin = new Padding(3, 4, 3, 4);
            serialNumberBox.Name = "serialNumberBox";
            serialNumberBox.Size = new Size(261, 43);
            serialNumberBox.TabIndex = 46;
            // 
            // equipmentItemBox
            // 
            equipmentItemBox.FormattingEnabled = true;
            equipmentItemBox.Location = new Point(226, 24);
            equipmentItemBox.Name = "equipmentItemBox";
            equipmentItemBox.Size = new Size(367, 28);
            equipmentItemBox.TabIndex = 48;
            equipmentItemBox.SelectedIndexChanged += equipmentItemBox_SelectedIndexChanged;
            // 
            // VariableName
            // 
            VariableName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightCyan;
            dataGridViewCellStyle3.Font = new Font("David", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            VariableName.DefaultCellStyle = dataGridViewCellStyle3;
            VariableName.HeaderText = "שם משתנה";
            VariableName.MinimumWidth = 6;
            VariableName.Name = "VariableName";
            // 
            // VariableType
            // 
            VariableType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.LightCyan;
            dataGridViewCellStyle4.Font = new Font("David", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            VariableType.DefaultCellStyle = dataGridViewCellStyle4;
            VariableType.HeaderText = "הגדרה";
            VariableType.MinimumWidth = 6;
            VariableType.Name = "VariableType";
            VariableType.Resizable = DataGridViewTriState.True;
            VariableType.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AddingNewEquipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 30, 60);
            ClientSize = new Size(914, 600);
            Controls.Add(equipmentItemBox);
            Controls.Add(label2);
            Controls.Add(serialNumberBox);
            Controls.Add(label1);
            Controls.Add(catalogNumberBox);
            Controls.Add(addButton);
            Controls.Add(dgvTable);
            Controls.Add(panel1);
            Controls.Add(LeftPanel);
            Controls.Add(panel4);
            Controls.Add(UpperPanel);
            Controls.Add(LowerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddingNewEquipment";
            Text = "Add New Equipment";
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel titleBar;
        private Button closeButton;
        private Panel LeftPanel;
        private Panel panel4;
        private RoundedPanel UpperPanel;
        private RoundedPanel LowerPanel;
        private Panel panel1;
        private Button addButton;
        private DotCoolGridView dgvTable;
        private Label label1;
        private TextBox catalogNumberBox;
        private Label label2;
        private TextBox serialNumberBox;
        private ComboBox equipmentItemBox;
        private DataGridViewTextBoxColumn VariableName;
        private DataGridViewTextBoxColumn VariableType;
    }
}
