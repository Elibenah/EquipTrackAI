namespace Tikshuv.FrontEnd
{
    partial class settings
    {
        
        // Required designer variable.
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

        
        // Required method for Designer support - do not modify
        // the contents of this method with the code editor.
        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.ScreenSize = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.ScreenSize.Click += new System.EventHandler(this.ScreenSize_Click);
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.back.Click += new System.EventHandler(this.back_Click);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.ScreenSize);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 47);
            this.panel1.TabIndex = 0;
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
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.Solider_Click);
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 18.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Tikshuv.Properties.Resources.soldier1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(17, 20, 17, 20);
            this.button1.Size = new System.Drawing.Size(286, 160);
            this.button1.TabIndex = 0;
            this.button1.Text = "חיילים";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = true;
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
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 929);
            this.panel2.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(286, 47);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1036, 929);
            this.panelChildForm.TabIndex = 7;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 976);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "settings";
            this.Text = "settings";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button minimize;
        private Button ScreenSize;
        private Button CloseButton;
        private Button button1;
        private Button back;
        private Panel panel2;
        private Panel panelChildForm;
    }
}