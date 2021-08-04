using Bank.Connection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.IO;

namespace Bank
{
    public partial class RegisterForm : Form
    {
        public static String RegPassword;
        public static String regUserName;
        public static String regEmail;
        public static string Active;
        string randomCode;
        public static string to;
        string imgLocation = "";
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            UsernameTextbox.Select();
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Active = "Active";
                regUserName = UsernameTextbox.Text;
                RegPassword = ConfirmPasswordtextBox.Text;
                regEmail = EmailAdressTxtbox.Text;

                if (regUserName.Equals("") || FirstNametextBox.Text.Equals("") || LastNametextBox.Text.Equals("")|| DOBDateTimePicker.Equals("") || regEmail.Equals("")
                    || AddresstextBox.Text.Equals("") || CitytextBox.Text.Equals("") || CountrytextBox.Text.Equals("") || PasswordtextBox.Text.Equals("") || RegPassword.Equals("") || ReligioncomboBox.SelectedItem.Equals("") || IncomecomboBox.SelectedItem.Equals("") || QualificationcomboBox.SelectedItem.Equals("") || OccupationcomboBox.SelectedItem.Equals(""))
                {
                    MessageBox.Show("Fill All The Requried Field.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UsernameTextbox.Select();
                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
                    "Initial Catalog = BankSystemDataBase; Integrated Security = True");
                    

                    string mySQL = string.Empty;
                    string mySQL5 = string.Empty;
                    string mySQL6 = string.Empty;

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

                    string Account = "";

                    if (SavingradioButton.Checked)
                    {
                        Account = "Saving Account";
                    }
                    else if (CurrentradioButton.Checked)
                    {
                        Account = "Current Account";
                    }
                    else
                    {
                        Account = "None";
                    }

                    byte[] image = null;
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binary = new BinaryReader(stream);
                    image = binary.ReadBytes((int)stream.Length);

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
                               ,[Income]
                               ,[Educational_Qualification]
                               ,[Occupation]
                               ,[Account_Type]
                               ,[Profile_picture]
                               ,[Status])
                         VALUES
                                ('" + UsernameTextbox.Text +"', '" + PasswordtextBox.Text +"', '" + FirstNametextBox.Text + "', '" + LastNametextBox.Text + "', '" + regEmail + "', '" + Gender + "', '" + DOBDateTimePicker.Value + "'" +
                            ", '" + Marital + "', '" + AddresstextBox.Text + "', '" + CitytextBox.Text + "', '" + CountrytextBox.Text + "', '" + ReligioncomboBox.SelectedItem + "', '" + IncomecomboBox.SelectedItem + "'" +
                            ", '" + QualificationcomboBox.SelectedItem + "', '" + OccupationcomboBox.SelectedItem + "', '" + Account + "', @image, '" + Active + "')";
                    
                    if(conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlCommand command = new SqlCommand(mySQL, conn);
                    command.Parameters.AddWithValue("@image", image);

                    double Totalmoney = 0.00;
                    double Withdraw = 0.00;
                    double deposit = 0.00;
                    double transationmoney = 0.00;
                    string transatioTo = null;

                    if(Account == "Saving Account")
                    {
                        DateTime dateTimeVariable = DateTime.Now;

                        mySQL5 += @"INSERT INTO [dbo].[Customer_Details]
                               ([FUser_Name]
                               ,[Total_Money]
                               ,[Withdraw_Money]
                               ,[Deposit_Money]
                               ,[Transation_Money]
                               ,[Transation_To]
                               ,[WDate_Time]
                               ,[DDate_Time]
                               ,[TDate_Time]
                                ,[Saving_Time])
                         VALUES
                               ('" + UsernameTextbox.Text + "', '" + Totalmoney + "', '" + Withdraw + "', '" + deposit + "', '" + transationmoney + "', '" + transatioTo + "', '" + dateTimeVariable + "', '" + dateTimeVariable + "', '" + dateTimeVariable + "', '" + SavingAccountDateTimePicker.Value +"')";
                    }
                    else
                    {
                        DateTime dateTimeVariable = DateTime.Now;
                        
                        mySQL5 += @"INSERT INTO [dbo].[Customer_Details]
                               ([FUser_Name]
                               ,[Total_Money]
                               ,[Withdraw_Money]
                               ,[Deposit_Money]
                               ,[Transation_Money]
                               ,[Transation_To]
                               ,[WDate_Time]
                               ,[DDate_Time]
                               ,[TDate_Time]
                                ,[Saving_Time])
                         VALUES
                               ('" + UsernameTextbox.Text + "', '" + Totalmoney + "', '" + Withdraw + "', '" + deposit + "', '" + transationmoney + "', '" + transatioTo + "', '" + dateTimeVariable + "', '" + dateTimeVariable + "', '" + dateTimeVariable + "')";
                    }

                    double Cdepositbalance = 0.00;
                    double Cwithdrawbalance = 0.00;
                    double Ctransferbalance = 0.00;

                    mySQL6 += @"INSERT INTO [dbo].[Current_Transation_Details]
                               ([CUser_Name]
                               ,[Current_Deposit_balance]
                               ,[Current_Withdraw_balance]
                               ,[Current_Transfer_balance])
                         VALUES
                               ('" + UsernameTextbox.Text + "', '" + Cdepositbalance + "', '" + Cwithdrawbalance + "', '" + Ctransferbalance + "')";

                    if (PasswordtextBox.Text == RegPassword)
                    {
                        string mySQL1 = string.Empty;
                        string mySQL3 = string.Empty;

                        mySQL1 += "SELECT * FROM Parsonal ";
                        mySQL1 += "WHERE User_name = '" + UsernameTextbox.Text + "' ";

                        mySQL3 += "SELECT * FROM Parsonal ";
                        mySQL3 += "WHERE Email_address = '" + regEmail + "' ";

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
                            PictureBox.Image = null;

                            command.ExecuteNonQuery();
                            DataTable userData5 = ServerConnection.executeSQL(mySQL5);
                            DataTable userData6 = ServerConnection.executeSQL(mySQL6);

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
                                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
            }
        }

        private void cerraricon_Click(object sender, EventArgs e)
        {
            CloseForm close = new CloseForm();
            close.ShowDialog();
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

        private void RestoreDownIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            RestoreDownIcon.Visible = false;
            maxIcon.Visible = true;
        }

        private void FileChooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All file(*.*)|*.*|png file(*.png)|*.png|jpg file(*.jpg)|*.jpg";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                PictureBox.ImageLocation = imgLocation;
            }
        }

        private void BackToLoginlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowRememberPasswordcheckBox_CheckedChanged(object sender, EventArgs e)
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

        private void SavingDate()
        {
            if (SavingradioButton.Checked)
            {
                Yearlabel.Visible = true;
                SavingAccountDateTimePicker.Visible = true;
            }
            else
            {
                Yearlabel.Visible = false;
                SavingAccountDateTimePicker.Visible = false;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            SavingDate();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
