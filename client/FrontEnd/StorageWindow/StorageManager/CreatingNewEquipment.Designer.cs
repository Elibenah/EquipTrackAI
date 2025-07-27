using DotCoolControls;
using HandyControl.Controls;
using Tiferix.DotCoolGrid;

namespace Tikshuv.FrontEnd.StorageWindow.StorageManager
{
    partial class CreateNewEquipment
    {

        private void InitializeComponent()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpperPanel = new Tikshuv.FrontEnd.StorageWindow.StorageManager.RoundedPanel();
            this.LowerPanel = new Tikshuv.FrontEnd.StorageWindow.StorageManager.RoundedPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.addAddons = new System.Windows.Forms.Button(); 
            this.VariableType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VariableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTable = new Tiferix.DotCoolGrid.DotCoolGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(34, 600);
            this.LeftPanel.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(880, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(34, 600);
            this.panel4.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(130, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 296);
            this.panel1.TabIndex = 40;
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.UpperPanel.CornerRadius = 10;
            this.UpperPanel.Location = new System.Drawing.Point(130, 215);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(580, 40);
            this.UpperPanel.TabIndex = 38;
            // 
            // LowerPanel
            // 
            this.LowerPanel.BackColor = System.Drawing.Color.White;
            this.LowerPanel.CornerRadius = 10;
            this.LowerPanel.Location = new System.Drawing.Point(130, 520);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(580, 30);
            this.LowerPanel.TabIndex = 39;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(250, 600);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 34);
            this.addButton.TabIndex = 43;
            this.addButton.Text = "הוסף";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addAddons

            // 
            this.addAddons.Location = new System.Drawing.Point(450, 600);
            this.addAddons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addAddons.Name = "addAddons";
            this.addAddons.Size = new System.Drawing.Size(100, 34);
            this.addAddons.TabIndex = 44;
            this.addAddons.Text = "תוספות";
            this.addAddons.UseVisualStyleBackColor = true;
            this.addAddons.Click += new System.EventHandler(this.addAddons_Click);
            // 
            // VariableType
            // 
            this.VariableType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VariableType.DefaultCellStyle = dataGridViewCellStyle1;
            this.VariableType.HeaderText = "סוג משתנה";
            this.VariableType.Items.AddRange(new object[] {"טקסט חופשי","תוספות"});
            this.VariableType.MinimumWidth = 6;
            this.VariableType.Name = "VariableType";
            // 
            // VariableName
            // 
            this.VariableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VariableName.DefaultCellStyle = dataGridViewCellStyle2;
            this.VariableName.HeaderText = "שם משתנה";
            this.VariableName.MinimumWidth = 6;
            this.VariableName.Name = "VariableName";
            // 
            // dgvTable
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VariableName,
            this.VariableType});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTable.EnableHeadersVisualStyles = false;
            this.dgvTable.GridColor = System.Drawing.Color.White;
            this.dgvTable.Location = new System.Drawing.Point(130, 230);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 29;
            this.dgvTable.SelectedCellTransAlpha = 0;
            this.dgvTable.SelectedCellTransColor = System.Drawing.SystemColors.Control;
            this.dgvTable.Size = new System.Drawing.Size(580, 300);
            this.dgvTable.TabIndex = 35;
            this.dgvTable.EditingControlShowing += dgvTable_EditingControlShowing;

            this.dgvTable.CellContentClick += DgvTable_CellContentClick;
            this.dgvTable.CellEnter += dgvTable_CellEnter;
            this.dgvTable.RowsAdded += dgvTable_RowsAdded;
            this.dgvTable.RowsRemoved += dgvTable_RowsRemoved;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("David", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(154, 88);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 43);
            this.txtName.TabIndex = 41;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("David", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(440, 84);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lblName.Size = new System.Drawing.Size(188, 47);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "שם פריט";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateNewEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add( this.addAddons);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.UpperPanel);
            this.Controls.Add(this.LowerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateNewEquipment";
            this.Text = "Add New Equipment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Panel titleBar;
        private Button closeButton;
        private Panel LeftPanel;
        private Panel panel4;
        private RoundedPanel UpperPanel;
        private RoundedPanel LowerPanel;
        private Panel panel1;
        private Button addButton;
        private Button addAddons;
        private DataGridViewComboBoxColumn VariableType;
        private DataGridViewTextBoxColumn VariableName;
        private DotCoolGridView dgvTable;
        private System.Windows.Forms.TextBox txtName;
        private Label lblName;
        // DotCoolGridView dgv = new DotCoolGridView();
    }
}
