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
    public partial class PasswordForm : Form
    {
        string password = LoginForm.adminpassword;
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void PasswordDoneButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextbox.Equals(""))
            {
                MessageBox.Show("Enter Password", "Message Box");
            }
            else
            {
                if (PasswordTextbox.Text == password)
                {
                    MessageBox.Show("successfull...", "Message Box");
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Failed.....", "Message Box");
                }
            }
        }
    }
}
