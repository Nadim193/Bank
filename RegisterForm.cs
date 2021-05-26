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
    public partial class RegisterForm : Form
    {
        string randomCode;
        public static string to;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            UsernameTextbox.Select();
        }

        private void ShowRememberPasswordcheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ShowRememberPasswordcheckBox.Checked == true)
            {
                ConfirmPasswordtextBox.UseSystemPasswordChar = false;
            }
            else
            {
                ConfirmPasswordtextBox.UseSystemPasswordChar = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsernameTextbox.Text.Equals("") || FirstNametextBox.Text.Equals("") || LastNametextBox.Text.Equals("") || YearcomboBox.SelectedItem.Equals("") || MonthcomboBox.SelectedItem.Equals("") || DatecomboBox.SelectedItem.Equals("") || EmailAdressTxtbox.Text.Equals("")
                    || AddresstextBox.Text.Equals("") || CitytextBox.Text.Equals("") || CountrytextBox.Text.Equals("") || PasswordtextBox.Text.Equals("") || ConfirmPasswordtextBox.Text.Equals("") || ReligioncomboBox.SelectedItem.Equals("") || CategorycomboBox.SelectedItem.Equals("")
                    || IncomecomboBox.SelectedItem.Equals("") || QualificationcomboBox.SelectedItem.Equals("") || OccupationcomboBox.SelectedItem.Equals(""))
                {
                    MessageBox.Show("Fill All The Requried Field.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UsernameTextbox.Select();
                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
                    "Initial Catalog = BankSystemDataBase; Integrated Security = True");

                    string mySQL = string.Empty;

                    String Gender = "";
                    if (MaleradioButton.Checked)
                    {
                        Gender = "Male";
                    }
                    else if (FemaleradioButton.Checked)
                    {
                        Gender = "Female";
                    }
                    else if (OtherradioButton.Checked)
                    {
                        Gender = "Other";
                    }

                    String Marital = "";

                    if (MarriedradioButton.Checked)
                    {
                        Marital = "Married";
                    }
                    else if (UnmarriedradioButton.Checked)
                    {
                        Marital = "Unmarried";
                    }

                    String Account = "";

                    if (SavingradioButton.Checked)
                    {
                        Account = "Saving Account";
                    }
                    else if (CurrentradioButton.Checked)
                    {
                        Account = "Current Account";
                    }
                    else if (FixedDepositradioButton.Checked)
                    {
                        Account = "Fixed Deposit Account";
                    }
                    else if (RecurringDepositradioButton.Checked)
                    {
                        Account = "Recurring Deposit Account";
                    }
                    else
                    {
                        Account = "None";
                    }

                    mySQL += @"INSERT INTO [dbo].[Parsonal]
                               ([User_name]
                               ,[Password]
                               ,[First_Name]
                               ,[Last_Name]
                               ,[Email_address]
                               ,[Gender]
                               ,[Date_Of_Birth]
                               ,[Marital_Status]
                               ,[Address]
                               ,[City]
                               ,[Country]
                               ,[Religion]
                               ,[Category]
                               ,[Income]
                               ,[Educational_Qualification]
                               ,[Occupation]
                               ,[Account_Type])
                         VALUES
                                ('" + UsernameTextbox.Text +"', '" + PasswordtextBox.Text +"', '" + FirstNametextBox.Text + "', '" + LastNametextBox.Text + "', '" + EmailAdressTxtbox.Text + "', '" + Gender + "', '" + YearcomboBox.SelectedItem + "-" + MonthcomboBox.SelectedItem + "-" + DatecomboBox.SelectedItem + "'" +
                            ", '" + Marital + "', '" + AddresstextBox.Text + "', '" + CitytextBox.Text + "', '" + CountrytextBox.Text + "', '" + ReligioncomboBox.SelectedItem + "', '" + CategorycomboBox.SelectedItem + "', '" + IncomecomboBox.SelectedItem + "'" +
                            ", '" + QualificationcomboBox.SelectedItem + "', '" + OccupationcomboBox.SelectedItem + "', '" + Account +"')";

                    if (PasswordtextBox.Text == ConfirmPasswordtextBox.Text)
                    {
                        string mySQL1 = string.Empty;
                        string mySQL3 = string.Empty;

                        mySQL1 += "SELECT * FROM Parsonal ";
                        mySQL1 += "WHERE User_name = '" + UsernameTextbox.Text + "' ";

                        mySQL3 += "SELECT * FROM Parsonal ";
                        mySQL3 += "WHERE Email_address = '" + EmailAdressTxtbox.Text + "' ";

                        DataTable userData2 = ServerConnection.executeSQL(mySQL1);

                        DataTable userData3 = ServerConnection.executeSQL(mySQL3);

                        if (userData2.Rows.Count > 0)
                        {
                            MessageBox.Show("User Name " + UsernameTextbox.Text + " Is Already Exist. Try Another One.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            UsernameTextbox.Clear();
                            UsernameTextbox.Select();

                        }
                        else if(userData3.Rows.Count > 0)
                        {
                            MessageBox.Show("Email Address is Already Used.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EmailAdressTxtbox.Clear();
                            EmailAdressTxtbox.Select();
                        }
                        else
                        {
                            DataTable userData1 = ServerConnection.executeSQL(mySQL);

                            try
                            {

                                string from, pass, messageBody;
                                Random rand = new Random();
                                randomCode = (rand.Next(99999)).ToString();
                                MailMessage message = new MailMessage();
                                to = (EmailAdressTxtbox.Text).ToString();
                                from = "nadim.hossain193@gmail.com";
                                pass = "nadim1155";
                                messageBody = "Your Verification Code Is " + randomCode;
                                message.To.Add(to);
                                message.From = new MailAddress(from);
                                message.Body = messageBody;
                                message.Subject = "Account Verification Code.";
                                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                                {
                                    smtp.Credentials = new NetworkCredential(from, pass);
                                    smtp.EnableSsl = true;

                                    if (EmailAdressTxtbox != null)
                                    {
                                            smtp.Send(message);
                                            MessageBox.Show("Please Check Your Email And Enter The Code.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            string mySQL4 = string.Empty;
                                            mySQL4 += @"INSERT INTO[dbo].[Random]
                                            ([Random_code])
                                                 VALUES
                                                       ('" + randomCode + "')";

                                            DataTable userData4 = ServerConnection.executeSQL(mySQL4);

                                            AccountVerifyForm accountVerify = new AccountVerifyForm();
                                            this.Hide();
                                            accountVerify.ShowDialog();
                                            this.Close();
                                            conn.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalide Email Address. Enter Valide Email address.",
                                        "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Please Enter Email Address.",
                                        "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Password Do Not Match. Enter Same Password.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PasswordtextBox.Clear();
                        ConfirmPasswordtextBox.Clear();
                        PasswordtextBox.Select();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void RegistrationBackbutton_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
