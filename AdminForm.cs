using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class AdminForm : Form
    {
        int panelwidth;
        bool Hidden;

        public AdminForm()
        {
            InitializeComponent();
            panelwidth = panel2.Width;
            Hidden = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panel2.Width = panel2.Width + 10;
                if (panel2.Width >= panelwidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panel2.Width = panel2.Width - 10;
                if (panel2.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void cerraricon_Click_1(object sender, EventArgs e)
        {
            CloseForm close = new CloseForm();
            close.ShowDialog();
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

        private void maxIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            RestoreDownIcon.Visible = true;
            maxIcon.Visible = false;
        }

        private void CreatedAccountbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = CreatedAccountbutton.Height;
            Sidepanel.Top = CreatedAccountbutton.Top;

            Menupanel.Controls.Clear();
            AdminCreatedNewForm adminCreated = new AdminCreatedNewForm();
            adminCreated.TopLevel = false;
            Menupanel.Controls.Add(adminCreated);
            adminCreated.Show();
        }

        private void CheckBalancebutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = CheckBalancebutton.Height;
            Sidepanel.Top = CheckBalancebutton.Top;

            Menupanel.Controls.Clear();
            AdminCheckBalanceForm checkBalance = new AdminCheckBalanceForm();
            checkBalance.TopLevel = false;
            Menupanel.Controls.Add(checkBalance);
            checkBalance.Show();
        }

        private void CustomersListbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = CustomersListbutton.Height;
            Sidepanel.Top = CustomersListbutton.Top;

            Menupanel.Controls.Clear();
            AdminCustomersListForm customersListForm = new AdminCustomersListForm();
            customersListForm.TopLevel = false;
            Menupanel.Controls.Add(customersListForm);
            customersListForm.Show();
        }

        private void SearchAccountbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = SearchAccountbutton.Height;
            Sidepanel.Top = SearchAccountbutton.Top;

            Menupanel.Controls.Clear();
            AdminSearchAccountForm searchAccountForm = new AdminSearchAccountForm();
            searchAccountForm.TopLevel = false;
            Menupanel.Controls.Add(searchAccountForm);
            searchAccountForm.Show();
        }

        private void Transationbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = Transationbutton.Height;
            Sidepanel.Top = Transationbutton.Top;

            Menupanel.Controls.Clear();
            AdminTransationForm transationForm = new AdminTransationForm();
            transationForm.TopLevel = false;
            Menupanel.Controls.Add(transationForm);
            transationForm.Show();
        }

        private void Withdrawbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = Withdrawbutton.Height;
            Sidepanel.Top = Withdrawbutton.Top;

            Menupanel.Controls.Clear();
            AdminWithdrawForm withdrawForm = new AdminWithdrawForm();
            withdrawForm.TopLevel = false;
            Menupanel.Controls.Add(withdrawForm);
            withdrawForm.Show();
        }

        private void Depositbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = Depositbutton.Height;
            Sidepanel.Top = Depositbutton.Top;

            Menupanel.Controls.Clear();
            AdminDepositForm depositForm = new AdminDepositForm();
            depositForm.TopLevel = false;
            Menupanel.Controls.Add(depositForm);
            depositForm.Show();
        }

        private void Transferbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = Transferbutton.Height;
            Sidepanel.Top = Transferbutton.Top;

            Menupanel.Controls.Clear();
            AdminTransferForm transferForm = new AdminTransferForm();
            transferForm.TopLevel = false;
            Menupanel.Controls.Add(transferForm);
            transferForm.Show();
        }

        private void AccountDetailsbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = AccountDetailsbutton.Height;
            Sidepanel.Top = AccountDetailsbutton.Top;

            Menupanel.Controls.Clear();
            AdminAccountDetailsForm accountDetailForm = new AdminAccountDetailsForm();
            accountDetailForm.TopLevel = false;
            Menupanel.Controls.Add(accountDetailForm);
            accountDetailForm.Show();
        }

        private void UpdateAccountbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = UpdateAccountbutton.Height;
            Sidepanel.Top = UpdateAccountbutton.Top;

            Menupanel.Controls.Clear();
            AdminUpdateAccountForm updateAccountForm = new AdminUpdateAccountForm();
            updateAccountForm.TopLevel = false;
            Menupanel.Controls.Add(updateAccountForm);
            updateAccountForm.Show();
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = Logoutbutton.Height;
            Sidepanel.Top = Logoutbutton.Top;

            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = false;

            Menupanel.Controls.Clear();
            AdminHomeForm adminHom = new AdminHomeForm();
            adminHom.TopLevel = false;
            Menupanel.Controls.Add(adminHom);
            adminHom.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            AdminCreatedNewForm adminCreated = new AdminCreatedNewForm();
            adminCreated.TopLevel = false;
            Menupanel.Controls.Add(adminCreated);
            adminCreated.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            AdminCheckBalanceForm checkBalance = new AdminCheckBalanceForm();
            checkBalance.TopLevel = false;
            Menupanel.Controls.Add(checkBalance);
            checkBalance.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            AdminCustomersListForm customersListForm = new AdminCustomersListForm();
            customersListForm.TopLevel = false;
            Menupanel.Controls.Add(customersListForm);
            customersListForm.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            AdminSearchAccountForm searchAccountForm = new AdminSearchAccountForm();
            searchAccountForm.TopLevel = false;
            Menupanel.Controls.Add(searchAccountForm);
            searchAccountForm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            AdminTransationForm transationForm = new AdminTransationForm();
            transationForm.TopLevel = false;
            Menupanel.Controls.Add(transationForm);
            transationForm.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            AdminWithdrawForm withdrawForm = new AdminWithdrawForm();
            withdrawForm.TopLevel = false;
            Menupanel.Controls.Add(withdrawForm);
            withdrawForm.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            AdminDepositForm depositForm = new AdminDepositForm();
            depositForm.TopLevel = false;
            Menupanel.Controls.Add(depositForm);
            depositForm.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            AdminTransferForm transferForm = new AdminTransferForm();
            transferForm.TopLevel = false;
            Menupanel.Controls.Add(transferForm);
            transferForm.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            AdminAccountDetailsForm accountDetailForm = new AdminAccountDetailsForm();
            accountDetailForm.TopLevel = false;
            Menupanel.Controls.Add(accountDetailForm);
            accountDetailForm.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            AdminUpdateAccountForm updateAccountForm = new AdminUpdateAccountForm();
            updateAccountForm.TopLevel = false;
            Menupanel.Controls.Add(updateAccountForm);
            updateAccountForm.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
