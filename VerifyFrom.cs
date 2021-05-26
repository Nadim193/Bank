using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using Bank.Connection;

namespace Bank
{
    public partial class VerifyFrom : Form
    {
        string randomCode;
        public static string to; 
        public VerifyFrom()
        {
            InitializeComponent();
        }

        private void Sentbutton_Click(object sender, EventArgs e)
        {
            try
            {

                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(99999)).ToString();
                MailMessage message = new MailMessage();
                to = (emailtextBox.Text).ToString();
                from = "nadim.hossain193@gmail.com";
                pass = "nadim1155";
                messageBody = "Your Reset Code Is " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Password Change Request";
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(from, pass);
                    smtp.EnableSsl = true;

                    SqlConnection conn = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
                    "Initial Catalog = BankSystemDataBase; Integrated Security = True");

                    if (!string.IsNullOrEmpty(VerityUserNametextBox.Text))
                    {
                        string mySQL = string.Empty;
                        string mySQL1 = string.Empty;

                        mySQL += "SELECT * FROM Parsonal ";
                        mySQL += "WHERE User_name = '" + VerityUserNametextBox.Text + "' ";

                        mySQL1 += "SELECT * FROM Parsonal ";
                        mySQL1 += "WHERE Email_address = '" + emailtextBox.Text + "' ";

                        DataTable userData1 = ServerConnection.executeSQL(mySQL1);
                        DataTable userData = ServerConnection.executeSQL(mySQL);

                        if (userData.Rows.Count > 0 && userData1.Rows.Count > 0)
                        {
                            smtp.Send(message);
                            MessageBox.Show("Please Check Your Email And Enter The Code.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CodetextBox.Select();
                        }
                        else
                        {
                            MessageBox.Show("Your Information Don't Match. PLease Created An Account ",
                            "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VerityUserNametextBox.Clear();
                            emailtextBox.Clear();
                            VerityUserNametextBox.Select();
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter User Name And Email Address.",
                    "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                VerityUserNametextBox.Clear();
                emailtextBox.Clear();
                VerityUserNametextBox.Select();
            }
        }

        private void Verifybutton_Click(object sender, EventArgs e)
        {
            if (randomCode == (CodetextBox.Text).ToString())
            {
                to = emailtextBox.Text;
                ForgetPassword fp = new ForgetPassword();
                this.Hide();
                fp.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Code.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void VerifyFrom_Load(object sender, EventArgs e)
        {
            VerityUserNametextBox.Select();
        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void verifyBackbutton_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.ShowDialog();
            this.Close();
        }
    }
}
