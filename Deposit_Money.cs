using Bank.Connection;
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
        public static double depositmoney;

        String LoginUser = LoginForm.user;
        String LoginPassword = LoginForm.Password;

        String RegUser = RegisterForm.regUserName;
        String RegPassword = RegisterForm.RegPassword;

        public Deposit_Money()
        {
            InitializeComponent();
        }

        private void Deposit_Money_Load(object sender, EventArgs e)
        {
            DepositMoneyTextbox.Select();
        }

        private void DepositMoneybutton_Click(object sender, EventArgs e)
        {
            try
            {
                depositmoney = Convert.ToDouble(DepositMoneyTextbox.Text);

                if (depositmoney == 0.0)
                {
                    MessageBox.Show("Please Deposit Minimum Amount.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DepositMoneyTextbox.Select();
                }
                else
                {
                    string mySQL = string.Empty;
                    DateTime dateTimeVariable = DateTime.Now;
                    mySQL += "SELECT * FROM Customer_Details ";
                    mySQL += "UPDATE [dbo].[Customer_Details]";
                    mySQL += "SET [Total_Money] = '" + depositmoney + "', [Deposit_Money] = '" + depositmoney + "' , [DDate_Time] = '" + dateTimeVariable + "'";
                    mySQL += "WHERE FUser_Name = '" + RegUser + "'";

                    DataTable userData = ServerConnection.executeSQL(mySQL);

                    if(userData.Rows.Count > 0)
                    {
                        string field = "Deposit";

                        LoginForm login = new LoginForm();

                        string mySQL1 = string.Empty;

                        mySQL1 += @"INSERT INTO [dbo].[Transation_History]
                                   ([TUser_name]
                                   ,[Amount]
                                   ,[Field]
                                   ,[Date])
                             VALUES
                                   ('" + RegUser + "', '" + depositmoney + "', '" + field + "', '" + dateTimeVariable + "')";
                        DataTable userData1 = ServerConnection.executeSQL(mySQL1);

                        MessageBox.Show("Successfully Deposit.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Hide();
                        login.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Depoist Fail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter Valide Amount.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void cerraricon_Click(object sender, EventArgs e)
        {
            CloseForm close = new CloseForm();
            close.ShowDialog();
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

        private void DepositMoneyTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && DepositMoneyTextbox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Enter Valide Number.");
                DepositMoneyTextbox.Clear();
            }
        }
    }
}
