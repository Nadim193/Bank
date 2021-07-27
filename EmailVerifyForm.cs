using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class EmailVerifyForm : Form
    {
        string email = EditProfileForm.emailaddress;
        string Random = EditProfileForm.randomCode;
        public EmailVerifyForm()
        {
            InitializeComponent();
        }

        private void cerraricon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void varifyEmailpanel_Paint(object sender, PaintEventArgs e)
        {
            EmalAddresslabel.Text = email;
        }

        private void EmailVerifybutton_Click(object sender, EventArgs e)
        {
            if(EmailVerifytextBox.Text == Random)
            {
                MessageBox.Show("Verify Successfull.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Code.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
