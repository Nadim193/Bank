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
    public partial class DisableSureForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        public static string randomCode;
        public static string to;
        string username = LoginForm.user;

        public DisableSureForm()
        {
            InitializeComponent();
        }

        private void cerraricon_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
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

        private void AccountDisableButton_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(99999)).ToString();
            MailMessage message = new MailMessage();
            to = GetMail();
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

                smtp.Send(message);
                MessageBox.Show("Please Check Your Email And Enter The Code.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableVerifyForm verifyForm = new DisableVerifyForm();
                this.Hide();
                verifyForm.ShowDialog();
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
