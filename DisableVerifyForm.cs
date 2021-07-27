using Bank.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class DisableVerifyForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        string username = LoginForm.user;
        string RandomCode = DisableSureForm.randomCode;

        public DisableVerifyForm()
        {
            InitializeComponent();
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

        private void verifyBackbutton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private string GetMail()
        {
            SqlConnection.Open();
            string mail;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Email_address FROM Parsonal WHERE User_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            mail = data.Rows[0][0].ToString();
            SqlConnection.Close();
            return mail;
        }

        private void Verify_Paint(object sender, PaintEventArgs e)
        {
            VerifyMailLable.Text = GetMail();
        }

        private void Verifybutton_Click(object sender, EventArgs e)
        {
            if(DisiableCodetextBox.Text == RandomCode)
            {
                string Disable = "Disable";

                string mySQL = string.Empty;
                mySQL += "SELECT Status FROM Parsonal ";
                mySQL += "UPDATE [dbo].[Parsonal] ";
                mySQL += "SET [Status] = '" + Disable + "'" +
                " WHERE User_Name = '" + username + "'";

                DataTable userData = ServerConnection.executeSQL(mySQL);

                if (userData.Rows.Count > 0)
                {
                    MessageBox.Show("Account Disable Successfully.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("OTP Did not match.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
