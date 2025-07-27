using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tikshuv.Logic.DataAccess;

using System.Data.SQLite;
using HandyControl.Tools;

namespace Tikshuv.SubForms.LogicSubForms
{
    public partial class UpdateSoliderForm : Form
    {
        private Solider parentForm;

        public UpdateSoliderForm(Solider parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        public UpdateSoliderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // need to implemant
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string privateNumber = txtID.Text.Trim();
            string name = txtName.Text.Trim();
            string familyName = txtFamilyName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();

            // Gender is not saved in DB, just for UI display
            if (cmbGender.SelectedItem == null)
            {
                MessageBox.Show("אנא בחר מגדר מהרשימה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbLevel.SelectedItem == null)
            {
                MessageBox.Show("אנא בחר תפקיד מהרשימה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Map Level (string) to numeric value
            int premissions = cmbLevel.SelectedItem.ToString() switch
            {
                "מילואים" => 0,
                "קבע" => 1,
                "סדיר" => 2,
                "חוץ" => 3,
                _ => -1
            };

            if (premissions == -1)
            {
                MessageBox.Show("תפקיד לא תקין.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string birthDate = dtpBirthDate.Value.ToString("yyyy-MM-dd");
            DateTime selectedDate = dtpBirthDate.Value;
            int age = DateTime.Now.Year - selectedDate.Year;
            if (selectedDate.Date > DateTime.Now.AddYears(-age)) age--;

            if (age < 18)
            {
                MessageBox.Show("החייל חייב להיות בן 18 לפחות.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(privateNumber) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(familyName) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("אנא מלא את כל השדות החיוניים.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO soliders (privateNumber, name, familyname, phoneNumber, dateofBirth, premissions) VALUES (@id, @name, @familyName, @phoneNumber, @birthDate, @level)";


            // Create a soldier object to send to the server
            var newSoliderObject = new
            {
                ID = privateNumber,
                name = name,
                familyName = familyName,
                phoneNumber = phoneNumber,
                dateofBirth = birthDate,
                premissionLevel = premissions
            };

            //Send the request to the server to add a soldier.
            Tikshuv.Logic.ConnectionHandler.SendRequest("solider", "addSolider", newSoliderObject);

            MessageBox.Show("החייל נשלח לשרת!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            this.Close();
            parentForm.CloseSidePanle();

        }

        private void ClearForm()
        {
            txtID.Clear();
            txtName.Clear();
            txtFamilyName.Clear();
            txtPhoneNumber.Clear();
            cmbGender.SelectedIndex = -1;
            cmbLevel.SelectedIndex = -1;
            dtpBirthDate.Value = DateTime.Today;
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.CloseSidePanle();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            txtID.Clear();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.Clear();
        }

        private void txtFamilyName_Enter(object sender, EventArgs e)
        {
            txtFamilyName.Clear();
        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            txtPhoneNumber.Clear();
        }




    }

}

