using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bank.Connection;

namespace Bank
{
    public partial class ForgetPassword : Form
    {
        string User_name = VerifyFrom.verifyname;
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showconfirmpassword.Checked == true)
            {
                confirmpasswordtextBox.UseSystemPasswordChar = false;
            }
            else
            {
                confirmpasswordtextBox.UseSystemPasswordChar = true;
            }
        }

        private void SavePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(newpasswordTextBox.Text) &&
                    !string.IsNullOrEmpty(confirmpasswordtextBox.Text))
                {
                    SqlConnection con = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
                "Initial Catalog = BankSystemDataBase; Integrated Security = True");

                        if (newpasswordTextBox.Text == confirmpasswordtextBox.Text)
                        {
                            string mySQL = string.Empty;
                            mySQL += "SELECT Password FROM Parsonal ";
                            mySQL += "UPDATE [dbo].[Parsonal] ";
                            mySQL += "SET [Password] = '" + confirmpasswordtextBox.Text + "'" +
                            " WHERE User_Name = '" + User_name + "'";

                            DataTable userData = ServerConnection.executeSQL(mySQL);

                            if (userData.Rows.Count > 0)
                            {
                                MessageBox.Show("Save Successfully.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.None);
                                LoginForm login = new LoginForm();
                                this.Hide();
                                login.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Fill All The Requird Field.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The Password Do Not Match. Enter Same Password.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        con.Close();
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fill All The Requird Field." + ex , "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            VerifyFrom verify = new VerifyFrom();
            this.Hide();
            verify.ShowDialog();
            this.Close();
        }

        private void cerraricon_Click(object sender, EventArgs e)
        {
            CloseForm close = new CloseForm();
            close.ShowDialog();
        }

        private void RestoreDownIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            RestoreDownIcon.Visible = false;
            maxIcon.Visible = true;
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
    }
}
