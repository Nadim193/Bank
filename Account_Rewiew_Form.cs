using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Bank.Connection;
using System.Drawing.Imaging;

namespace Bank
{
    public partial class Account_Rewiew_Form : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        string Regusername = RegisterForm.regUserName;
        string LoginUserName = LoginForm.user;

        public Account_Rewiew_Form()
        {
            InitializeComponent();
        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {
            //LoginUserName = Regusername;
            UserNameLabel.Text = LoginUserName;
        }

        private String GetFirstName()
        {
            String FirstName = "";
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT First_Name FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
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
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Last_Name FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            LastName = data.Rows[0][0].ToString();
            SqlConnection.Close();

            return LastName;
        }

        private void Namepanel_Paint(object sender, PaintEventArgs e)
        {
            FullNameLabel.Text = GetFirstName() + " " + GetLastName();
        }

        private void GetDOB()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Date_Of_Birth FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            DateOfBirthLabel.Text = data.Rows[0][0].ToString();
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
            GenderLabel.Text = data.Rows[0][0].ToString();
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
            EmailAddressLabel.Text = data.Rows[0][0].ToString();
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
            MaritalStatusLabel.Text = data.Rows[0][0].ToString();
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
            AddressLabel.Text = data.Rows[0][0].ToString();
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
            CityLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void Citypanel_Paint(object sender, PaintEventArgs e)
        {
            GetCity();
        }

        private void GetCountry()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Country FROM Parsonal WHERE User_Name = '" + LoginUserName + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            CountryLabel.Text = data.Rows[0][0].ToString();
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
            ReligionLabel.Text = data.Rows[0][0].ToString();
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
            IncomeLabel.Text = data.Rows[0][0].ToString();
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
            EQLabel.Text = data.Rows[0][0].ToString();
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
            OccupationLabel.Text = data.Rows[0][0].ToString();
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
            AccountTypeLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void AccountTypepanel_Paint(object sender, PaintEventArgs e)
        {
            GetAccountType();
        }

        private void GetProfilePicture()
        {
            string Sql = "SELECT Profile_picture FROM Parsonal WHERE User_Name = '" + LoginUserName + "'" ;
            if (SqlConnection.State != ConnectionState.Open)
                SqlConnection.Open();
            SqlCommand command = new SqlCommand(Sql, SqlConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();
            if (dataReader.HasRows)
            {
                byte[] img = (byte[])(dataReader[0]);

                if(img == null)
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

        private void AccountDisabledButton_Click(object sender, EventArgs e)
        {
            DisableSureForm sureForm = new DisableSureForm();
            sureForm.ShowDialog();
        }
    }
}
