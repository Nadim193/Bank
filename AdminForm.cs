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
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminLogOutbutton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Menupanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void ChangePasswordbutton_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            ChangePasswordForm changePassword = new ChangePasswordForm();
            changePassword.TopLevel = false;
            Menupanel.Controls.Add(changePassword);
            changePassword.Show();
        }

        private void Transationbutton_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            TransationForm transation = new TransationForm();
            transation.TopLevel = false;
            Menupanel.Controls.Add(transation);
            transation.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Depositbutton_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            DepositForm deposit = new DepositForm();
            deposit.TopLevel = false;
            Menupanel.Controls.Add(deposit);
            deposit.Show();
        }

        private void CreateAccountbutton_Click(object sender, EventArgs e)
        {

        }

        private void Withdrawbutton_Click(object sender, EventArgs e)
        {
            Menupanel.Controls.Clear();
            WithdrawFrom withdraw = new WithdrawFrom();
            withdraw.TopLevel = false;
            Menupanel.Controls.Add(withdraw);
            withdraw.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerListbutton_Click(object sender, EventArgs e)
        {

        }

        private void CheckBalancebutton_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void CheckTransationbutton_Click(object sender, EventArgs e)
        {

        }

        private void AccountDetailsbutton_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
