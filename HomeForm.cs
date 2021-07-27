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
    public partial class HomeForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        String username = LoginForm.user;
        String Password = LoginForm.Password;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void GetTotalBalance()
        {
            SqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Total_Money FROM Customer_Details WHERE FUser_Name = '" + username + "'", SqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            TotalBalancelabel.Text = data.Rows[0][0].ToString();
            SqlConnection.Close();
        }

        private void TotalBalancepanel_Paint(object sender, PaintEventArgs e)
        {
            GetTotalBalance();
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

        private void DepositTimeBalancePanel_Paint_1(object sender, PaintEventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void SeeAllWithdrawHlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepanel.Controls.Clear();
            WithdrawHistoryForm withdrawHistory = new WithdrawHistoryForm();
            withdrawHistory.TopLevel = false;
            Homepanel.Controls.Add(withdrawHistory);
            withdrawHistory.Show();
        }

        private void SeeAllTransationHlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepanel.Controls.Clear();
            TransferHistoryForm transferHistory = new TransferHistoryForm();
            transferHistory.TopLevel = false;
            Homepanel.Controls.Add(transferHistory);
            transferHistory.Show();
        }

        private void SeeAllHistorylinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepanel.Controls.Clear();
            AllTransationHistoryForm allTransationHistory = new AllTransationHistoryForm();
            allTransationHistory.TopLevel = false;
            Homepanel.Controls.Add(allTransationHistory);
            allTransationHistory.Show();
        }

        private void SeeAllDepositHlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepanel.Controls.Clear();
            DepositHistoryForm depositHistory = new DepositHistoryForm();
            depositHistory.TopLevel = false;
            Homepanel.Controls.Add(depositHistory);
            depositHistory.Show();
        }
    }
}
