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
    public partial class MainForm : Form
    {
        string username = LoginForm.user;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Depositbutton_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            DepositForm deposit = new DepositForm();
            deposit.TopLevel = false;
            Menupanel.Controls.Add(deposit);
            deposit.Show();
        }

        private void AccountReviewbutton_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            Account_Rewiew_Form AR = new Account_Rewiew_Form();
            AR.TopLevel = false;
            Menupanel.Controls.Add(AR);
            AR.Show();
        }

        private void Withdrawbutton_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            WithdrawFrom withdraw = new WithdrawFrom();
            withdraw.TopLevel = false;
            Menupanel.Controls.Add(withdraw);
            withdraw.Show();
        }

        private void Transationbutton_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            TransationForm transation = new TransationForm();
            transation.TopLevel = false;
            Menupanel.Controls.Add(transation);
            transation.Show();
        }

        private void ChangePasswordbutton_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            ChangePasswordForm changePassword = new ChangePasswordForm();
            changePassword.TopLevel = false;
            Menupanel.Controls.Add(changePassword);
            changePassword.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
                    "Initial Catalog = BankSystemDataBase; Integrated Security = True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT User_name FROM Parsonal WHERE User_name = "+ username, conn);
            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                textBox1.Text = da.GetValue(0).ToString();
            }
        }*/

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string ID = textBox2.Text;
            SqlConnection conn = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
                    "Initial Catalog = BankSystemDataBase; Integrated Security = True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT User_name FROM Parsonal WHERE Id = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox2.Text));
            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                textBox1.Text = da.GetValue(0).ToString();
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
