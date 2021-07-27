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
        public static string Password;
        public static string adminuser;
        public static string adminpassword;
        string active;

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
            string mySQL1 = string.Empty;
            active = "Active";
            mySQL1 += "SELECT Status FROM Parsonal ";
            mySQL1 += "WHERE User_name = '" + UsernameTextbox.Text + "'";
            mySQL1 += "AND Status = '" + active + "'";

            string checknull = "Null";
            string mySQL2 = string.Empty;
            active = "Active";
            mySQL2 += "SELECT Email_address FROM Parsonal ";
            mySQL2 += "WHERE User_name = '" + UsernameTextbox.Text + "'";
            mySQL2 += "AND Email_address = '" + checknull + "'";

            string mySQL3 = string.Empty;
            mySQL3 += "SELECT * FROM Admin_Login ";
            mySQL3 += "WHERE User_name = '" + user + "' ";
            mySQL3 += "AND Password = '" + Password + "'";


            DataTable userData3 = ServerConnection.executeSQL(mySQL3);
            DataTable userData1 = ServerConnection.executeSQL(mySQL1);
            DataTable userData2 = ServerConnection.executeSQL(mySQL2);

            if (!string.IsNullOrEmpty(UsernameTextbox.Text) &&
               !string.IsNullOrEmpty(PasswordTxtbox.Text))
            {
                try
                {
                    string ComboValue = SelectRoleComboBox.SelectedItem.ToString();

                    if (ComboValue == "-By User")
                    {
                        if (userData1.Rows.Count > 0)
                        {
                            if (userData2.Rows.Count > 0)
                            {
                                user = UsernameTextbox.Text;
                                Password = PasswordTxtbox.Text;

                                string mySQL = string.Empty;
                                active = "Active";
                                mySQL += "SELECT * FROM Parsonal ";
                                mySQL += "WHERE User_name = '" + user + "' ";
                                mySQL += "AND Password = '" + Password + "'";

                                DataTable userData = ServerConnection.executeSQL(mySQL);

                                if (userData.Rows.Count > 0)
                                {
                                    UsernameTextbox.Clear();
                                    PasswordTxtbox.Clear();
                                    AlertForm alert = new AlertForm();
                                    MainForm formMain = new MainForm();
                                    alert.ShowDialog();
                                    this.Hide();
                                    formMain.ShowDialog();
                                    this.Close();

                                }
                                else
                                {
                                    MessageBox.Show("The User name and password is incorrect.Try again", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                                    UsernameTextbox.Clear();
                                    PasswordTxtbox.Clear();
                                }
                            }
                            else
                            {
                                user = UsernameTextbox.Text;
                                Password = PasswordTxtbox.Text;

                                string mySQL = string.Empty;
                                active = "Active";
                                mySQL += "SELECT * FROM Parsonal ";
                                mySQL += "WHERE User_name = '" + user + "' ";
                                mySQL += "AND Password = '" + Password + "'";

                                DataTable userData = ServerConnection.executeSQL(mySQL);

                                if (userData.Rows.Count > 0)
                                {
                                    UsernameTextbox.Clear();
                                    PasswordTxtbox.Clear();
                                    this.Hide();
                                    MainForm formMain = new MainForm();
                                    formMain.ShowDialog();
                                    this.Close();

                                }
                                else
                                {
                                    MessageBox.Show("The User name and password is incorrect.Try again", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                                    UsernameTextbox.Clear();
                                    PasswordTxtbox.Clear();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your Account Was Disable", "Message Box");
                            UsernameTextbox.Clear();
                            PasswordTxtbox.Clear();
                            UsernameTextbox.Select();
                        }
                    }
                    else if (ComboValue == "-By Admin")
                    {
                        adminuser = UsernameTextbox.Text;
                        adminpassword = PasswordTxtbox.Text;

                        string mySQL5 = string.Empty;
                        mySQL5 += "SELECT * FROM Admin_Login ";
                        mySQL5 += "WHERE User_name = '" + adminuser + "' ";
                        mySQL5 += "AND Password = '" + adminpassword + "'";

                        DataTable userData5 = ServerConnection.executeSQL(mySQL5);
                        if (userData5.Rows.Count > 0)
                        {
                            AdminForm admin = new AdminForm();
                            MessageBox.Show("You Login As An Admin.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            admin.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("The User name and password is incorrect.Try again", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                            UsernameTextbox.Clear();
                            PasswordTxtbox.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Your Role.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter Your Role.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Username and Password.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                UsernameTextbox.Select();
            }
        }

        private void cerraricon_Click(object sender, EventArgs e)
        {
            CloseForm cf = new CloseForm();
            cf.ShowDialog();
        }

        private void maxIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            RestoreDownIcon.Visible = true;
            maxIcon.Visible = false;
        }

        private void minIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RestoreDownIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            RestoreDownIcon.Visible = false;
            maxIcon.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void HidePasswordBox_Click(object sender, EventArgs e)
        {
            PasswordTxtbox.UseSystemPasswordChar = true;
            ShowPasswordBox.Visible = true;
            HidePasswordBox.Visible = false;
        }

        private void ShowPasswordBox_Click(object sender, EventArgs e)
        {
            PasswordTxtbox.UseSystemPasswordChar = false;
            HidePasswordBox.Visible = true;
            ShowPasswordBox.Visible = false;
        }
    }
}
