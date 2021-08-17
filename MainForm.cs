using Bank.Connection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank
{
    public partial class MainForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        string deposit = DepositForm.depositbalance;

        String Regusername = RegisterForm.regUserName;
        int panelwidth;
        bool Hidden;
        string username = LoginForm.user;

        public MainForm()
        {
            InitializeComponent();
            panelwidth = panel2.Width;
            Hidden = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void cerraricon_Click(object sender, EventArgs e)
        {
            CloseForm cf = new CloseForm();
            cf.ShowDialog();
        }

        private void maxIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            RestoreDownIcon.Visible = true;
            maxIcon.Visible = false;
        }

        private void RestoreDownIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            RestoreDownIcon.Visible = false;
            maxIcon.Visible = true;
        }

        private void minIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            Account_Rewiew_Form AR = new Account_Rewiew_Form();
            AR.TopLevel = false;
            Menupanel.Controls.Add(AR);
            AR.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            WithdrawFrom withdraw = new WithdrawFrom();
            withdraw.TopLevel = false;
            Menupanel.Controls.Add(withdraw);
            withdraw.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            DepositForm deposit = new DepositForm();
            deposit.TopLevel = false;
            Menupanel.Controls.Add(deposit);
            deposit.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            TransationForm transation = new TransationForm();
            transation.TopLevel = false;
            Menupanel.Controls.Add(transation);
            transation.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            ChangePasswordForm changePassword = new ChangePasswordForm();
            changePassword.TopLevel = false;
            Menupanel.Controls.Add(changePassword);
            changePassword.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = false;
            Menupanel.Controls.Clear();
            HomeForm home = new HomeForm();
            home.TopLevel = false;
            Menupanel.Controls.Add(home);
            home.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panel2.Width = panel2.Width + 10;
                if(panel2.Width >= panelwidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panel2.Width = panel2.Width - 10;
                if(panel2.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = AccountReviewbutton.Height;
            Sidepanel.Top = AccountReviewbutton.Top;

            Menupanel.Controls.Clear();
            Account_Rewiew_Form AR = new Account_Rewiew_Form();
            AR.TopLevel = false;
            Menupanel.Controls.Add(AR);
            AR.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = Withdrawbutton.Height;
            Sidepanel.Top = Withdrawbutton.Top;

            Menupanel.Controls.Clear();
            WithdrawFrom withdraw = new WithdrawFrom();
            withdraw.TopLevel = false;
            Menupanel.Controls.Add(withdraw);
            withdraw.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = Depositbutton.Height;
            Sidepanel.Top = Depositbutton.Top;

            Menupanel.Controls.Clear();
            DepositForm deposit = new DepositForm();
            deposit.TopLevel = false;
            Menupanel.Controls.Add(deposit);
            deposit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = Transferbutton.Height;
            Sidepanel.Top = Transferbutton.Top;

            Menupanel.Controls.Clear();
            TransationForm transation = new TransationForm();
            transation.TopLevel = false;
            Menupanel.Controls.Add(transation);
            transation.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = Changebutton.Height;
            Sidepanel.Top = Changebutton.Top;

            Menupanel.Controls.Clear();
            ChangePasswordForm changePassword = new ChangePasswordForm();
            changePassword.TopLevel = false;
            Menupanel.Controls.Add(changePassword);
            changePassword.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = LogOutbutton.Height;
            Sidepanel.Top = LogOutbutton.Top;

            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void Menupanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Welcomepanel_Paint(object sender, PaintEventArgs e)
        {
            //username = Regusername;
            Welcomelabel.Text = "Welcome " + username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = Editprofilebutton.Height;
            Sidepanel.Top = Editprofilebutton.Top;

            Menupanel.Controls.Clear();
            EditProfileForm editProfile = new EditProfileForm();
            editProfile.TopLevel = false;
            Menupanel.Controls.Add(editProfile);
            editProfile.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            EditProfileForm editProfile = new EditProfileForm();
            editProfile.TopLevel = false;
            Menupanel.Controls.Add(editProfile);
            editProfile.Show();
        }

        private void HWithdrawMoneylabel_Click(object sender, EventArgs e)
        {

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

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void SeeAllWithdrawHlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menupanel.Controls.Clear();
            WithdrawHistoryForm withdrawHistory = new WithdrawHistoryForm();
            withdrawHistory.TopLevel = false;
            Menupanel.Controls.Add(withdrawHistory);
            withdrawHistory.Show();
        }

        private void SeeAllTransationHlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menupanel.Controls.Clear();
            TransferHistoryForm transferHistory = new TransferHistoryForm();
            transferHistory.TopLevel = false;
            Menupanel.Controls.Add(transferHistory);
            transferHistory.Show();
        }

        private void SeeAllDepositHlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menupanel.Controls.Clear();
            DepositHistoryForm depositHistory = new DepositHistoryForm();
            depositHistory.TopLevel = false;
            Menupanel.Controls.Add(depositHistory);
            depositHistory.Show();
        }

        private void SeeAllHistorylinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menupanel.Controls.Clear();
            AllTransationHistoryForm allTransation = new AllTransationHistoryForm();
            allTransation.TopLevel = false;
            Menupanel.Controls.Add(allTransation);
            allTransation.Show();
        }

        private void Welcomelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
