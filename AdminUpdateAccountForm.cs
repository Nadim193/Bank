using Bank.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class AdminUpdateAccountForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        string imgLocation = "";

        public AdminUpdateAccountForm()
        {
            InitializeComponent();
        }

        private void FileChooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All file(*.*)|*.*|png file(*.png)|*.png|jpg file(*.jpg)|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                ProfilePictureBox.ImageLocation = imgLocation;
            }
        }

        private void EQpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void DOBpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private String GetFirstName()
        {
            String FirstName = "";
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT First_Name FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            FirstName = data.Rows[0][0].ToString();
            SqlConnection.Close();

            return FirstName;
        }

        private String GetLastName()
        {
            String LastName = "";
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Last_Name FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            LastName = data.Rows[0][0].ToString();
            SqlConnection.Close();

            return LastName;
        }

        private void GetDOB()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Date_Of_Birth FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            DOBDateTimePicker.Value = Convert.ToDateTime (data.Rows[0][0]);
            SqlConnection.Close();
        }

        private void GetGender()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Gender FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            GenderTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetEmail()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Email_address FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            EmailAdressTxtbox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetMarital()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Marital_Status FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            MaritalTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetAddress()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Address FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            AddresstextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetCity()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT City FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            CitytextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetCountry()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Country FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            CountrytextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetReligion()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Religion FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            ReligionTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetIncome()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Income FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            IncomeTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetEQ()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Educational_Qualification FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            EQTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetOccupation()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Occupation FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            occupationTextBox.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetAccountType()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Account_Type FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            AccountTypeLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetProfilePicture()
        {
            string Sql = "SELECT Profile_picture FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'";
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

        private void SearchAccountButton_Click(object sender, EventArgs e)
        {
            string mySQL5 = string.Empty;
            mySQL5 += "SELECT User_Name FROM Parsonal ";
            mySQL5 += "WHERE  User_Name = '" + UserNameTextbox.Text + "'";

            DataTable userData5 = ServerConnection.executeSQL(mySQL5);

            if (userData5.Rows.Count > 0)
            {
                FirstNametextBox.Text = GetFirstName();
                LastNametextBox.Text =  GetLastName();
                GetDOB();
                GetGender();
                GetEmail();
                GetMarital();
                GetAddress();
                GetCity();
                GetCountry();
                GetReligion();
                GetIncome();
                GetEQ();
                GetOccupation();
                GetAccountType();
                GetProfilePicture();
            }
            else
            {
                MessageBox.Show("This user name is not existed", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserNameTextbox.Clear();
                UserNameTextbox.Select();
            }
        }

        private string GetProfilePicture1()
        {
            string Sql = "SELECT Profile_picture FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'";
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

        private void ProfileUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FirstNametextBox.Text.Equals("") || LastNametextBox.Text.Equals("")
                || DOBDateTimePicker.Equals("") || GenderTextBox.Text.Equals("") || MaritalTextBox.Text.Equals("")
                || AddresstextBox.Text.Equals("") || CitytextBox.Text.Equals("") || CountrytextBox.Text.Equals("")
                || ReligionTextBox.Text.Equals("") || IncomeTextBox.Text.Equals("") || EQTextBox.Text.Equals("")
                || occupationTextBox.Text.Equals("") || ProfilePictureBox.Image.Equals(""))
                {
                    MessageBox.Show("Fill All The Required Field ", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (ProfilePictureBox.Image.ToString() == GetProfilePicture1())
                    {
                        string mySQL2 = string.Empty;
                        mySQL2 += "SELECT * FROM Parsonal ";
                        mySQL2 += "UPDATE [dbo].[Parsonal]";
                        mySQL2 += "SET [First_Name] = '" + FirstNametextBox.Text + "'" +
                                      ",[Last_Name] = '" + LastNametextBox.Text + "'" +
                                      ",[Email_address] = '" + EmailAdressTxtbox.Text + "'" +
                                      ",[Gender] = '" + GenderTextBox.Text + "'" +
                                      ",[Date_Of_Birth] = '" + DOBDateTimePicker.Value + "'" +
                                      ",[Marital_Status] = '" + MaritalTextBox.Text + "'" +
                                      ",[Address] = '" + AddresstextBox.Text + "'" +
                                      ",[City] = '" + CitytextBox.Text + "'" +
                                      ",[Country] = '" + CountrytextBox.Text + "'" +
                                      ",[Religion] = '" + ReligionTextBox.Text + "'" +
                                      ",[Income] = '" + IncomeTextBox.Text + "'" +
                                      ",[Educational_Qualification] = '" + EQTextBox.Text + "'" +
                                      ",[Occupation] = '" + occupationTextBox.Text + "'";
                        mySQL2 += "WHERE User_Name = '" + UserNameTextbox.Text + "'";

                        if (SqlConnection.State != ConnectionState.Open)
                            SqlConnection.Open();
                        SqlCommand command2 = new SqlCommand(mySQL2, SqlConnection);
                        command2.ExecuteNonQuery();

                        MessageBox.Show("Update Successfull", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (ProfilePictureBox.Image.ToString() != GetProfilePicture1())
                    {
                        byte[] image1 = null;
                        FileStream stream1 = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader binary1 = new BinaryReader(stream1);
                        image1 = binary1.ReadBytes((int)stream1.Length);

                        string mySQL1 = string.Empty;
                        mySQL1 += "SELECT * FROM Parsonal ";
                        mySQL1 += "UPDATE [dbo].[Parsonal]";
                        mySQL1 += "SET [First_Name] = '" + FirstNametextBox.Text + "'" +
                                      ",[Last_Name] = '" + LastNametextBox.Text + "'" +
                                      ",[Email_address] = '" + EmailAdressTxtbox.Text + "'" +
                                      ",[Gender] = '" + GenderTextBox.Text + "'" +
                                      ",[Date_Of_Birth] = '" + DOBDateTimePicker.Value + "'" +
                                      ",[Marital_Status] = '" + MaritalTextBox.Text + "'" +
                                      ",[Address] = '" + AddresstextBox.Text + "'" +
                                      ",[City] = '" + CitytextBox.Text + "'" +
                                      ",[Country] = '" + CountrytextBox.Text + "'" +
                                      ",[Religion] = '" + ReligionTextBox.Text + "'" +
                                      ",[Income] = '" + IncomeTextBox.Text + "'" +
                                      ",[Educational_Qualification] = '" + EQTextBox.Text + "'" +
                                      ",[Profile_picture] = '" + image1 +"'" +
                                      ",[Occupation] = '" + occupationTextBox.Text + "'";
                        mySQL1 += "WHERE User_Name = '" + UserNameTextbox.Text + "'";

                        if (SqlConnection.State != ConnectionState.Open)
                            SqlConnection.Open();
                        SqlCommand command1 = new SqlCommand(mySQL1, SqlConnection);
                        //command1.Parameters.AddWithValue("@image1", image1);
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
                        mySQL += "SET [First_Name] = '" + FirstNametextBox.Text + "'" +
                                      ",[Last_Name] = '" + LastNametextBox.Text + "'" +
                                      ",[Email_address] = '" + EmailAdressTxtbox.Text + "'" +
                                      ",[Gender] = '" + GenderTextBox.Text + "'" +
                                      ",[Date_Of_Birth] = '" + DOBDateTimePicker.Value + "'" +
                                      ",[Marital_Status] = '" + MaritalTextBox.Text + "'" +
                                      ",[Address] = '" + AddresstextBox.Text + "'" +
                                      ",[City] = '" + CitytextBox.Text + "'" +
                                      ",[Country] = '" + CountrytextBox.Text + "'" +
                                      ",[Religion] = '" + ReligionTextBox.Text + "'" +
                                      ",[Income] = '" + IncomeTextBox.Text + "'" +
                                      ",[Educational_Qualification] = '" + EQTextBox.Text + "'" +
                                      ",[Profile_picture] = '" + image + "'" +
                                      ",[Occupation] = '" + occupationTextBox.Text + "'";
                        mySQL += "WHERE User_Name = '" + UserNameTextbox.Text + "'";

                        if (SqlConnection.State != ConnectionState.Open)
                            SqlConnection.Open();
                        SqlCommand command = new SqlCommand(mySQL, SqlConnection);
                        //command.Parameters.AddWithValue("@image", image);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Update Successfull", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" +ex );
            }
        }

        private void AccountTypepanel_Paint(object sender, PaintEventArgs e)
        {
            AccountTypeLabel.Text = "";
        }
    }
}
