using Bank.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class AdminWithdrawForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
           "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        string Password = LoginForm.adminpassword;
        string username = LoginForm.adminuser;
        string to;

        public AdminWithdrawForm()
        {
            InitializeComponent();
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GeTotalBalance()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Total_Money FROM Customer_Details WHERE FUser_Name = '" + WithdrawUseNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            WithdrawCurrentlabel.Text = (data.Rows[0][0]).ToString();
            SqlConnection.Close();
        }

        private void WithdrawCurrentAmmountpanel_Paint(object sender, PaintEventArgs e)
        {
            WithdrawCurrentlabel.Text = "";
        }

        private void SearchWithdrawButton_Click(object sender, EventArgs e)
        {
            string mySQL5 = string.Empty;
            mySQL5 += "SELECT User_Name FROM Parsonal ";
            mySQL5 += "WHERE  User_Name = '" + WithdrawUseNameTextbox.Text + "'";

            DataTable userData5 = ServerConnection.executeSQL(mySQL5);

            if (userData5.Rows.Count > 0)
            {
                GetFirstName();
                GetLastName();
                GeTotalBalance();
                Withdrawpanel.Enabled = true;
                WithdrawUserNamepanel.Enabled = false;
            }
            else
            {
                MessageBox.Show("This user name is not existed", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WithdrawUserNamepanel.Enabled = true;
                WithdrawUseNameTextbox.Clear();
                WithdrawUseNameTextbox.Select();
            }
        }

        private void GetFirstName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT First_Name FROM Parsonal WHERE User_Name = '" + WithdrawUseNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            WithdrawFirstNamelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void WithdrawFirstNamepanel_Paint(object sender, PaintEventArgs e)
        {
            WithdrawFirstNamelabel.Text = "";
        }

        private void GetLastName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Last_Name FROM Parsonal WHERE User_Name = '" + WithdrawUseNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            WithdrawLastNamelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void WithdrawLastNamepanel_Paint(object sender, PaintEventArgs e)
        {
            WithdrawLastNamelabel.Text = "";
        }

        private void WitdrawAmountButton_Click(object sender, EventArgs e)
        {
            if (WithdrawAmountTextbox.Text == null)
            {
                MessageBox.Show("Please Enter Ammount.");
            }
            else
            {
                WithdrawPasswordpanel.Enabled = true;
                PasswordTextbox.Select();
                Withdrawpanel.Enabled = false;
            }
        }

        private void ShowRememberPasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowRememberPasswordcheckBox.Checked == true)
            {
                PasswordTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextbox.UseSystemPasswordChar = true;
            }
        }

        private double TotalBalance()
        {
            SqlConnection.Open();
            double balance;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Total_Money FROM Customer_Details WHERE FUser_Name = '" + WithdrawUseNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            balance = Convert.ToDouble(data.Rows[0][0]);
            SqlConnection.Close();

            return balance;
        }

        private string GetEmail()
        {
            SqlConnection.Open();
            string mail;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Email_address FROM Parsonal WHERE User_Name = '" + WithdrawUseNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            mail = data.Rows[0][0].ToString();
            SqlConnection.Close();

            return mail;
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == Password)
            {
                double withdrawamount = Convert.ToDouble(WithdrawAmountTextbox.Text);

                if (withdrawamount <= TotalBalance())
                {
                        string field = "Withdraw";

                        string mySQL = string.Empty;
                        mySQL += "SELECT * FROM Customer_Details ";
                        mySQL += "UPDATE [dbo].[Customer_Details]";
                        mySQL += "SET [Total_Money] = '" + (TotalBalance() - withdrawamount) + "'";
                        mySQL += "WHERE FUser_Name = '" + WithdrawUseNameTextbox.Text + "'";

                        string mySQL2 = string.Empty;
                        DateTime dateTimeVariable = DateTime.Now;
                        mySQL2 += "SELECT * FROM Customer_Details ";
                        mySQL2 += "UPDATE [dbo].[Customer_Details]";
                        mySQL2 += "SET [WDate_Time] = '" + dateTimeVariable + "'";
                        mySQL2 += "WHERE FUser_Name = '" + WithdrawUseNameTextbox.Text + "'";

                        string mySQL5 = string.Empty;

                        mySQL5 += @"INSERT INTO [dbo].[Transation_History]
                                   ([TUser_name]
                                   ,[Amount]
                                   ,[Field]
                                   ,[Date])
                            VALUES
                                   ('" + WithdrawUseNameTextbox.Text + "', '" + withdrawamount + "', '" + field + "', '" + dateTimeVariable + "')";

                        DataTable userData = ServerConnection.executeSQL(mySQL);
                        DataTable userData2 = ServerConnection.executeSQL(mySQL2);
                        DataTable userData5 = ServerConnection.executeSQL(mySQL5);

                        string from, pass, messageBody;
                        Random rand = new Random();
                        MailMessage message = new MailMessage();
                        to = GetEmail();
                        from = "nadim.hossain193@gmail.com";
                        pass = "nadim1155";
                        messageBody = "Withdraw Amount : " + withdrawamount + "    Your Balance Is : " + TotalBalance();
                        message.To.Add(to);
                        message.From = new MailAddress(from);
                        message.Body = messageBody;
                        message.Subject = "Account Transation Information.";
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.Credentials = new NetworkCredential(from, pass);
                            smtp.EnableSsl = true;
                            smtp.Send(message);
                        }

                        MessageBox.Show("WITHDRAW SUCCESSFULL", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string mySQL1 = string.Empty;
                        mySQL1 += "SELECT * FROM Customer_Details ";
                        mySQL1 += "UPDATE [dbo].[Customer_Details]";
                        mySQL1 += "SET [Withdraw_Money] = '" + withdrawamount + "'";
                        mySQL1 += "WHERE FUser_Name = '" + WithdrawUseNameTextbox.Text + "'";

                        DataTable userData1 = ServerConnection.executeSQL(mySQL1);

                        string mySQL3 = string.Empty;
                        mySQL3 += "SELECT * FROM Current_Transation_Details ";
                        mySQL3 += "UPDATE [dbo].[Current_Transation_Details]";
                        mySQL3 += "SET [Current_Withdraw_balance] = '" + WithdrawCurrentlabel.Text + "'";
                        mySQL3 += "WHERE CUser_Name = '" + WithdrawUseNameTextbox.Text + "'";

                        DataTable userData3 = ServerConnection.executeSQL(mySQL3);

                }
                else
                {
                    MessageBox.Show("Insufficient Balance", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Withdrawpanel.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Password Incorrect ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WithdrawAmountTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && WithdrawAmountTextbox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Enter Valide Number.");
                WithdrawAmountTextbox.Clear();
            }
        }
    }
}
