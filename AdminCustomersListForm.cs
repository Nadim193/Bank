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
    public partial class AdminCustomersListForm : Form
    {

        public AdminCustomersListForm()
        {
            InitializeComponent();
        }

        private void AdminCustomersListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet14.Parsonal' table. You can move, or remove it, as needed.
            this.parsonalTableAdapter.Fill(this.bankSystemDataBaseDataSet14.Parsonal);
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet9.Parsonal' table. You can move, or remove it, as needed.

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            TotalCustomerslabel.Text = $"{CustomerListdataGridView.RowCount - 1}";
        }

        private void OccupationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            string mySQL = string.Empty;
            mySQL += "SELECT User_Name FROM Parsonal ";
            mySQL += "WHERE  User_Name = '" + NameTextbox.Text + "'";

            DataTable userData = ServerConnection.executeSQL(mySQL);
            if (NameTextbox.Text.Equals(""))
            {
                MessageBox.Show("Enter User Name");
            }
            else
            {
                if (userData.Rows.Count > 0)
                {
                    string mySQL1 = string.Empty;
                    mySQL1 += "DELETE FROM Parsonal WHERE User_Name = '" + NameTextbox.Text + "'";

                    DataTable userData1 = ServerConnection.executeSQL(mySQL1);

                    if (userData1.Rows.Count > 0)
                    {
                        MessageBox.Show("Data delete Failed.....", "Message Box");
                    }
                    else
                    {
                        PasswordForm password = new PasswordForm();
                        password.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("This user name is not existed");
                }
            }
        }

        private void DeactiveButton_Click(object sender, EventArgs e)
        {
            string deactive = "Disable";

            string mySQL = string.Empty;
            mySQL += "SELECT User_Name FROM Parsonal ";
            mySQL += "WHERE  User_Name = '" + NameTextbox.Text + "'";

            string mySQL2 = string.Empty;
            mySQL2 += "SELECT Status FROM Parsonal ";
            mySQL2 += "WHERE  Status = '" + deactive + "' AND User_Name = '" + NameTextbox.Text + "'";

            DataTable userData = ServerConnection.executeSQL(mySQL);
            DataTable userData2 = ServerConnection.executeSQL(mySQL2);
            if (NameTextbox.Text.Equals(""))
            {
                MessageBox.Show("Enter User Name");
            }
            else
            {
                if (userData.Rows.Count > 0)
                {
                    if (userData2.Rows.Count > 0)
                    {
                        MessageBox.Show("This Account was already Disable");
                    }
                    else
                    {
                        string mySQL1 = string.Empty;
                        mySQL1 += "UPDATE [dbo].[Parsonal]";
                        mySQL1 += "SET [Status] = '" + deactive + "'";
                        mySQL1 += "WHERE User_Name = '" + NameTextbox.Text + "'";
                        DataTable userData1 = ServerConnection.executeSQL(mySQL1);

                        if (userData1.Rows.Count > 0)
                        {
                            MessageBox.Show("Failed...", "Message Box");
                        }
                        else
                        {
                            PasswordForm password = new PasswordForm();
                            password.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This user name is not existed");
                }
            }
        }

        private void ActiveButton_Click(object sender, EventArgs e)
        {
            string active = "Active";

            string mySQL = string.Empty;
            mySQL += "SELECT User_Name FROM Parsonal ";
            mySQL += "WHERE  User_Name = '" + NameTextbox.Text + "'";

            string mySQL2 = string.Empty;
            mySQL2 += "SELECT Status FROM Parsonal ";
            mySQL2 += "WHERE  User_Name = '" + NameTextbox.Text + "' AND Status = '" + active + "'";

            DataTable userData = ServerConnection.executeSQL(mySQL);
            DataTable userData2 = ServerConnection.executeSQL(mySQL2);
            if (NameTextbox.Text.Equals(""))
            {
                MessageBox.Show("Enter User Name");
            }
            else
            {
                if (userData.Rows.Count > 0)
                {
                    if (userData2.Rows.Count > 0)
                    {
                        MessageBox.Show("This Account was already Active");
                    }
                    else
                    {
                        string mySQL1 = string.Empty;
                        mySQL1 += "UPDATE [dbo].[Parsonal]";
                        mySQL1 += "SET [Status] = '" + active + "'";
                        mySQL1 += "WHERE User_Name = '" + NameTextbox.Text + "'";
                        DataTable userData1 = ServerConnection.executeSQL(mySQL1);

                        if (userData1.Rows.Count > 0)
                        {
                            MessageBox.Show("Failed...", "Message Box");
                        }
                        else
                        {
                            PasswordForm password = new PasswordForm();
                            password.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This user name is not existed");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AdminCustomersListForm customersListForm = new AdminCustomersListForm();
            customersListForm.TopLevel = false;
            panel1.Controls.Add(customersListForm);
            customersListForm.Show();


        }
    }
}
