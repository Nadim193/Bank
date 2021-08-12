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
    public partial class DepositForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        public static string depositbalance;
        String UserName = LoginForm.user;
        String Password = LoginForm.Password;
        string to;

        public DepositForm()
        {
            InitializeComponent();
            DepositUserNameTextbox.Select();
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
            if(DepositUserNameTextbox.Text == UserName)
            {
                Depositpanel.Enabled = true;
                DepositAmountTextbox.Select();
                DepositUserNamepanel.Enabled = false;
            }
            else
            {
                MessageBox.Show("Enter Correct User Name.");
            }
        }

        private void DepositAmountbutton_Click(object sender, EventArgs e)
        {
            if (DepositAmountTextbox.Equals(""))
            {
                MessageBox.Show("Please Enter Ammount.");
            }
            else
            {
                DepositPasswordpanel.Enabled = true;
                PasswordTextbox.Select();
                Depositpanel.Enabled = false;
            }
        }

        private double DepositBalance()
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

        private void Depositbutton_Click(object sender, EventArgs e)
        {
            if(DepositUserNameTextbox.Text == UserName && PasswordTextbox.Text == Password)
            {
                string checknull = "";
                string mySQL6 = string.Empty;
                mySQL6 += "SELECT Email_address FROM Parsonal ";
                mySQL6 += "WHERE User_name = '" + UserName + "'";
                mySQL6 += "AND Email_address = '" + checknull + "'";

                DataTable userData6 = ServerConnection.executeSQL(mySQL6);

                if (userData6.Rows.Count > 0)
                {
                    AlertForm alert = new AlertForm();
                    alert.ShowDialog();
                }
                else
                {
                    double depositamount = Convert.ToDouble(DepositAmountTextbox.Text);

                    string field = "Deposit";

                    string mySQL = string.Empty;
                    mySQL += "SELECT * FROM Customer_Details ";
                    mySQL += "UPDATE [dbo].[Customer_Details]";
                    mySQL += "SET [Total_Money] = '" + (depositamount + DepositBalance()) + "'";
                    mySQL += "WHERE FUser_Name = '" + UserName + "'";

                    string mySQL2 = string.Empty;
                    DateTime dateTimeVariable = DateTime.Now;
                    mySQL2 += "SELECT * FROM Customer_Details ";
                    mySQL2 += "UPDATE [dbo].[Customer_Details]";
                    mySQL2 += "SET [DDate_Time] = '" + dateTimeVariable + "'";
                    mySQL2 += "WHERE FUser_Name = '" + UserName + "'";

                    string mySQL3 = string.Empty;

                    mySQL3 += @"INSERT INTO [dbo].[Transation_History]
                           ([TUser_name]
                           ,[Amount]
                           ,[Field]
                           ,[Date])
                     VALUES
                           ('" + UserName + "', '" + depositamount + "', '" + field + "', '" + dateTimeVariable + "')";

                    DataTable userData = ServerConnection.executeSQL(mySQL);
                    DataTable userData2 = ServerConnection.executeSQL(mySQL2);
                    DataTable userData3 = ServerConnection.executeSQL(mySQL3);

                    string from, pass, messageBody;
                    Random rand = new Random();
                    MailMessage message = new MailMessage();
                    to = GetEmail();
                    from = "nadim.hossain193@gmail.com";
                    pass = "nadim1155";
                    messageBody = "Deposit Amount : " + depositamount + "    Your Balance is : " + DepositBalance();
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

                    MessageBox.Show("DEPOSIT SUCCESSFULL", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string mySQL1 = string.Empty;
                    mySQL1 += "SELECT * FROM Customer_Details ";
                    mySQL1 += "UPDATE [dbo].[Customer_Details]";
                    mySQL1 += "SET [Deposit_Money] = '" + depositamount + "'";
                    mySQL1 += "WHERE FUser_Name = '" + UserName + "'";

                    DataTable userData1 = ServerConnection.executeSQL(mySQL1);

                    string mySQL4 = string.Empty;
                    mySQL4 += "SELECT * FROM Current_Transation_Details ";
                    mySQL4 += "UPDATE [dbo].[Current_Transation_Details]";
                    mySQL4 += "SET [Current_Deposit_balance] = '" + DepositCurrentBalancelabel.Text + "'";
                    mySQL4 += "WHERE CUser_Name = '" + UserName + "'";

                    DataTable userData4 = ServerConnection.executeSQL(mySQL4);
                }
            }
            else
            {
                MessageBox.Show("User Name Or Password Incorrect ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DepositPasswordpanel.Enabled = false;
                DepositUserNamepanel.Enabled = true;
            }
        }

        private void GetFirstName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT First_Name FROM Parsonal WHERE User_Name = '" + UserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            DepositFirstNamelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void DepositFirstNamepanel_Paint(object sender, PaintEventArgs e)
        {
            GetFirstName();
        }

        private void GetLastName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Last_Name FROM Parsonal WHERE User_Name = '" + UserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            DepositLastNamelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void DepositLastNamepanel_Paint(object sender, PaintEventArgs e)
        {
            GetLastName();
        }

        private void GetDepositBalance()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Total_Money FROM Customer_Details WHERE FUser_Name = '" + UserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            DepositCurrentBalancelabel.Text = (data.Rows[0][0]).ToString();
            SqlConnection.Close();
        }

        private void DepositBalancepanel_Paint(object sender, PaintEventArgs e)
        {
            GetDepositBalance();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DepositAmountTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(ch == 46 && DepositAmountTextbox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if(!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Enter Valide Number.");
                DepositAmountTextbox.Clear();
            }
        }
    }
}
