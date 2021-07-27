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
        public static string verifyname;
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
                        mySQL += "WHERE User_name = '" + VerityUserNametextBox.Text + "' " +
                            "AND Email_address = '" + emailtextBox.Text + "'";

                        /*mySQL1 += "SELECT * FROM Parsonal ";
                        mySQL1 += "WHERE Email_address = '" + emailtextBox.Text + "' ";*/

                        //DataTable userData1 = ServerConnection.executeSQL(mySQL1);
                        DataTable userData = ServerConnection.executeSQL(mySQL);

                        if (userData.Rows.Count > 0)
                        {
                            smtp.Send(message);
                            MessageBox.Show("Please Check Your Email And Enter The Code.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VerifyUserNameLable.Enabled = false;
                            VerityUserNametextBox.Enabled = false;
                            VerifyEmailLable.Enabled = false;
                            emailtextBox.Enabled = false;
                            SentOTPButton.Enabled = false;

                            OTPLable.Enabled = true;
                            CodetextBox.Enabled = true;
                            Verifybutton.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Your Information Don't Match. Try Again Or Created An Account ",
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
                MessageBox.Show(ex.Message);

            }
        }

        private void Verifybutton_Click(object sender, EventArgs e)
        {
            if (randomCode == (CodetextBox.Text).ToString())
            {
                verifyname = VerityUserNametextBox.Text;
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
