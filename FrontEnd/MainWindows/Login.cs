using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tikshuv.FrontEnd
{
    
    partial class Login : Form
    {
        // P/Invoke declarations
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            
            if (txtUsername.Text == "user" && txtPassword.Text == "pass")
            {
                MessageBox.Show("Login successful!");
               
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.");
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the application
        }
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
