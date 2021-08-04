using Bank.Connection;
using DataBase.Entity;
using DataBase.Opration;
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
    public partial class AdminSearchAccountForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
            "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        public AdminSearchAccountForm()
        {
            InitializeComponent();
        }

        private void AdminSearchAccountForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet15.Parsonal' table. You can move, or remove it, as needed.
            this.parsonalTableAdapter.Fill(this.bankSystemDataBaseDataSet15.Parsonal);
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet8.Admin_Login' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet7.Parsonal' table. You can move, or remove it, as needed.

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            string mySQL = string.Empty;
            mySQL += "DELETE FROM Parsonal WHERE User_Name = '" + NameTextbox.Text + "'";

            DataTable userData = ServerConnection.executeSQL(mySQL);

            if(userData.Rows.Count > 0)
            {
                MessageBox.Show("Data delete Failed.....", "Message Box");
            }
            else
            {
                MessageBox.Show("Data delete successfull...", "Message Box");
            }
        }

        private void DeactiveButton_Click(object sender, EventArgs e)
        {
            string deactive = "Disable";

            string mySQL = string.Empty;
            mySQL += "UPDATE [dbo].[Parsonal]";
            mySQL += "SET [Status] = '" + deactive + "'";
            mySQL += "WHERE User_Name = '" + NameTextbox.Text + "'";
            DataTable userData = ServerConnection.executeSQL(mySQL);

            if(userData.Rows.Count > 0)
            {
                MessageBox.Show("Failed...", "Message Box");
            }
            else
            {
                MessageBox.Show("Successfull...", "Message Box");
            }
        }

        private void NationalityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            CustomersOprationClass CO = new CustomersOprationClass();
            CustomersEntityClass CE = new CustomersEntityClass();
            try
            {
                if(SearchComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Select Search Type");
                }
                else
                {
                    if ((SearchComboBox.SelectedItem).ToString() == "- By All")
                    {
                        CE.Username = NameTextbox.Text;
                        dataGridView.DataSource = CO.Search();
                    }
                    else if ((SearchComboBox.SelectedItem).ToString() == "-By First Name")
                    {
                        CE.Username = NameTextbox.Text;
                        dataGridView.DataSource = (CO.SearchForFirstname(CE));
                    }
                    else if ((SearchComboBox.SelectedItem).ToString() == "-By Last Name")
                    {
                        CE.Username = NameTextbox.Text;
                        dataGridView.DataSource = CO.SearchForLastname(CE);
                    }
                    else if ((SearchComboBox.SelectedItem).ToString() == "-By Email")
                    {
                        CE.Username = NameTextbox.Text;
                        dataGridView.DataSource = CO.SearchForEmailaddress(CE);
                    }
                    else if ((SearchComboBox.SelectedItem).ToString() == "-By Status")
                    {
                        CE.Username = NameTextbox.Text;
                        dataGridView.DataSource = CO.SearchForStatus(CE);
                    }
                    else if ((SearchComboBox.SelectedItem).ToString() == "-By Account Type")
                    {
                        CE.Username = NameTextbox.Text;
                        dataGridView.DataSource = CO.SearchForAccountType(CE);
                    }
                    else if ((SearchComboBox.SelectedItem).ToString() == "-By Gender")
                    {
                        if (GenderComboBox.SelectedItem.ToString() != null)
                        {
                            CE.Gender = GenderComboBox.SelectedItem.ToString();
                            dataGridView.DataSource = CO.SearchForGender(CE);
                        }
                        else
                        {
                            MessageBox.Show("Select Search type");
                        }

                    }
                    else if ((SearchComboBox.SelectedItem).ToString() == "-By Occupation")
                    {
                        if (OccupationComboBox.SelectedItem.ToString() != null)
                        {
                            CE.Occupation = OccupationComboBox.SelectedItem.ToString();
                            dataGridView.DataSource = CO.SearchForOccupation(CE);
                        }
                        else
                        {
                            MessageBox.Show("Select Search type");
                        }

                    }
                    else if ((SearchComboBox.SelectedItem).ToString() == "-By Nationality")
                    {
                        if (NationalityComboBox.SelectedItem != null)
                        {
                            CE.Nationality = NationalityComboBox.SelectedItem.ToString();
                            dataGridView.DataSource = CO.SearchForNationality(CE);
                        }
                        else
                        {
                            MessageBox.Show("Select Search type");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error...");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select Search Type");
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            if (SearchComboBox.SelectedItem != null)
            {
                if (SearchComboBox.SelectedItem.ToString() == "-By Nationality")
                {
                    Namelabel.Visible = false;
                    NameTextbox.Visible = false;
                    GenderComboBox.Visible = false;
                    OccupationComboBox.Visible = false;
                    NationalityComboBox.Visible = true;
                }
                else if (SearchComboBox.SelectedItem.ToString() == "-By Occupation")
                {
                    Namelabel.Visible = false;
                    NameTextbox.Visible = false;
                    NationalityComboBox.Visible = false;
                    GenderComboBox.Visible = false;
                    OccupationComboBox.Visible = true;
                }
                else if (SearchComboBox.SelectedItem.ToString() == "-By Gender")
                {
                    Namelabel.Visible = false;
                    NameTextbox.Visible = false;
                    NationalityComboBox.Visible = false;
                    OccupationComboBox.Visible = false;
                    GenderComboBox.Visible = true;
                }
                else if (SearchComboBox.SelectedItem.ToString() == "-By All")
                {
                    Namelabel.Visible = false;
                    NameTextbox.Visible = false;
                    OccupationComboBox.Visible = false;
                    GenderComboBox.Visible = false;
                    NationalityComboBox.Visible = false;
                }
                else if (SearchComboBox.SelectedItem.ToString() == "-By Account Type")
                {
                    OccupationComboBox.Visible = false;
                    GenderComboBox.Visible = false;
                    NationalityComboBox.Visible = false;
                    Namelabel.Visible = true;
                    NameTextbox.Visible = true;
                }
                else if (SearchComboBox.SelectedItem.ToString() == "-By Status")
                {
                    OccupationComboBox.Visible = false;
                    GenderComboBox.Visible = false;
                    NationalityComboBox.Visible = false;
                    Namelabel.Visible = true;
                    NameTextbox.Visible = true;
                }
                else if (SearchComboBox.SelectedItem.ToString() == "-By Email")
                {
                    OccupationComboBox.Visible = false;
                    GenderComboBox.Visible = false;
                    NationalityComboBox.Visible = false;
                    Namelabel.Visible = true;
                    NameTextbox.Visible = true;
                }
                else if (SearchComboBox.SelectedItem.ToString() == "-By Last Name")
                {
                    OccupationComboBox.Visible = false;
                    GenderComboBox.Visible = false;
                    NationalityComboBox.Visible = false;
                    Namelabel.Visible = true;
                    NameTextbox.Visible = true;
                }
                else if (SearchComboBox.SelectedItem.ToString() == "-By First Name")
                {
                    OccupationComboBox.Visible = false;
                    GenderComboBox.Visible = false;
                    NationalityComboBox.Visible = false;
                    Namelabel.Visible = true;
                    NameTextbox.Visible = true;
                }
                else
                {
                    OccupationComboBox.Visible = false;
                    GenderComboBox.Visible = false;
                    NationalityComboBox.Visible = false;
                    Namelabel.Visible = true;
                    NameTextbox.Visible = true;
                }
            }
        }
    }
}
