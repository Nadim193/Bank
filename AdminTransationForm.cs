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
    public partial class AdminTransationForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        public AdminTransationForm()
        {
            InitializeComponent();
        }

        private void AdminTransationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet12.Transfer_History_View' table. You can move, or remove it, as needed.
            this.transfer_History_ViewTableAdapter.Fill(this.bankSystemDataBaseDataSet12.Transfer_History_View);
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet11.Withdraw_History_View' table. You can move, or remove it, as needed.
            this.withdraw_History_ViewTableAdapter.Fill(this.bankSystemDataBaseDataSet11.Withdraw_History_View);
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet10.Deposit_History_view' table. You can move, or remove it, as needed.
            this.deposit_History_viewTableAdapter.Fill(this.bankSystemDataBaseDataSet10.Deposit_History_view);

        }

        private void GetDeposit()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Deposit_History_view WHERE TUser_name = '" + TransationUserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);

            DepositdataGridView.DataSource = data;
            SqlConnection.Close();
        }

        private void GetWithdraw()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Withdraw_History_View WHERE TUser_name = '" + TransationUserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);

            WithdrawdataGridView.DataSource = data;
            SqlConnection.Close();
        }

        private void GetTransfer()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Transfer_History_View WHERE TUser_name = '" + TransationUserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);

            TransferdataGridView.DataSource = data;
            SqlConnection.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            GetDeposit();
            GetWithdraw();
            GetTransfer();
            DepositTimelabel.Text = GetDepositTime();
            WithdrawTimelabel.Text = GetWithdrawTime();
            TransferTimelabel.Text = GetTransferTime();
            DepositNumberlabel.Text = $"{DepositdataGridView.RowCount - 1}";
            WithdrawNumberlabel.Text = $"{WithdrawdataGridView.RowCount - 1}";
            TransferNumberlabel.Text = $"{TransferdataGridView.RowCount - 1}";
        }

        private string GetDepositTime()
        {
            SqlConnection.Open();
            string Dtime;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT DDate_Time FROM Customer_Details WHERE FUser_Name = '" + TransationUserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            Dtime = data.Rows[0][0].ToString();
            SqlConnection.Close();

            return Dtime;
        }

        private string GetWithdrawTime()
        {
            SqlConnection.Open();
            string Wtime;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT WDate_Time FROM Customer_Details WHERE FUser_Name = '" + TransationUserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            Wtime = data.Rows[0][0].ToString();
            SqlConnection.Close();

            return Wtime;
        }

        private string GetTransferTime()
        {
            SqlConnection.Open();
            string Ttime;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT TDate_Time FROM Customer_Details WHERE FUser_Name = '" + TransationUserNameTextbox.Text + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            Ttime = data.Rows[0][0].ToString();
            SqlConnection.Close();

            return Ttime;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
