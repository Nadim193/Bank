using Bank.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class AdminCheckBalanceForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        public AdminCheckBalanceForm()
        {
            InitializeComponent();
        }

        private void AdminCheckBalanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet13.Parsonal' table. You can move, or remove it, as needed.
            this.parsonalTableAdapter.Fill(this.bankSystemDataBaseDataSet13.Parsonal);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            CustomersListlabel.Text = $"{CustomerListdataGridView.RowCount - 1}";
        }

        private void GetFirstName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT First_Name FROM Parsonal WHERE User_Name = '" + UseNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            FirstNamelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void GetLastName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Last_Name FROM Parsonal WHERE User_Name = '" + UseNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            LastNamelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void CurrentBalance()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Total_Money FROM Customer_Details WHERE FUser_Name = '" + UseNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            CurrentBalancelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void SearchAccountButton_Click(object sender, EventArgs e)
        {
            string mySQL6 = string.Empty;
            mySQL6 += "SELECT User_Name FROM Parsonal ";
            mySQL6 += "WHERE  User_Name = '" + UseNameTextbox.Text + "'";

            DataTable userData6 = ServerConnection.executeSQL(mySQL6);

            if (userData6.Rows.Count > 0)
            {
                GetFirstName();
                GetLastName();
                CurrentBalance();
            }
            else
            {
                MessageBox.Show("This user name is not existed", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
