namespace Tikshuv.FrontEnd
{
    partial class Main
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.ScreenSize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.storage = new System.Windows.Forms.Button();
            this.missions = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.storageLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsLable = new System.Windows.Forms.Label();
            // AI Input TextBox
            this.txtAiInput = new System.Windows.Forms.TextBox();
            this.txtAiInput.Location = new System.Drawing.Point(550, 150); // Adjust Y as needed
            this.txtAiInput.Size = new System.Drawing.Size(250, 30);
            this.txtAiInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAiInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAiInput.PlaceholderText = "שאל שאלה (למשל: איפה הציוד)";
            this.Controls.Add(this.txtAiInput);

            this.MissionLable = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // AI Button
            this.btnAskAi = new System.Windows.Forms.Button();
            this.btnAskAi.Location = new System.Drawing.Point(810, 150); // To the right of the TextBox
            this.btnAskAi.Size = new System.Drawing.Size(60, 30);
            this.btnAskAi.Text = "שאל";
            this.btnAskAi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAskAi.BackColor = System.Drawing.Color.White;
            this.btnAskAi.Click += new System.EventHandler(this.btnAskAi_Click);
            this.Controls.Add(this.btnAskAi);





            // CloseButton
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImage = global::Tikshuv.Properties.Resources.close;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(1174, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 36);
            this.CloseButton.TabIndex = 14;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click); // ADDED EVENT

            // panel5
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.minimize);
            this.panel5.Controls.Add(this.ScreenSize);
            this.panel5.Controls.Add(this.CloseButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1214, 36);
            this.panel5.TabIndex = 15;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown); // ADDED EVENT
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove); // ADDED EVENT


            // minimize
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(1094, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(40, 36);
            this.minimize.TabIndex = 18;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click); // ADDED EVENT

            // ScreenSize
            this.ScreenSize.BackColor = System.Drawing.Color.Transparent;
            this.ScreenSize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScreenSize.BackgroundImage")));
            this.ScreenSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScreenSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScreenSize.FlatAppearance.BorderSize = 0;
            this.ScreenSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScreenSize.Location = new System.Drawing.Point(1134, 0);
            this.ScreenSize.Name = "ScreenSize";
            this.ScreenSize.Size = new System.Drawing.Size(40, 36);
            this.ScreenSize.TabIndex = 17;
            this.ScreenSize.UseVisualStyleBackColor = false;
            this.ScreenSize.Click += new System.EventHandler(this.ScreenSize_Click); // ADDED EVENT

            // pictureBox1
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Tikshuv.Properties.Resources.network_vid;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1214, 901);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click); // ADDED EVENT
            this.pictureBox1.SendToBack();

            // storage
            this.storage.BackColor = System.Drawing.Color.Transparent;
            this.storage.Dock = System.Windows.Forms.DockStyle.Top;
            this.storage.FlatAppearance.BorderSize = 0;
            this.storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storage.Image = global::Tikshuv.Properties.Resources.warehouse;
            this.storage.Location = new System.Drawing.Point(0, 0);
            this.storage.Name = "storage";
            this.storage.Padding = new System.Windows.Forms.Padding(29, 33, 29, 33);
            this.storage.Size = new System.Drawing.Size(343, 222);
            this.storage.TabIndex = 11;
            this.storage.UseVisualStyleBackColor = false;
            this.storage.Click += new System.EventHandler(this.storage_Click); // ADDED EVENT
            this.storage.MouseHover += new System.EventHandler(this.storage_MouseHover); // ADDED EVENT
            this.storage.MouseLeave += new System.EventHandler(this.storage_MouseLeave); // ADDED EVENT

            // missions
            this.missions.BackColor = System.Drawing.Color.Transparent;
            this.missions.Dock = System.Windows.Forms.DockStyle.Top;
            this.missions.FlatAppearance.BorderSize = 0;
            this.missions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.missions.Image = global::Tikshuv.Properties.Resources.missions;
            this.missions.Location = new System.Drawing.Point(0, 222);
            this.missions.Name = "missions";
            this.missions.Padding = new System.Windows.Forms.Padding(29, 33, 29, 33);
            this.missions.Size = new System.Drawing.Size(343, 222);
            this.missions.TabIndex = 10;
            this.missions.UseVisualStyleBackColor = false;
            this.missions.Click += new System.EventHandler(this.missions_Click); // ADDED EVENT
            this.missions.MouseHover += new System.EventHandler(this.missions_MouseHover); // ADDED EVENT
            this.missions.MouseLeave += new System.EventHandler(this.missions_MouseLeave); // ADDED EVENT

            // settings
            this.settings.BackColor = System.Drawing.Color.Transparent;
            this.settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Image = global::Tikshuv.Properties.Resources.settings;
            this.settings.Location = new System.Drawing.Point(0, 444);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(29, 33, 29, 33);
            this.settings.Size = new System.Drawing.Size(343, 222);
            this.settings.TabIndex = 9;
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click); // ADDED EVENT
            this.settings.MouseHover += new System.EventHandler(this.settings_MouseHover); // ADDED EVENT
            this.settings.MouseLeave += new System.EventHandler(this.settings_MouseLeave); // ADDED EVENT

            // panel6
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.settings);
            this.panel6.Controls.Add(this.missions);
            this.panel6.Controls.Add(this.storage);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(343, 865);
            this.panel6.TabIndex = 17;

            // panel1 + labels
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.SettingsLable);
            this.panel1.Controls.Add(this.MissionLable);
            this.panel1.Controls.Add(this.storageLable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(343, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 865);
            this.panel1.TabIndex = 20;

            // labels setup
            this.storageLable.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.MissionLable.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.SettingsLable.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.storageLable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MissionLable.ForeColor = System.Drawing.SystemColors.ControlLightLight; 
            this.SettingsLable.ForeColor = System.Drawing.SystemColors.ControlLightLight;


            // Set manual position and size for each label
            this.storageLable.Location = new System.Drawing.Point(70, 50);
            this.storageLable.Size = new System.Drawing.Size(200, 100);
            this.storageLable.Text = "מחסן";
            this.storageLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.storageLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.MissionLable.Location = new System.Drawing.Point(40, 290);
            this.MissionLable.Size = new System.Drawing.Size(300, 100);
            this.MissionLable.Text = "משימות";
            this.MissionLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MissionLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.SettingsLable.Location = new System.Drawing.Point(40, 530);
            this.SettingsLable.Size = new System.Drawing.Size(300, 100);
            this.SettingsLable.Text = "הגדרות";
            this.SettingsLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SettingsLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;



            // Main form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(54, 75, 109);
            this.BackgroundImage = global::Tikshuv.Properties.Resources.network_vid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 901);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAiInput);
            this.Controls.Add(this.btnAskAi);
           
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "main";
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            // Fix the z-order so that pictureBox1 is in the background
            this.pictureBox1.SendToBack();      // Sends the image to the background
            this.panel5.BringToFront(); // Top bar
            this.panel6.BringToFront(); // Button panel (warehouse etc.)
            this.panel1.BringToFront(); // Text panel (warehouse/tasks etc.)

            // Bring navigation panels and labels to the front of the form
            //panel5.BringToFront();       // Top panel with close/minimize buttons
           // panel6.BringToFront();       // Left-side buttons (storage, missions, settings)
           // panel1.BringToFront();// Panel that holds the label texts
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // Bring labels to front to ensure they are visible above everything
            storageLable.BringToFront();
            MissionLable.BringToFront();
            SettingsLable.BringToFront();



            // Hebrew labels for side menu
            this.storageLable.Text = "מחסן";
            this.MissionLable.Text = "משימות";
            this.SettingsLable.Text = "הגדרות";

            // Make labels transparent and white
            this.storageLable.BackColor = System.Drawing.Color.Transparent;
            this.MissionLable.BackColor = System.Drawing.Color.Transparent;
            this.SettingsLable.BackColor = System.Drawing.Color.Transparent;

            this.storageLable.ForeColor = System.Drawing.Color.White;
            this.MissionLable.ForeColor = System.Drawing.Color.White;
            this.SettingsLable.ForeColor = System.Drawing.Color.White;

            // Ensure Z-order so labels are not hidden
            this.pictureBox1.SendToBack();
            this.panel5.BringToFront();
            this.panel6.BringToFront();
            this.panel1.BringToFront();
            this.storageLable.BringToFront();
            

            this.ResumeLayout(false);
            this.btnAskAi.BringToFront();
            this.txtAiInput.BringToFront();
        }

        #endregion

        private Button CloseButton;
        private Panel panel5;
        private Button minimize;
        private Button ScreenSize;
        private PictureBox pictureBox1;
        private Button storage;
        private Button missions;
        private Button settings;
        private Panel panel6;
        private Label storageLable;
        private Panel panel1;
        private Label SettingsLable;
        private Label MissionLable;
        private System.Windows.Forms.TextBox txtAiInput;
        private System.Windows.Forms.Button btnAskAi;
       


    }
}
