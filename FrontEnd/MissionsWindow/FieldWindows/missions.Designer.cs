using System.Windows.Forms;
using Tiferix.DotCoolGrid;
using Tikshuv.FrontEnd.StorageWindow.StorageManager;

namespace Tikshuv.SubForms
{
    partial class missions
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(missions));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            button5 = new Button();
            fixedMissionCheckBox = new CheckBox();
            namingMission = new ComboBox();
            imageList1 = new ImageList(components);
            dataBaseBindingSource = new BindingSource(components);
            DownPanel = new Panel();
            RightPanel = new Panel();
            LeftPanel = new Panel();
            searchResult = new DataGridView();
            MissionNameResult = new DataGridViewTextBoxColumn();
            StartDateResult = new DataGridViewTextBoxColumn();
            missionGridView = new DotCoolGridView();
            itemColumn = new DataGridViewComboBoxColumn();
            serialColumn = new DataGridViewComboBoxColumn();
            buttonColumn = new DataGridViewButtonColumn();
            UpperPanel = new RoundedPanel();
            LowerPanel = new RoundedPanel();
            AddButton = new Button();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBaseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)missionGridView).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(25, 30, 60);
            TopPanel.Controls.Add(button5);
            TopPanel.Controls.Add(fixedMissionCheckBox);
            TopPanel.Controls.Add(namingMission);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(20, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(760, 50);
            TopPanel.TabIndex = 23;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(594, 5);
            button5.Name = "button5";
            button5.Size = new Size(40, 39);
            button5.TabIndex = 29;
            button5.UseVisualStyleBackColor = true;
            // 
            // fixedMissionCheckBox
            // 
            fixedMissionCheckBox.AutoSize = true;
            fixedMissionCheckBox.ForeColor = Color.White;
            fixedMissionCheckBox.Location = new Point(32, 16);
            fixedMissionCheckBox.Name = "fixedMissionCheckBox";
            fixedMissionCheckBox.Size = new Size(98, 19);
            fixedMissionCheckBox.TabIndex = 47;
            fixedMissionCheckBox.Text = "משימה קבועה";
            fixedMissionCheckBox.UseVisualStyleBackColor = true;
            // 
            // namingMission
            // 
            namingMission.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            namingMission.Font = new Font("David", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            namingMission.Location = new Point(194, 8);
            namingMission.Name = "namingMission";
            namingMission.Size = new Size(394, 36);
            namingMission.TabIndex = 28;
            namingMission.SelectedIndexChanged += namingMission_SelectedIndexChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "UserIcon.png");
            // 
            // DownPanel
            // 
            DownPanel.Dock = DockStyle.Bottom;
            DownPanel.Location = new Point(20, 393);
            DownPanel.Name = "DownPanel";
            DownPanel.Size = new Size(760, 20);
            DownPanel.TabIndex = 25;
            // 
            // RightPanel
            // 
            RightPanel.Dock = DockStyle.Right;
            RightPanel.Location = new Point(780, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(20, 413);
            RightPanel.TabIndex = 26;
            // 
            // LeftPanel
            // 
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(20, 413);
            LeftPanel.TabIndex = 0;
            // 
            // searchResult
            // 
            searchResult.AllowUserToAddRows = false;
            searchResult.AllowUserToDeleteRows = false;
            searchResult.AllowUserToResizeColumns = false;
            searchResult.AllowUserToResizeRows = false;
            searchResult.Anchor = AnchorStyles.Top;
            searchResult.BackgroundColor = SystemColors.ButtonFace;
            searchResult.CellBorderStyle = DataGridViewCellBorderStyle.None;
            searchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchResult.ColumnHeadersVisible = false;
            searchResult.Columns.AddRange(new DataGridViewColumn[] { MissionNameResult, StartDateResult });
            searchResult.Location = new Point(214, 44);
            searchResult.Name = "searchResult";
            searchResult.RowHeadersVisible = false;
            searchResult.RowHeadersWidth = 51;
            searchResult.RowTemplate.Height = 30;
            searchResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchResult.Size = new Size(394, 0);
            searchResult.TabIndex = 6;
            // 
            // MissionNameResult
            // 
            MissionNameResult.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MissionNameResult.HeaderText = "MIssionName";
            MissionNameResult.MinimumWidth = 6;
            MissionNameResult.Name = "MissionNameResult";
            MissionNameResult.ReadOnly = true;
            // 
            // StartDateResult
            // 
            StartDateResult.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StartDateResult.HeaderText = "StartDate";
            StartDateResult.MinimumWidth = 6;
            StartDateResult.Name = "StartDateResult";
            StartDateResult.ReadOnly = true;
            // 
            // missionGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.PowderBlue;
            dataGridViewCellStyle1.Font = new Font("David", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            missionGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            missionGridView.BackGradientOffset = new Point(0, 0);
            missionGridView.BackgroundColor = Color.White;
            missionGridView.BackgroundGradientColor1 = SystemColors.Control;
            missionGridView.BackgroundGradientColor2 = SystemColors.Control;
            missionGridView.BackgroundImageAlign = ContentAlignment.BottomRight;
            missionGridView.BackgroundImageOffset = new Point(0, 0);
            missionGridView.BackgroundImageSizeMode = Tiferix.Global.CoolImageSizeMode.Normal;
            missionGridView.BackgroundImageTransColor = Color.Transparent;
            missionGridView.BackgroundImageTransparent = false;
            missionGridView.BorderStyle = BorderStyle.None;
            missionGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            missionGridView.CellTransAlpha = 0;
            missionGridView.CellTransColor = SystemColors.Control;
            missionGridView.ColHeaderGradientBorderColor = Color.Black;
            missionGridView.ColHeaderGradientColor1 = SystemColors.Control;
            missionGridView.ColHeaderGradientColor2 = SystemColors.Control;
            missionGridView.ColHeaderGradientOffset = new Point(0, 0);
            missionGridView.ColHeadersFont = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            missionGridView.ColHeaderTransAlpha = 0;
            missionGridView.ColHeaderTransColor = SystemColors.Control;
            missionGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.BlueViolet;
            dataGridViewCellStyle2.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            missionGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            missionGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            missionGridView.Columns.AddRange(new DataGridViewColumn[] { itemColumn, serialColumn, buttonColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("David", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            missionGridView.DefaultCellStyle = dataGridViewCellStyle3;
            missionGridView.EnableHeadersVisualStyles = false;
            missionGridView.GridColor = Color.White;
            missionGridView.Location = new Point(130, 85);
            missionGridView.Name = "missionGridView";
            missionGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            missionGridView.RowHeadersWidth = 51;
            missionGridView.RowTemplate.Height = 29;
            missionGridView.SelectedCellTransAlpha = 0;
            missionGridView.SelectedCellTransColor = SystemColors.Control;
            missionGridView.Size = new Size(580, 270);
            missionGridView.TabIndex = 35;
            missionGridView.CellClick += missionGridView_CellClick;
            missionGridView.CellContentClick += missionGridView_CellContentClick;
            missionGridView.CellValueChanged += missionGridView_CellValueChanged;
            missionGridView.EditingControlShowing += missionGridView_EditingControlShowing;
            missionGridView.RowsAdded += missionGridView_addedRow;
            missionGridView.AllowUserToDeleteRows = false;
            // 
            // itemColumn
            // 
            itemColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemColumn.HeaderText = "סוג פריט";
            itemColumn.MinimumWidth = 6;
            itemColumn.Name = "itemColumn";
            // 
            // serialColumn
            // 
            serialColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            serialColumn.HeaderText = "מס\"ד";
            serialColumn.MinimumWidth = 100;
            serialColumn.Name = "serialColumn";
            // 
            // buttonColumn
            // 
            buttonColumn.HeaderText = "תוספות";
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "תוספות";
            buttonColumn.UseColumnTextForButtonValue = true;
            // 
            // UpperPanel
            // 
            UpperPanel.BackColor = Color.BlueViolet;
            UpperPanel.CornerRadius = 10;
            UpperPanel.Location = new Point(130, 73);
            UpperPanel.Name = "UpperPanel";
            UpperPanel.Size = new Size(580, 40);
            UpperPanel.TabIndex = 45;
            // 
            // LowerPanel
            // 
            LowerPanel.BackColor = Color.White;
            LowerPanel.CornerRadius = 10;
            LowerPanel.Location = new Point(130, 280);
            LowerPanel.Name = "LowerPanel";
            LowerPanel.Size = new Size(580, 30);
            LowerPanel.TabIndex = 46;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(345, 362);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(129, 32);
            AddButton.TabIndex = 14;
            AddButton.Text = "הוסף משימה";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // missions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 30, 60);
            ClientSize = new Size(800, 413);
            Controls.Add(AddButton);
            Controls.Add(searchResult);
            Controls.Add(DownPanel);
            Controls.Add(TopPanel);
            Controls.Add(RightPanel);
            Controls.Add(LeftPanel);
            Controls.Add(missionGridView);
            Controls.Add(UpperPanel);
            Controls.Add(LowerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "missions";
            Text = "missions";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataBaseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)missionGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel titleBar;
        private Button closeButton;
        private Panel TopPanel;
        private ImageList imageList1;
        private BindingSource dataBaseBindingSource;
        private Panel DownPanel;
        private Button button5;
        private ComboBox namingMission;
        private Panel RightPanel;
        private Panel LeftPanel;
        private DataGridView searchResult;
        private DataGridViewTextBoxColumn MissionNameResult;
        private DataGridViewTextBoxColumn StartDateResult;

        private DotCoolGridView missionGridView;
        private RoundedPanel UpperPanel;
        private RoundedPanel LowerPanel;
        private CheckBox fixedMissionCheckBox;
        private System.Windows.Forms.Button AddButton;
        private DataGridViewComboBoxColumn itemColumn;
        private DataGridViewComboBoxColumn serialColumn;
        private DataGridViewButtonColumn buttonColumn;
    }
}