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
    public partial class Deposit_Money : Form
    {
        public Deposit_Money()
        {
            InitializeComponent();
        }

        private void DepositBackbutton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Deposit_Money_Load(object sender, EventArgs e)
        {
            DepositMoneyTextbox.Select();
        }

        private void DepositMoneybutton_Click(object sender, EventArgs e)
        {
            if (DepositMoneyTextbox.Text == "")
            {
                MessageBox.Show("Please Deposit Minimum Amount.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DepositMoneyTextbox.Select();
            }
            else
            {

                LoginForm loginForm = new LoginForm();
                MessageBox.Show("Successfully Deposit.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
        }
    }
}
