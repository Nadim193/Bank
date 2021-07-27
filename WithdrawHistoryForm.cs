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
    public partial class WithdrawHistoryForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        string username = LoginForm.user;

        public WithdrawHistoryForm()
        {
            InitializeComponent();
        }

        private void WithdrawHistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet2.Withdraw_History_View' table. You can move, or remove it, as needed.
            this.withdraw_History_ViewTableAdapter.Fill(this.bankSystemDataBaseDataSet2.Withdraw_History_View);

        }

        private void WithdrawdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Withdraw_History_View WHERE TUser_name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);

            WithdrawdataGridView.DataSource = data;
            SqlConnection.Close();

            withdrawNumber.Text = $"{WithdrawdataGridView.RowCount - 1}";

            TotalBalance.Text = GetTotalBalance();
        }

        private void GetHWithdrawTimeBalance()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Current_Withdraw_balance FROM Current_Transation_Details WHERE CUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            HWithdrawBanlacelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void WithdrawTimeBalancepanel_Paint(object sender, PaintEventArgs e)
        {
            GetHWithdrawTimeBalance();
        }

        private void GetHWithdrawMoney()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Withdraw_Money FROM Customer_Details WHERE FUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            HWithdrawMoneylabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void WithdrawMoneypanel_Paint(object sender, PaintEventArgs e)
        {
            GetHWithdrawMoney();
        }

        private void GetHWithdrawTime()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT WDate_Time FROM Customer_Details WHERE FUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            HWithdrawTimelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void WithdrawTimepanel_Paint(object sender, PaintEventArgs e)
        {
            GetHWithdrawTime();
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
