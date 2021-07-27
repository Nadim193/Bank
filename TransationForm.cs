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
    public partial class TransationForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        string UserName = LoginForm.user;
        string Password = LoginForm.Password;
        string to;
        public TransationForm()
        {
            InitializeComponent();
        }

        private void TransationForm_Load(object sender, EventArgs e)
        {

        }

        private void FromTransationUsenamebutton_Click(object sender, EventArgs e)
        {
            ToTransationUserNamepanel.Enabled = true;
            ToTransationUserNameTextbox.Select();
            FramTransationUserNamepanel.Enabled = false;
        }

        private string GetFirstTOName()
        {
            SqlConnection.Open();
            string ToFirstName;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT First_Name FROM Parsonal WHERE User_Name = '" + ToTransationUserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            ToFirstName = data.Rows[0][0].ToString();
            SqlConnection.Close();

            return ToFirstName;
        }

        private string GetLastTOName()
        {
            SqlConnection.Open();
            string ToLastName;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Last_Name FROM Parsonal WHERE User_Name = '" + ToTransationUserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            ToLastName = data.Rows[0][0].ToString();
            SqlConnection.Close();

            return ToLastName;
        }

        private string GetAddressTOName()
        {
            SqlConnection.Open();
            string ToAddress;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Address FROM Parsonal WHERE User_Name = '" + ToTransationUserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            ToAddress = data.Rows[0][0].ToString();
            SqlConnection.Close();

            return ToAddress;
        }



        private void ToTransationUserNamebutton_Click(object sender, EventArgs e)
        {
            string mySQL = string.Empty;
            mySQL += "SELECT * FROM Parsonal ";
            mySQL += "WHERE User_name = '" + ToTransationUserNameTextbox.Text + "'";


            DataTable userData = ServerConnection.executeSQL(mySQL);

            if (userData.Rows.Count > 0)
            {
                TOParsonalFirstNamelabel.Text = GetFirstTOName();
                TOParsonalLastNamelabel.Text = GetLastTOName();
                TOParsonalAddresslabel.Text = GetAddressTOName();
                Transationpanel.Enabled = true;
                TransationAmountTextbox.Select();
                ToTransationUserNamepanel.Enabled = false;
            }
            else
            {
                MessageBox.Show("This account is not existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ToTransationUserNamepanel.Enabled = true;
                Transationpanel.Enabled = false;
            }
        }

        private void TransationAmountbutton_Click(object sender, EventArgs e)
        {
            TransationPasswordpanel.Enabled = true;
            PasswordTextbox.Select();
            Transationpanel.Enabled = false;
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

        private String GetAccountStstus()
        {
            SqlConnection.Open();
            string Status;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Status FROM Parsonal WHERE User_Name = '" + ToTransationUserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            Status = (data.Rows[0][0]).ToString();
            SqlConnection.Close();

            return Status;
        }

        private double FromTotalBalance()
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

        private double ToTotalBalance()
        {
            SqlConnection.Open();
            double balance;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Total_Money FROM Customer_Details WHERE FUser_Name = '" + ToTransationUserNameTextbox.Text + "'", SqlConnection);
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

        private void Transationbutton_Click(object sender, EventArgs e)
        {
            if(FromTransationUserNameTextbox.Text == UserName && PasswordTextbox.Text == Password)
            {
                double transferamount = Convert.ToDouble(TransationAmountTextbox.Text);
                string AccountStatus = "Active";
                string AccountType = "Current Account";

                string checknull = "Null";
                string mySQL9 = string.Empty;
                mySQL9 += "SELECT Email_address FROM Parsonal ";
                mySQL9 += "WHERE User_name = '" + UserName + "'";
                mySQL9 += "AND Email_address = '" + checknull + "'";

                DataTable userData9 = ServerConnection.executeSQL(mySQL9);

                if (AccountStatus == GetAccountStstus())
                {
                    if(transferamount <= FromTotalBalance())
                    {
                        if(AccountType == GetAccountType())
                        {
                            if (userData9.Rows.Count > 0)
                            {
                                AlertForm alert = new AlertForm();
                                alert.ShowDialog();
                            }
                            else
                            {
                                string field = "Transfer";

                                string mySQL1 = string.Empty;
                                mySQL1 += "SELECT * FROM Customer_Details ";
                                mySQL1 += "UPDATE [dbo].[Customer_Details]";
                                mySQL1 += "SET [Total_Money] = '" + (FromTotalBalance() - transferamount) + "'";
                                mySQL1 += "WHERE FUser_Name = '" + UserName + "'";

                                string mySQL2 = string.Empty;
                                mySQL2 += "SELECT * FROM Customer_Details ";
                                mySQL2 += "UPDATE [dbo].[Customer_Details]";
                                mySQL2 += "SET [Total_Money] = '" + (ToTotalBalance() + transferamount) + "'";
                                mySQL2 += "WHERE FUser_Name = '" + ToTransationUserNameTextbox.Text + "'";

                                string mySQL3 = string.Empty;
                                DateTime dateTimeVariable = DateTime.Now;
                                mySQL3 += "SELECT * FROM Customer_Details ";
                                mySQL3 += "UPDATE [dbo].[Customer_Details]";
                                mySQL3 += "SET [TDate_Time] = '" + dateTimeVariable + "'";
                                mySQL3 += "WHERE FUser_Name = '" + UserName + "'";

                                string mySQL4 = string.Empty;
                                mySQL4 += "SELECT * FROM Customer_Details ";
                                mySQL4 += "UPDATE [dbo].[Customer_Details]";
                                mySQL4 += "SET [Transation_Money] = '" + transferamount + "'";
                                mySQL4 += "WHERE FUser_Name = '" + UserName + "'";

                                string mySQL5 = string.Empty;
                                mySQL5 += "SELECT * FROM Customer_Details ";
                                mySQL5 += "UPDATE [dbo].[Customer_Details]";
                                mySQL5 += "SET [Transation_To] = '" + ToTransationUserNameTextbox.Text + "'";
                                mySQL5 += "WHERE FUser_Name = '" + UserName + "'";

                                string mySQL6 = string.Empty;
                                mySQL6 += "SELECT * FROM Current_Transation_Details ";
                                mySQL6 += "UPDATE [dbo].[Current_Transation_Details]";
                                mySQL6 += "SET [Current_Transfer_balance] = '" + FromParsonalBalancelabel.Text + "'";
                                mySQL6 += "WHERE CUser_Name = '" + UserName + "'";

                                string mySQL7 = string.Empty;

                                mySQL7 += @"INSERT INTO [dbo].[Transation_History]
                                       ([TUser_name]
                                       ,[Amount]
                                       ,[Field]
                                       ,[Date]
                                       ,[Transfer_To])
                                 VALUES
                                       ('" + UserName + "', '" + transferamount + "', '" + field + "', '" + dateTimeVariable + "', '" + ToTransationUserNameTextbox.Text + "')";

                                DataTable userData1 = ServerConnection.executeSQL(mySQL1);
                                DataTable userData2 = ServerConnection.executeSQL(mySQL2);
                                DataTable userData3 = ServerConnection.executeSQL(mySQL3);
                                DataTable userData4 = ServerConnection.executeSQL(mySQL4);
                                DataTable userData5 = ServerConnection.executeSQL(mySQL5);
                                DataTable userData6 = ServerConnection.executeSQL(mySQL6);
                                DataTable userData7 = ServerConnection.executeSQL(mySQL7);

                                string from, pass, messageBody;
                                Random rand = new Random();
                                MailMessage message = new MailMessage();
                                to = GetEmail();
                                from = "nadim.hossain193@gmail.com";
                                pass = "nadim1155";
                                messageBody = "Transfer Amount : " + transferamount +
                                    "   Your Balance is : " + FromTotalBalance() +
                                    "   Money Transfer To " + ToTransationUserNameTextbox.Text;
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

                                MessageBox.Show("TRANSFER SUCCESSFULL", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("You can't Transfer Money. Because This Account is a Saving Account ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Balance", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Transationpanel.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("This Account Is Not Active", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ToTransationUserNamepanel.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("User Name Or Password Incorrect ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FramTransationUserNamepanel.Enabled = true;
                TransationPasswordpanel.Enabled = false;
            }
        }

        private void GetFirstName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT First_Name FROM Parsonal WHERE User_Name = '" + UserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            FromParsonalFirstNamlabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void FromParsonalFirstNamepanel_Paint(object sender, PaintEventArgs e)
        {
            GetFirstName();
        }

        private void GetLastName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Last_Name FROM Parsonal WHERE User_Name = '" + UserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            FromParsonalLastNamlabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void FromParsonalLastNamepanel_Paint(object sender, PaintEventArgs e)
        {
            GetLastName();
        }

        private void GetTotalBalance()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Total_Money FROM Customer_Details WHERE FUser_Name = '" + UserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            FromParsonalBalancelabel.Text = (data.Rows[0][0]).ToString();
            SqlConnection.Close();
        }

        private void FromParsonalBalancepanel_Paint(object sender, PaintEventArgs e)
        {
            GetTotalBalance();
        }
    }
}
