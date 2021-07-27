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
    public partial class WithdrawFrom : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        String UserName = LoginForm.user;
        String Password = LoginForm.Password;
        string to;
        public WithdrawFrom()
        {
            InitializeComponent();
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

        private void Usenamebutton_Click(object sender, EventArgs e)
        {
            Withdrawpanel.Enabled = true;
            WithdrawAmountTextbox.Select();
            WithdrawUserNamepanel.Enabled = false;
        }

        private void WithdrawAmountbutton_Click(object sender, EventArgs e)
        {
            WithdrawPasswordpanel.Enabled = true;
            PasswordTextbox.Select();
            Withdrawpanel.Enabled = false;
        }

        private double TotalBalance()
        {
            SqlConnection.Open();
            double balance;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Total_Money FROM Customer_Details WHERE FUser_Name = '" + UserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            balance = Convert.ToDouble(data.Rows[0][0]);
            SqlConnection.Close();

            return balance;
        }

        private String GetAccountType()
        {
            SqlConnection.Open();
            string type;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Account_Type FROM Parsonal WHERE User_Name = '" + UserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            type = (data.Rows[0][0]).ToString();
            SqlConnection.Close();

            return type;
        }

        private string GetEmail()
        {
            SqlConnection.Open();
            string mail;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Email_address FROM Parsonal WHERE User_Name = '" + UserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            mail = data.Rows[0][0].ToString();
            SqlConnection.Close();

            return mail;
        }

        private void Withdrawtbutton_Click_1(object sender, EventArgs e)
        {
            string AccountType = "Saving Account";

            string checknull = "Null";
            string mySQL8 = string.Empty;
            mySQL8 += "SELECT Email_address FROM Parsonal ";
            mySQL8 += "WHERE User_name = '" + UserName + "'";
            mySQL8 += "AND Email_address = '" + checknull + "'";

            DataTable userData8 = ServerConnection.executeSQL(mySQL8);

            if (WithdrawUseNameTextbox.Text == UserName && PasswordTextbox.Text == Password)
            {
                if(AccountType == GetAccountType())
                {
                    MessageBox.Show("You can't Withdraw Money. This Accont is a Saving Account ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double withdrawamount = Convert.ToDouble(WithdrawAmountTextbox.Text);

                    if(withdrawamount <= TotalBalance())
                    {
                        if (userData8.Rows.Count > 0)
                        {
                            AlertForm alert = new AlertForm();
                            alert.ShowDialog();
                        }
                        else
                        {
                            string field = "Withdraw";

                            string mySQL = string.Empty;
                            mySQL += "SELECT * FROM Customer_Details ";
                            mySQL += "UPDATE [dbo].[Customer_Details]";
                            mySQL += "SET [Total_Money] = '" + (TotalBalance() - withdrawamount) + "'";
                            mySQL += "WHERE FUser_Name = '" + UserName + "'";

                            string mySQL2 = string.Empty;
                            DateTime dateTimeVariable = DateTime.Now;
                            mySQL2 += "SELECT * FROM Customer_Details ";
                            mySQL2 += "UPDATE [dbo].[Customer_Details]";
                            mySQL2 += "SET [WDate_Time] = '" + dateTimeVariable + "'";
                            mySQL2 += "WHERE FUser_Name = '" + UserName + "'";

                            string mySQL5 = string.Empty;

                            mySQL5 += @"INSERT INTO [dbo].[Transation_History]
                                   ([TUser_name]
                                   ,[Amount]
                                   ,[Field]
                                   ,[Date])
                            VALUES
                                   ('" + UserName + "', '" + withdrawamount + "', '" + field + "', '" + dateTimeVariable + "')";

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
                            mySQL1 += "WHERE FUser_Name = '" + UserName + "'";

                            DataTable userData1 = ServerConnection.executeSQL(mySQL1);

                            string mySQL3 = string.Empty;
                            mySQL3 += "SELECT * FROM Current_Transation_Details ";
                            mySQL3 += "UPDATE [dbo].[Current_Transation_Details]";
                            mySQL3 += "SET [Current_Withdraw_balance] = '" + WithdrawCurrentlabel.Text + "'";
                            mySQL3 += "WHERE CUser_Name = '" + UserName + "'";

                            DataTable userData3 = ServerConnection.executeSQL(mySQL3);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Balance", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Withdrawpanel.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("User Name Or Password Incorrect ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void GetFirstName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT First_Name FROM Parsonal WHERE User_Name = '" + UserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            WithdrawFirstNamelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void WithdrawFirstNamepanel_Paint(object sender, PaintEventArgs e)
        {
            GetFirstName();
        }

        private void GetLastName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Last_Name FROM Parsonal WHERE User_Name = '" + UserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            WithdrawLastNamelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void WithdrawLastNamepanel_Paint(object sender, PaintEventArgs e)
        {
            GetLastName();
        }

        private void GeTotalBalance()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Total_Money FROM Customer_Details WHERE FUser_Name = '" + UserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            WithdrawCurrentlabel.Text = (data.Rows[0][0]).ToString();
            SqlConnection.Close();
        }

        private void WithdrawCurrentAmmountpanel_Paint(object sender, PaintEventArgs e)
        {
            GeTotalBalance();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
