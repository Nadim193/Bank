using Bank.Connection;
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
    public partial class ChangePasswordForm : Form
    {
        string changepassword = LoginForm.Password;
        string changeuser = LoginForm.user;
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ShowPasswordBox_Click(object sender, EventArgs e)
        {
            OldPasswordTextbox.UseSystemPasswordChar = false;
            HidePasswordBox.Visible = true;
            ShowPasswordBox.Visible = false;
        }

        private void HidePasswordBox_Click(object sender, EventArgs e)
        {
            OldPasswordTextbox.UseSystemPasswordChar = true;
            ShowPasswordBox.Visible = true;
            HidePasswordBox.Visible = false;
        }

        private void NewPasswordShowBox_Click(object sender, EventArgs e)
        {
            NewPasswordTextbox.UseSystemPasswordChar = false;
            NewPasswordHideBox.Visible = true;
            NewPasswordShowBox.Visible = false;
        }

        private void NewPasswordHideBox_Click(object sender, EventArgs e)
        {
            NewPasswordTextbox.UseSystemPasswordChar = true;
            NewPasswordShowBox.Visible = true;
            NewPasswordHideBox.Visible = false;
        }

        private void ConfirmShowPasswordBox_Click(object sender, EventArgs e)
        {
            ConfirmPasswordTextbox.UseSystemPasswordChar = false;
            ConfirmHidePasswordBox.Visible = true;
            ConfirmShowPasswordBox.Visible = false;
        }

        private void ConfirmHidePasswordBox_Click(object sender, EventArgs e)
        {
            ConfirmPasswordTextbox.UseSystemPasswordChar = true;
            ConfirmShowPasswordBox.Visible = true;
            ConfirmHidePasswordBox.Visible = false;
        }

        private void ChangePasswordbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (OldPasswordTextbox.Text == changepassword)
                {
                    if(NewPasswordTextbox.Text.Equals("") || ConfirmPasswordTextbox.Text.Equals(""))
                    {
                        MessageBox.Show("Fill All The Requird Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NewPasswordTextbox.Clear();
                        ConfirmPasswordTextbox.Clear();
                    }
                    else
                    {
                        if (NewPasswordTextbox.Text == ConfirmPasswordTextbox.Text)
                        {
                            string mySQL = string.Empty;
                            mySQL += "SELECT Password FROM Parsonal ";
                            mySQL += "UPDATE [dbo].[Parsonal] ";
                            mySQL += "SET [Password] = '" + ConfirmPasswordTextbox.Text + "'" +
                            " WHERE User_Name = '" + changeuser + "'";

                            DataTable userData = ServerConnection.executeSQL(mySQL);

                            if (userData.Rows.Count > 0)
                            {
                                MessageBox.Show("Save Successfully.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.None);
                                OldPasswordTextbox.Clear();
                                NewPasswordTextbox.Clear();
                                ConfirmPasswordTextbox.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Fill All The Requird Field.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password Did Not Match", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            NewPasswordTextbox.Clear();
                            ConfirmPasswordTextbox.Clear();
                            NewPasswordTextbox.Select();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Old Password Incorrect", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OldPasswordTextbox.Clear();
                    OldPasswordTextbox.Select();
                }
            }
            catch
            {
                MessageBox.Show("Enter Valid Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

