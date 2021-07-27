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
    public partial class AllTransationHistoryForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        string username = LoginForm.user;

        public AllTransationHistoryForm()
        {
            InitializeComponent();
        }

        private void AllTransationHistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet5.ALLTransation_View' table. You can move, or remove it, as needed.
            this.aLLTransation_ViewTableAdapter.Fill(this.bankSystemDataBaseDataSet5.ALLTransation_View);

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
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM ALLTransation_View WHERE TUser_name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);

            AlltransationdataGridView.DataSource = data;
            SqlConnection.Close();

            AllTransationNumber.Text = $"{AlltransationdataGridView.RowCount - 1}";

            TotalBalance.Text = GetTotalBalance();
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

        private void GetAllHDepositMoney()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Deposit_Money FROM Customer_Details WHERE FUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            AllHDepositMoneylabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void AllHDepositMoneypanel_Paint(object sender, PaintEventArgs e)
        {
            GetAllHDepositMoney();
        }

        private void GetAllHWithdrawMoney()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Withdraw_Money FROM Customer_Details WHERE FUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            AllHWithdrawMoneylabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void AllHWithdrawMoneypanel_Paint(object sender, PaintEventArgs e)
        {
            GetAllHWithdrawMoney();
        }

        private void GetAllHTransationMoney()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Transation_Money FROM Customer_Details WHERE FUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            AllHTransationMoneylabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void HTransationMoneypanel_Paint(object sender, PaintEventArgs e)
        {
            GetAllHTransationMoney();
        }
    }
}
