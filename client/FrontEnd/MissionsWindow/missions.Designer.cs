namespace Tikshuv.FrontEnd
{
    partial class Missions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Missions));
            this.panel2 = new System.Windows.Forms.Panel();
            this.signatureButton = new System.Windows.Forms.Button();
            this.Promotional = new System.Windows.Forms.Button();
            this.mission_subpanel = new System.Windows.Forms.Panel();
            this.new_mission = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.missionbutton = new System.Windows.Forms.Button();
            this.regularmissions = new System.Windows.Forms.Button();
            this.Preparedness = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.ScreenSize = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.mission_subpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.signatureButton);
            this.panel2.Controls.Add(this.Promotional);
            this.panel2.Controls.Add(this.mission_subpanel);
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.missionbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 929);
            this.panel2.TabIndex = 3;
            // 
            // signatureButton
            // 
            this.signatureButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.signatureButton.FlatAppearance.BorderSize = 0;
            this.signatureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signatureButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.signatureButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signatureButton.Image = global::Tikshuv.Properties.Resources.Deposit;
            this.signatureButton.Location = new System.Drawing.Point(0, 427);
            this.signatureButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signatureButton.Name = "signatureButton";
            this.signatureButton.Size = new System.Drawing.Size(286, 160);
            this.signatureButton.TabIndex = 4;
            this.signatureButton.Text = "חתימות";
            this.signatureButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.signatureButton.UseVisualStyleBackColor = true;
            this.signatureButton.Click += signedMission_Click;
            // 
            // Promotional
            // 
            this.Promotional.Dock = System.Windows.Forms.DockStyle.Top;
            this.Promotional.FlatAppearance.BorderSize = 0;
            this.Promotional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Promotional.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Promotional.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Promotional.Image = global::Tikshuv.Properties.Resources.Promotional;
            this.Promotional.Location = new System.Drawing.Point(0, 267);
            this.Promotional.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Promotional.Name = "Promotional";
            this.Promotional.Size = new System.Drawing.Size(286, 160);
            this.Promotional.TabIndex = 3;
            this.Promotional.Text = "זיכוי ציוד";
            this.Promotional.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Promotional.UseVisualStyleBackColor = true;
            this.Promotional.Click += Promotional_Click;
            // 
            // mission_subpanel
            // 
            this.mission_subpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.mission_subpanel.Controls.Add(this.new_mission);
            this.mission_subpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mission_subpanel.Location = new System.Drawing.Point(0, 160);
            this.mission_subpanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mission_subpanel.Name = "mission_subpanel";
            this.mission_subpanel.Size = new System.Drawing.Size(286, 107);
            this.mission_subpanel.TabIndex = 5;
            // 
            // new_mission
            // 
            this.new_mission.BackgroundImage = global::Tikshuv.Properties.Resources.current_mission;
            this.new_mission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.new_mission.Dock = System.Windows.Forms.DockStyle.Top;
            this.new_mission.FlatAppearance.BorderSize = 0;
            this.new_mission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_mission.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.new_mission.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.new_mission.Location = new System.Drawing.Point(0, 0);
            this.new_mission.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.new_mission.Name = "new_mission";
            this.new_mission.Padding = new System.Windows.Forms.Padding(166, 0, 0, 0);
            this.new_mission.Size = new System.Drawing.Size(286, 107);
            this.new_mission.TabIndex = 1;
            this.new_mission.Text = "משימות";
            this.new_mission.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.new_mission.UseVisualStyleBackColor = true;
            this.new_mission.Click += new System.EventHandler(this.missions_Click);
            // 
            // back
            // 
            this.back.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(0, 836);
            this.back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(286, 93);
            this.back.TabIndex = 4;
            this.back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.back.UseVisualStyleBackColor = true;
            // 
            // missionbutton
            // 
            this.missionbutton.BackgroundImage = global::Tikshuv.Properties.Resources.fildemissions;
            this.missionbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.missionbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.missionbutton.FlatAppearance.BorderSize = 0;
            this.missionbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.missionbutton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.missionbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.missionbutton.Location = new System.Drawing.Point(0, 0);
            this.missionbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.missionbutton.Name = "missionbutton";
            this.missionbutton.Size = new System.Drawing.Size(286, 160);
            this.missionbutton.TabIndex = 0;
            this.missionbutton.Text = "פריסות";
            this.missionbutton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.missionbutton.UseVisualStyleBackColor = true;
            this.missionbutton.Click += missionbutton_Click;
            // 
            // regularmissions
            // 
            this.regularmissions.BackgroundImage = global::Tikshuv.Properties.Resources.repeat_missions;
            this.regularmissions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.regularmissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.regularmissions.FlatAppearance.BorderSize = 0;
            this.regularmissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regularmissions.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.regularmissions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regularmissions.Location = new System.Drawing.Point(0, 160);
            this.regularmissions.Margin = new System.Windows.Forms.Padding(10);
            this.regularmissions.Name = "regularmissions";
            this.regularmissions.Padding = new System.Windows.Forms.Padding(145, 20, 0, 0);
            this.regularmissions.Size = new System.Drawing.Size(250, 80);
            this.regularmissions.TabIndex = 3;
            this.regularmissions.Text = "משימות קבועות";
            this.regularmissions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.regularmissions.UseVisualStyleBackColor = true;
            // 
            // Preparedness
            // 
            this.Preparedness.BackgroundImage = global::Tikshuv.Properties.Resources.alertness;
            this.Preparedness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Preparedness.Dock = System.Windows.Forms.DockStyle.Top;
            this.Preparedness.FlatAppearance.BorderSize = 0;
            this.Preparedness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Preparedness.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Preparedness.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Preparedness.Location = new System.Drawing.Point(0, 80);
            this.Preparedness.Margin = new System.Windows.Forms.Padding(10);
            this.Preparedness.Name = "Preparedness";
            this.Preparedness.Padding = new System.Windows.Forms.Padding(145, 20, 0, 0);
            this.Preparedness.Size = new System.Drawing.Size(250, 80);
            this.Preparedness.TabIndex = 2;
            this.Preparedness.Text = "כוננויות";
            this.Preparedness.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Preparedness.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(1266, 0);
            this.close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.close.Size = new System.Drawing.Size(56, 67);
            this.close.TabIndex = 5;
            this.close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.close.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 47);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.minimize);
            this.panel3.Controls.Add(this.ScreenSize);
            this.panel3.Controls.Add(this.CloseButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1322, 47);
            this.panel3.TabIndex = 6;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.minimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimize.Location = new System.Drawing.Point(1202, 0);
            this.minimize.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.minimize.Name = "minimize";
            this.minimize.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.minimize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minimize.Size = new System.Drawing.Size(40, 47);
            this.minimize.TabIndex = 21;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new EventHandler(minimize_Click);
            // 
            // ScreenSize
            // 
            this.ScreenSize.BackColor = System.Drawing.Color.Transparent;
            this.ScreenSize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScreenSize.BackgroundImage")));
            this.ScreenSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScreenSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScreenSize.FlatAppearance.BorderSize = 0;
            this.ScreenSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScreenSize.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ScreenSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScreenSize.Location = new System.Drawing.Point(1242, 0);
            this.ScreenSize.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ScreenSize.Name = "ScreenSize";
            this.ScreenSize.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ScreenSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenSize.Size = new System.Drawing.Size(40, 47);
            this.ScreenSize.TabIndex = 20;
            this.ScreenSize.UseVisualStyleBackColor = false;
            this.ScreenSize.Click += new EventHandler(ScreenSize_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImage = global::Tikshuv.Properties.Resources.close;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(1282, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.CloseButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseButton.Size = new System.Drawing.Size(40, 47);
            this.CloseButton.TabIndex = 19;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += CloseButton_Click1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(286, 47);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1036, 929);
            this.panelChildForm.TabIndex = 4;
            // 
            // Missions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 976);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Missions";
            this.Text = "missions";
            this.panel2.ResumeLayout(false);
            this.mission_subpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void CloseButton_Click1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        private Panel titleBar;
        private Button closeButton;
        private Panel panel2;
        private Button back;
        private Button Promotional;
        private Button new_mission;
        private Button missionbutton;
        private Button signatureButton;
        private Button close;
        private Panel panel1;
        private Panel panel3;
        private Button minimize;
        private Button ScreenSize;
        private Button CloseButton;
        private Panel mission_subpanel;
        private Button regularmissions;
        private Button Preparedness;
        private Panel panelChildForm;
    }
}