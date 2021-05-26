using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Connection;
using Ubiety.Dns.Core;

namespace Bank
{
    public partial class LoginForm : Form
    {
        public static string user;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UsernameTextbox.Select();

        }

        private void OpenRegistationlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            this.Hide();
            register.ShowDialog();
            this.Close();
            
        }

        private void ShowPasswordcheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ShowRememberPasswordcheckBox.Checked == true)
            {
                PasswordTxtbox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTxtbox.UseSystemPasswordChar = true;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerifyFrom vf = new VerifyFrom();
            this.Hide();
            vf.ShowDialog();
            this.Close();

        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            String User_type = UserTypecomboBox.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(UsernameTextbox.Text) &&
                !string.IsNullOrEmpty(PasswordTxtbox.Text))
            {
                if (User_type == "User")
                {
                    user = UsernameTextbox.Text;

                    string mySQL = string.Empty;
                    mySQL += "SELECT * FROM Parsonal ";
                    mySQL += "WHERE User_name = '" + user + "' ";
                    mySQL += "AND Password = '" + PasswordTxtbox.Text + "'";

                    DataTable userData = ServerConnection.executeSQL(mySQL);

                    if (userData.Rows.Count > 0)
                    {
                        UsernameTextbox.Clear();
                        PasswordTxtbox.Clear();
                        ShowRememberPasswordcheckBox.Checked = false;

                        this.Hide();

                        MainForm formMain = new MainForm();
                        formMain.ShowDialog();
                        formMain = null;

                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("The User name and password is incorrect.Try again", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        UsernameTextbox.Clear();
                        PasswordTxtbox.Clear();
                        ShowRememberPasswordcheckBox.Checked = false;
                    }
                }
                else if(User_type == "Admin")
                {
                    string mySQL1 = string.Empty;
                    mySQL1 += "SELECT * FROM Admin_Login ";
                    mySQL1 += "WHERE User_name = '" + UsernameTextbox.Text + "' ";
                    mySQL1 += "AND Password = '" + PasswordTxtbox.Text + "'";

                    DataTable userData1 = ServerConnection.executeSQL(mySQL1);

                    if (userData1.Rows.Count > 0)
                    {
                        UsernameTextbox.Clear();
                        PasswordTxtbox.Clear();
                        ShowRememberPasswordcheckBox.Checked = false;

                        this.Hide();

                        AdminForm admin = new AdminForm();
                        admin.ShowDialog();
                        admin = null;

                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("The User name and password is incorrect.Try again", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        UsernameTextbox.Clear();
                        PasswordTxtbox.Clear();
                        ShowRememberPasswordcheckBox.Checked = false;
                    }
                }
                else if(User_type == "")
                {
                    MessageBox.Show("Select User type.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Username and Password.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                UsernameTextbox.Select();

            }
        }

        private void UserTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
