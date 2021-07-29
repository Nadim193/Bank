using Bank.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class EditProfileForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        string LoginUserName = LoginForm.user;
        string LoginPassword = LoginForm.Password;
        public static string randomCode;
        string to;

        public static string emailaddress;
        string imgLocation = "";

        public EditProfileForm()
        {
            InitializeComponent();
        }

        private void GetFirstName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT First_Name FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            FirstNameTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void FirstNamepanel_Paint(object sender, PaintEventArgs e)
        {
            GetFirstName();
        }

        private void GetLastName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Last_Name FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            LastNameTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void LastNamepanel_Paint(object sender, PaintEventArgs e)
        {
            GetLastName();
        }

        private void GetDOB()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Date_Of_Birth FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            DOBDateTimePicker.Value = Convert.ToDateTime(data.Rows[0][0]);
            SqlConnection.Close();
        }

        private void DOBpanel_Paint(object sender, PaintEventArgs e)
        {
            GetDOB();
        }

        private void GetGender()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Gender FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            GendeTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void Genderpanel_Paint(object sender, PaintEventArgs e)
        {
            GetGender();
        }

        private void GetEmail()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Email_address FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            EmailTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }
        private void Emailpanel_Paint(object sender, PaintEventArgs e)
        {
             GetEmail();
        }

        private void GetMarital()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Marital_Status FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            MaritalTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void Maritalpanel_Paint(object sender, PaintEventArgs e)
        {
            GetMarital();
        }

        private void GetAddress()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Address FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            AddressTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void Addresspanel_Paint(object sender, PaintEventArgs e)
        {
            GetAddress();
        }

        private void GetCity()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT City FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            CityTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void CityPanel_Paint(object sender, PaintEventArgs e)
        {
            GetCity();
        }

        private void GetCountry()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Country FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            CountryTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void Countrypanel_Paint(object sender, PaintEventArgs e)
        {
            GetCountry();
        }

        private void GetReligion()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Religion FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            ReligionTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void Religionpanel_Paint(object sender, PaintEventArgs e)
        {
            GetReligion();
        }

        private void GetIncome()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Income FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            IncomeTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void Incomepanel_Paint(object sender, PaintEventArgs e)
        {
            GetIncome();
        }

        private void GetEQ()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Educational_Qualification FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            EQTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void EQpanel_Paint(object sender, PaintEventArgs e)
        {
            GetEQ();
        }

        private void GetOccupation()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Occupation FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            OccupationTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void Occupationpanel_Paint(object sender, PaintEventArgs e)
        {
            GetOccupation();
        }

        private void GetAccountType()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Account_Type FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            AccountTypelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void AccountTypepanel_Paint(object sender, PaintEventArgs e)
        {
            GetAccountType();
        }

        private string GetVerifyEmail()
        {
            SqlConnection.Open();
            string email;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Email_address FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            email = data.Rows[0][0].ToString();
            SqlConnection.Close();

            return email;
        }

        private void ProfilePictureUpdateButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All file(*.*)|*.*|png file(*.png)|*.png|jpg file(*.jpg)|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                ProfilePictureBox.ImageLocation = imgLocation;
            }
        }

        private void GetProfilePicture()
        {
            string Sql = "SELECT Profile_picture FROM Parsonal WHERE User_Name = '" + LoginUserName + "'";
            if (SqlConnection.State != ConnectionState.Open)
                SqlConnection.Open();
            SqlCommand command = new SqlCommand(Sql, SqlConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                byte[] img = (byte[])(dataReader[0]);

                if (img == null)
                {
                    ProfilePictureBox.Image = null;

                }
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    ProfilePictureBox.Image = Image.FromStream(ms);
                }
            }
            else
            {
                MessageBox.Show("This is Not Exist");
            }
            SqlConnection.Close();
        }

        private void Picturepanel_Paint(object sender, PaintEventArgs e)
        {
            GetProfilePicture();
        }

        private string GetProfilePicture1()
        {
            string Sql = "SELECT Profile_picture FROM Parsonal WHERE User_Name = '" + LoginUserName + "'";
            if (SqlConnection.State != ConnectionState.Open)
                SqlConnection.Open();
            SqlCommand command = new SqlCommand(Sql, SqlConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();
            string profile = ProfilePictureBox.Image.ToString();
            if (dataReader.HasRows)
            {
                byte[] img = (byte[])(dataReader[0]);
                MemoryStream ms = new MemoryStream(img);
                profile = Image.FromStream(ms).ToString();
            }
            else
            {
                MessageBox.Show("This is Not Exist");
            }
            SqlConnection.Close();

            return profile;
        }


        private void ProfileUpdateButton_Click_1(object sender, EventArgs e)
        {
            emailaddress = EmailTextBox.Text;

            if (emailaddress.Equals("") || FirstNameTextBox.Text.Equals("") || LastNameTextBox.Text.Equals("")
                || DOBDateTimePicker.Equals("") || GendeTextBox.Text.Equals("") || MaritalTextBox.Text.Equals("")
                || AddressTextBox.Text.Equals("") || CityTextBox.Text.Equals("") || CountryTextBox.Text.Equals("")
                || ReligionTextBox.Text.Equals("") || IncomeTextBox.Text.Equals("") || EQTextBox.Text.Equals("")
                || OccupationTextBox.Text.Equals("") || ProfilePictureBox.Image.Equals(""))
            {
                MessageBox.Show("Fill All The Required Field ", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (emailaddress == GetVerifyEmail())
                {
                    if(ProfilePictureBox.Image.ToString() == GetProfilePicture1())
                    {
                        string mySQL2 = string.Empty;
                        mySQL2 += "SELECT * FROM Parsonal ";
                        mySQL2 += "UPDATE [dbo].[Parsonal]";
                        mySQL2 += "SET [First_Name] = '" + FirstNameTextBox.Text + "'" +
                                      ",[Last_Name] = '" + LastNameTextBox.Text + "'" +
                                      ",[Email_address] = '" + emailaddress + "'" +
                                      ",[Gender] = '" + GendeTextBox.Text + "'" +
                                      ",[Date_Of_Birth] = '" + DOBDateTimePicker.Value + "'" +
                                      ",[Marital_Status] = '" + MaritalTextBox.Text + "'" +
                                      ",[Address] = '" + AddressTextBox.Text + "'" +
                                      ",[City] = '" + CityTextBox.Text + "'" +
                                      ",[Country] = '" + CountryTextBox.Text + "'" +
                                      ",[Religion] = '" + ReligionTextBox.Text + "'" +
                                      ",[Income] = '" + IncomeTextBox.Text + "'" +
                                      ",[Educational_Qualification] = '" + EQTextBox.Text + "'" +
                                      ",[Occupation] = '" + OccupationTextBox.Text + "'";
                        mySQL2 += "WHERE User_Name = '" + LoginUserName + "'";

                        if (SqlConnection.State != ConnectionState.Open)
                            SqlConnection.Open();
                        SqlCommand command2 = new SqlCommand(mySQL2, SqlConnection);
                        command2.ExecuteNonQuery();

                        MessageBox.Show("Update Successfull", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(ProfilePictureBox.Image.ToString() != GetProfilePicture1())
                    {
                        byte[] image1 = null;
                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader binary = new BinaryReader(stream);
                        image1 = binary.ReadBytes((int)stream.Length);

                        string mySQL1 = string.Empty;
                        mySQL1 += "SELECT * FROM Parsonal ";
                        mySQL1 += "UPDATE [dbo].[Parsonal]";
                        mySQL1 += "SET [First_Name] = '" + FirstNameTextBox.Text + "'" +
                                      ",[Last_Name] = '" + LastNameTextBox.Text + "'" +
                                      ",[Email_address] = '" + emailaddress + "'" +
                                      ",[Gender] = '" + GendeTextBox.Text + "'" +
                                      ",[Date_Of_Birth] = '" + DOBDateTimePicker.Value + "'" +
                                      ",[Marital_Status] = '" + MaritalTextBox.Text + "'" +
                                      ",[Address] = '" + AddressTextBox.Text + "'" +
                                      ",[City] = '" + CityTextBox.Text + "'" +
                                      ",[Country] = '" + CountryTextBox.Text + "'" +
                                      ",[Religion] = '" + ReligionTextBox.Text + "'" +
                                      ",[Income] = '" + IncomeTextBox.Text + "'" +
                                      ",[Educational_Qualification] = '" + EQTextBox.Text + "'" +
                                      ",[Profile_picture] = @image1" +
                                      ",[Occupation] = '" + OccupationTextBox.Text + "'";
                        mySQL1 += "WHERE User_Name = '" + LoginUserName + "'";

                        if (SqlConnection.State != ConnectionState.Open)
                            SqlConnection.Open();
                        SqlCommand command1 = new SqlCommand(mySQL1, SqlConnection);
                        command1.Parameters.AddWithValue("@image1", image1);
                        command1.ExecuteNonQuery();

                        MessageBox.Show("Update Successfull", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        byte[] image = null;
                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader binary = new BinaryReader(stream);
                        image = binary.ReadBytes((int)stream.Length);

                        string mySQL = string.Empty;
                        mySQL += "SELECT * FROM Parsonal ";
                        mySQL += "UPDATE [dbo].[Parsonal]";
                        mySQL += "SET [First_Name] = '" + FirstNameTextBox.Text + "'" +
                                      ",[Last_Name] = '" + LastNameTextBox.Text + "'" +
                                      ",[Email_address] = '" + emailaddress + "'" +
                                      ",[Gender] = '" + GendeTextBox.Text + "'" +
                                      ",[Date_Of_Birth] = '" + DOBDateTimePicker.Value + "'" +
                                      ",[Marital_Status] = '" + MaritalTextBox.Text + "'" +
                                      ",[Address] = '" + AddressTextBox.Text + "'" +
                                      ",[City] = '" + CityTextBox.Text + "'" +
                                      ",[Country] = '" + CountryTextBox.Text + "'" +
                                      ",[Religion] = '" + ReligionTextBox.Text + "'" +
                                      ",[Income] = '" + IncomeTextBox.Text + "'" +
                                      ",[Educational_Qualification] = '" + EQTextBox.Text + "'" +
                                      ",[Profile_picture] = @image" +
                                      ",[Occupation] = '" + OccupationTextBox.Text + "'";
                        mySQL += "WHERE User_Name = '" + LoginUserName + "'";

                        if (SqlConnection.State != ConnectionState.Open)
                            SqlConnection.Open();
                        SqlCommand command = new SqlCommand(mySQL, SqlConnection);
                        command.Parameters.AddWithValue("@image", image);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Update Successfull", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (ProfilePictureBox.Image.ToString() == GetProfilePicture1())
                    {
                        string from1, pass1, messageBody1;
                        Random rand1 = new Random();
                        randomCode = (rand1.Next(99999)).ToString();
                        MailMessage message1 = new MailMessage();
                        to = (EmailTextBox.Text).ToString();
                        from1 = "nadim.hossain193@gmail.com";
                        pass1 = "nadim1155";
                        messageBody1 = "Your Verification Code Is " + randomCode;
                        message1.To.Add(to);
                        message1.From = new MailAddress(from1);
                        message1.Body = messageBody1;
                        message1.Subject = "Email Verification Code.";
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.Credentials = new NetworkCredential(from1, pass1);
                            smtp.EnableSsl = true;

                            if (emailaddress.Equals("") || FirstNameTextBox.Text.Equals("") || LastNameTextBox.Text.Equals("")
                            || DOBDateTimePicker.Value.Equals("") || GendeTextBox.Text.Equals("") || MaritalTextBox.Text.Equals("")
                            || AddressTextBox.Text.Equals("") || CityTextBox.Text.Equals("") || CountryTextBox.Text.Equals("")
                            || ReligionTextBox.Text.Equals("") || IncomeTextBox.Text.Equals("") || EQTextBox.Text.Equals("")
                            || OccupationTextBox.Text.Equals("") || ProfilePictureBox.Image.Equals(""))
                            {
                                MessageBox.Show("Fill All The Required Field ", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                smtp.Send(message1);
                                MessageBox.Show("Please Check Your Email And Enter The Code.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                string mySQL3 = string.Empty;
                                mySQL3 += "SELECT * FROM Parsonal ";
                                mySQL3 += "UPDATE [dbo].[Parsonal]";
                                mySQL3 += "SET [First_Name] = '" + FirstNameTextBox.Text + "'" +
                                              ",[Last_Name] = '" + LastNameTextBox.Text + "'" +
                                              ",[Email_address] = '" + emailaddress + "'" +
                                              ",[Gender] = '" + GendeTextBox.Text + "'" +
                                              ",[Date_Of_Birth] = '" + DOBDateTimePicker.Value + "'" +
                                              ",[Marital_Status] = '" + MaritalTextBox.Text + "'" +
                                              ",[Address] = '" + AddressTextBox.Text + "'" +
                                              ",[City] = '" + CityTextBox.Text + "'" +
                                              ",[Country] = '" + CountryTextBox.Text + "'" +
                                              ",[Religion] = '" + ReligionTextBox.Text + "'" +
                                              ",[Income] = '" + IncomeTextBox.Text + "'" +
                                              ",[Educational_Qualification] = '" + EQTextBox.Text + "'" +
                                              ",[Occupation] = '" + OccupationTextBox.Text + "'";
                                mySQL3 += "WHERE User_Name = '" + LoginUserName + "'";

                                if (SqlConnection.State != ConnectionState.Open)
                                    SqlConnection.Open();
                                SqlCommand command3 = new SqlCommand(mySQL3, SqlConnection);
                                command3.ExecuteNonQuery();

                                EmailVerifyForm verifyForm = new EmailVerifyForm();
                                verifyForm.ShowDialog();
                            }
                        }
                    }
                    else if (ProfilePictureBox.Image.ToString() != GetProfilePicture1())
                    {
                        string from2, pass2, messageBody2;
                        Random rand2 = new Random();
                        randomCode = (rand2.Next(99999)).ToString();
                        MailMessage message2 = new MailMessage();
                        to = (EmailTextBox.Text).ToString();
                        from2 = "nadim.hossain193@gmail.com";
                        pass2 = "nadim1155";
                        messageBody2 = "Your Verification Code Is " + randomCode;
                        message2.To.Add(to);
                        message2.From = new MailAddress(from2);
                        message2.Body = messageBody2;
                        message2.Subject = "Email Verification Code.";
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.Credentials = new NetworkCredential(from2, pass2);
                            smtp.EnableSsl = true;

                            if (emailaddress.Equals("") || FirstNameTextBox.Text.Equals("") || LastNameTextBox.Text.Equals("")
                            || DOBDateTimePicker.Value.Equals("") || GendeTextBox.Text.Equals("") || MaritalTextBox.Text.Equals("")
                            || AddressTextBox.Text.Equals("") || CityTextBox.Text.Equals("") || CountryTextBox.Text.Equals("")
                            || ReligionTextBox.Text.Equals("") || IncomeTextBox.Text.Equals("") || EQTextBox.Text.Equals("")
                            || OccupationTextBox.Text.Equals("") || ProfilePictureBox.Image.Equals(""))
                            {
                                MessageBox.Show("Fill All The Required Field ", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                smtp.Send(message2);
                                MessageBox.Show("Please Check Your Email And Enter The Code.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                byte[] image3 = null;
                                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                                BinaryReader binary = new BinaryReader(stream);
                                image3 = binary.ReadBytes((int)stream.Length);

                                string mySQL4 = string.Empty;
                                mySQL4 += "SELECT * FROM Parsonal ";
                                mySQL4 += "UPDATE [dbo].[Parsonal]";
                                mySQL4 += "SET [First_Name] = '" + FirstNameTextBox.Text + "'" +
                                              ",[Last_Name] = '" + LastNameTextBox.Text + "'" +
                                              ",[Email_address] = '" + emailaddress + "'" +
                                              ",[Gender] = '" + GendeTextBox.Text + "'" +
                                              ",[Date_Of_Birth] = '" + DOBDateTimePicker.Value + "'" +
                                              ",[Marital_Status] = '" + MaritalTextBox.Text + "'" +
                                              ",[Address] = '" + AddressTextBox.Text + "'" +
                                              ",[City] = '" + CityTextBox.Text + "'" +
                                              ",[Country] = '" + CountryTextBox.Text + "'" +
                                              ",[Religion] = '" + ReligionTextBox.Text + "'" +
                                              ",[Income] = '" + IncomeTextBox.Text + "'" +
                                              ",[Educational_Qualification] = '" + EQTextBox.Text + "'" +
                                              ",[Profile_picture] = @image3" +
                                              ",[Occupation] = '" + OccupationTextBox.Text + "'";
                                mySQL4 += "WHERE User_Name = '" + LoginUserName + "'";

                                if (SqlConnection.State != ConnectionState.Open)
                                    SqlConnection.Open();
                                SqlCommand command4 = new SqlCommand(mySQL4, SqlConnection);
                                command4.Parameters.AddWithValue("@image3 WHERE = '" + LoginUserName + "'", image3);
                                command4.ExecuteNonQuery();

                                EmailVerifyForm verifyForm = new EmailVerifyForm();
                                verifyForm.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        string from, pass, messageBody;
                        Random rand = new Random();
                        randomCode = (rand.Next(99999)).ToString();
                        MailMessage message = new MailMessage();
                        to = (EmailTextBox.Text).ToString();
                        from = "nadim.hossain193@gmail.com";
                        pass = "nadim1155";
                        messageBody = "Your Verification Code Is " + randomCode;
                        message.To.Add(to);
                        message.From = new MailAddress(from);
                        message.Body = messageBody;
                        message.Subject = "Email Verification Code.";
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.Credentials = new NetworkCredential(from, pass);
                            smtp.EnableSsl = true;

                            if (emailaddress.Equals("") || FirstNameTextBox.Text.Equals("") || LastNameTextBox.Text.Equals("")
                            || DOBDateTimePicker.Value.Equals("") || GendeTextBox.Text.Equals("") || MaritalTextBox.Text.Equals("")
                            || AddressTextBox.Text.Equals("") || CityTextBox.Text.Equals("") || CountryTextBox.Text.Equals("")
                            || ReligionTextBox.Text.Equals("") || IncomeTextBox.Text.Equals("") || EQTextBox.Text.Equals("")
                            || OccupationTextBox.Text.Equals("") || ProfilePictureBox.Image.Equals(""))
                            {
                                MessageBox.Show("Fill All The Required Field ", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                smtp.Send(message);
                                MessageBox.Show("Please Check Your Email And Enter The Code.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                byte[] image4 = null;
                                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                                BinaryReader binary = new BinaryReader(stream);
                                image4 = binary.ReadBytes((int)stream.Length);

                                string mySQL5 = string.Empty;
                                mySQL5 += "SELECT * FROM Parsonal ";
                                mySQL5 += "UPDATE [dbo].[Parsonal]";
                                mySQL5 += "SET [First_Name] = '" + FirstNameTextBox.Text + "'" +
                                              ",[Last_Name] = '" + LastNameTextBox.Text + "'" +
                                              ",[Email_address] = '" + emailaddress + "'" +
                                              ",[Gender] = '" + GendeTextBox.Text + "'" +
                                              ",[Date_Of_Birth] = '" + DOBDateTimePicker.Value + "'" +
                                              ",[Marital_Status] = '" + MaritalTextBox.Text + "'" +
                                              ",[Address] = '" + AddressTextBox.Text + "'" +
                                              ",[City] = '" + CityTextBox.Text + "'" +
                                              ",[Country] = '" + CountryTextBox.Text + "'" +
                                              ",[Religion] = '" + ReligionTextBox.Text + "'" +
                                              ",[Income] = '" + IncomeTextBox.Text + "'" +
                                              ",[Educational_Qualification] = '" + EQTextBox.Text + "'" +
                                              ",[Profile_picture] = @image4" +
                                              ",[Occupation] = '" + OccupationTextBox.Text + "'";
                                mySQL5 += "WHERE User_Name = '" + LoginUserName + "'";

                                if (SqlConnection.State != ConnectionState.Open)
                                    SqlConnection.Open();
                                SqlCommand command1 = new SqlCommand(mySQL5, SqlConnection);
                                command1.Parameters.AddWithValue("@image4 WHERE = '" + LoginUserName + "'", image4);
                                command1.ExecuteNonQuery();

                                EmailVerifyForm verifyForm = new EmailVerifyForm();
                                verifyForm.ShowDialog();
                            }
                        }
                    }
                }
            }
        }
    }
}
