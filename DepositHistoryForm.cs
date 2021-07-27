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
    public partial class DepositHistoryForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        string username = LoginForm.user;

        public DepositHistoryForm()
        {
            InitializeComponent();
        }

        private void DepositHistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet3.Deposit_History_view' table. You can move, or remove it, as needed.
            this.deposit_History_viewTableAdapter.Fill(this.bankSystemDataBaseDataSet3.Deposit_History_view);

        }

        private string GetTotalBalance()
        {
            SqlConnection.Open();
            string balance;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Total_Money FROM Customer_Details WHERE FUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            balance = (data.Rows[0][0]).ToString();
            SqlConnection.Close();

            return balance;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Deposit_History_view WHERE TUser_name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);

            DepositdataGridView.DataSource = data;
            SqlConnection.Close();

            DepositNumber.Text = $"{DepositdataGridView.RowCount - 1}";

            TotalBalance.Text = GetTotalBalance();
        }

        private void GetDepositTimeBalance()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Current_Deposit_balance FROM Current_Transation_Details WHERE CUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            HDepositBalancelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void DepositTimeBalancePanel_Paint(object sender, PaintEventArgs e)
        {
            GetDepositTimeBalance();
        }

        private void GetDepositMoney()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Deposit_Money FROM Customer_Details WHERE FUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            HDepositMoneylabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void HDepositMoneypanel_Paint(object sender, PaintEventArgs e)
        {
            GetDepositMoney();
        }

        private void GetDepositTime()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT DDate_Time FROM Customer_Details WHERE FUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            HDepositTimelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void HDepositTimepanel_Paint(object sender, PaintEventArgs e)
        {
            GetDepositTime();
        }

        private void GetFirstName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT First_Name FROM Parsonal WHERE User_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            FromParsonalFirstNamlabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void FromParsonalFirstNamepanel_Paint(object sender, PaintEventArgs e)
        {
            GetFirstName();
        }

        private void GetLastName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Last_Name FROM Parsonal WHERE User_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            FromParsonalLastNamlabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void FromParsonalLastNamepanel_Paint(object sender, PaintEventArgs e)
        {
            GetLastName();
        }

        private void FromParsonalBalancepanel_Paint(object sender, PaintEventArgs e)
        {
            FromParsonalBalancelabel.Text = GetTotalBalance();
        }
    }
}
