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
    public partial class TransferHistoryForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        string username = LoginForm.user;

        public TransferHistoryForm()
        {
            InitializeComponent();
        }

        private void TransferHistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet6.Transfer_History_View' table. You can move, or remove it, as needed.
            this.transfer_History_ViewTableAdapter1.Fill(this.bankSystemDataBaseDataSet6.Transfer_History_View);
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet4.Transfer_History_View' table. You can move, or remove it, as needed.
            this.transfer_History_ViewTableAdapter.Fill(this.bankSystemDataBaseDataSet4.Transfer_History_View);

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
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Transfer_History_View WHERE TUser_name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);

            TransferdataGridView.DataSource = data;
            SqlConnection.Close();

            TransferNumber.Text = $"{TransferdataGridView.RowCount - 1}";

            TotalBalance.Text = GetTotalBalance();
        }

        private void GetTransationTimeBalance()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Current_Transfer_balance FROM Current_Transation_Details WHERE CUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            HTransationBalancelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void TransationTimeBalancepanel_Paint(object sender, PaintEventArgs e)
        {
            GetTransationTimeBalance();
        }

        private void GetTransationMoney()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Transation_Money FROM Customer_Details WHERE FUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            HTransationMoneylabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void TransationMoneypanel_Paint(object sender, PaintEventArgs e)
        {
            GetTransationMoney();
        }

        private void GetTransationTime()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT TDate_Time FROM Customer_Details WHERE FUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            HTransationTimelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void TransationTimepanel_Paint(object sender, PaintEventArgs e)
        {
            GetTransationTime();
        }

        private void GetTransationToName()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Transation_To FROM Customer_Details WHERE FUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            HTransationTolabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void TransationTopanel_Paint(object sender, PaintEventArgs e)
        {
            GetTransationToName();
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
