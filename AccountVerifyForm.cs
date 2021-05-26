using Bank.Connection;
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
    public partial class AccountVerifyForm : Form
    {
        public AccountVerifyForm()
        {
            InitializeComponent();
        }

        private void RegistrationVerifybutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
                                    "Initial Catalog = LoginDataBase; Integrated Security = True");

            string mySQL = string.Empty;
            mySQL += "SELECT * FROM Random ";
            mySQL += "WHERE Random_code = '" + RegistrationVerifytextBox.Text + "' ";

            DataTable userData = ServerConnection.executeSQL(mySQL);

            if (userData.Rows.Count > 0)
            {
                MessageBox.Show("Account Created Successfully.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.None);
                string mySQL2 = string.Empty;
                mySQL2 += "DELETE FROM[dbo].[Random]";
                mySQL2 += "WHERE Random_code = '" + RegistrationVerifytextBox.Text + "' ";

                DataTable userData2 = ServerConnection.executeSQL(mySQL2);

                Deposit_Money deposit = new Deposit_Money();
                this.Hide();
                deposit.ShowDialog();
                this.Close();

                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Code.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void AccountVerifyForm_Load(object sender, EventArgs e)
        {
            RegistrationVerifytextBox.Select();
        }
    }
}
