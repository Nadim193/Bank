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
    public partial class AdminAccountDetailsForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        public AdminAccountDetailsForm()
        {
            InitializeComponent();
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

        private void GetAccountType()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Account_Type FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            AccountTypeLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetOccupation()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Occupation FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            OccupationLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetEQ()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Educational_Qualification FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            EQLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetIncome()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Income FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            IncomeLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetReligion()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Religion FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            ReligionLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetCountry()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Country FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            CountryLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetCity()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT City FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            CityLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetAddress()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Address FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            AddressLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetMarital()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Marital_Status FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            MaritalStatusLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetEmail()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Email_address FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            EmailAddressLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetGender()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Gender FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            GenderLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetDOB()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Date_Of_Birth FROM Parsonal WHERE User_Name = '" + UserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            DateOfBirthLabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
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

        private void SearchAccountButton_Click(object sender, EventArgs e)
        {
            string mySQL5 = string.Empty;
            mySQL5 += "SELECT User_Name FROM Parsonal ";
            mySQL5 += "WHERE  User_Name = '" + UserNameTextbox.Text + "'";

            DataTable userData5 = ServerConnection.executeSQL(mySQL5);

            if (userData5.Rows.Count > 0)
            {
                UsernameLabel.Text = UserNameTextbox.Text;
                FullNameLabel.Text = GetFirstName() + " " + GetLastName();
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

        private void UserNamepanel_Paint(object sender, PaintEventArgs e)
        {
            UsernameLabel.Text = "";
        }

        private void FullNamepanel_Paint(object sender, PaintEventArgs e)
        {
            FullNameLabel.Text = "";
        }

        private void DOBpanel_Paint(object sender, PaintEventArgs e)
        {
            DateOfBirthLabel.Text = "";
        }

        private void Genderpanel_Paint(object sender, PaintEventArgs e)
        {
            GenderLabel.Text = "";
        }

        private void Emailpanel_Paint(object sender, PaintEventArgs e)
        {
            EmailAddressLabel.Text = "";
        }

        private void Maritalpanel_Paint(object sender, PaintEventArgs e)
        {
            MaritalStatusLabel.Text = "";
        }

        private void Addresspanel_Paint(object sender, PaintEventArgs e)
        {
            AddressLabel.Text = "";
        }

        private void CityPanel_Paint(object sender, PaintEventArgs e)
        {
            CityLabel.Text = "";
        }

        private void Countrypanel_Paint(object sender, PaintEventArgs e)
        {
            CountryLabel.Text = "";
        }

        private void Religionpanel_Paint(object sender, PaintEventArgs e)
        {
            ReligionLabel.Text = "";
        }

        private void Incomepanel_Paint(object sender, PaintEventArgs e)
        {
            IncomeLabel.Text = "";
        }

        private void EQpanel_Paint(object sender, PaintEventArgs e)
        {
            EQLabel.Text = "";
        }

        private void Occupationpanel_Paint(object sender, PaintEventArgs e)
        {
            OccupationLabel.Text = "";
        }

        private void AccountTypepanel_Paint(object sender, PaintEventArgs e)
        {
            AccountTypeLabel.Text = "";
        }
    }
}
