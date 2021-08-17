using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Bank.Connection;

namespace Bank
{
    public partial class AdminCreatedNewForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = LAPTOP-V4386OSC;" +
                    "Initial Catalog = BankSystemDataBase; Integrated Security = True");

        string imgLocation = "";
        string regEmail;
        string Active;

        public AdminCreatedNewForm()
        {
            InitializeComponent();
        }

        private void FirstNamepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HidePasswordBox_Click(object sender, EventArgs e)
        {
            PasswordtextBox.UseSystemPasswordChar = true;
            ShowPasswordBox.Visible = true;
            HidePasswordBox.Visible = false;
        }

        private void HidePasswordBox1_Click(object sender, EventArgs e)
        {
            PasswordtextBox.UseSystemPasswordChar = true;
            ShowPasswordBox1.Visible = true;
            HidePasswordBox1.Visible = false;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowPasswordBox_Click(object sender, EventArgs e)
        {
            PasswordtextBox.UseSystemPasswordChar = false;
            HidePasswordBox.Visible = true;
            ShowPasswordBox.Visible = false;
        }

        private void ShowPasswordBox1_Click(object sender, EventArgs e)
        {
            PasswordtextBox.UseSystemPasswordChar = false;
            HidePasswordBox1.Visible = true;
            ShowPasswordBox1.Visible = false;
        }

        private void FileChooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All file(*.*)|*.*|png file(*.png)|*.png|jpg file(*.jpg)|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                PictureBox.ImageLocation = imgLocation;
            }
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Active = "Active";
                string regUserName = UsernameTextbox.Text;
                string RegPassword = ConfirmPasswordtextBox.Text;
                regEmail = EmailAdressTxtbox.Text;

                if (regUserName.Equals("") || FirstNametextBox1.Text.Equals("") || LastNametextBox.Text.Equals("") || DateTimePicker.Value.Equals("")
                    || AddresstextBox.Text.Equals("") || CitytextBox.Text.Equals("") || CountrytextBox.Text.Equals("") || PasswordtextBox.Text.Equals("") || RegPassword.Equals("") || ReligionTextBox.Equals("") || IncomecomboBox.SelectedItem.Equals("") || QualificationcomboBox.SelectedItem.Equals("") || OccupationcomboBox.SelectedItem.Equals(""))
                {
                    MessageBox.Show("Fill All The Requried Field.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UsernameTextbox.Select();
                }
                else
                {


                    string mySQL = string.Empty;
                    string mySQL5 = string.Empty;
                    string mySQL6 = string.Empty;

                    String Gender = "";
                    if (MaleradioButton.Checked)
                    {
                        Gender = "Male";
                    }
                    else if (FemaleradioButton.Checked)
                    {
                        Gender = "Female";
                    }
                    else if (OtherradioButton.Checked)
                    {
                        Gender = "Other";
                    }

                    String Marital = "";

                    if (MarriedradioButton.Checked)
                    {
                        Marital = "Married";
                    }
                    else if (UnmarriedradioButton.Checked)
                    {
                        Marital = "Unmarried";
                    }

                    byte[] image = null;
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binary = new BinaryReader(stream);
                    image = binary.ReadBytes((int)stream.Length);

                    mySQL += @"INSERT INTO [dbo].[Parsonal]
                               ([User_name]
                               ,[Password]
                               ,[First_Name]
                               ,[Last_Name]
                               ,[Email_address]
                               ,[Gender]
                               ,[Date_Of_Birth]
                               ,[Marital_Status]
                               ,[Address]
                               ,[City]
                               ,[Country]
                               ,[Religion]
                               ,[Income]
                               ,[Educational_Qualification]
                               ,[Occupation]
                               ,[Account_Type]
                               ,[Profile_picture]
                               ,[Status])
                         VALUES
                                ('" + UsernameTextbox.Text + "', '" + PasswordtextBox.Text + "', '" + FirstNametextBox1.Text + "', '" + LastNametextBox.Text + "', '" + regEmail + "', '" + Gender + "', '" + DateTimePicker.Value + "'" +
                            ", '" + Marital + "', '" + AddresstextBox.Text + "', '" + CitytextBox.Text + "', '" + CountrytextBox.Text + "', '" + ReligionTextBox.Text + "', '" + IncomecomboBox.SelectedItem + "'" +
                            ", '" + QualificationcomboBox.SelectedItem + "', '" + OccupationcomboBox.SelectedItem + "', '" + AccountTypeComboBox.SelectedItem + "', @image, '" + Active + "')";

                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlCommand command = new SqlCommand(mySQL, conn);
                    command.Parameters.AddWithValue("@image", image);

                    double Totalmoney = 0.00;
                    double Withdraw = 0.00;
                    double deposit = 0.00;
                    double transationmoney = 0.00;
                    string transatioTo = null;

                    DateTime dateTimeVariable = DateTime.Now;

                    double Cdepositbalance = 0.00;
                    double Cwithdrawbalance = 0.00;
                    double Ctransferbalance = 0.00;

                    mySQL6 += @"INSERT INTO [dbo].[Current_Transation_Details]
                               ([CUser_Name]
                               ,[Current_Deposit_balance]
                               ,[Current_Withdraw_balance]
                               ,[Current_Transfer_balance])
                         VALUES
                               ('" + UsernameTextbox.Text + "', '" + Cdepositbalance + "', '" + Cwithdrawbalance + "', '" + Ctransferbalance + "')";


                    if (AccountTypeComboBox.SelectedItem.ToString() == "Saving Account")
                    {

                        mySQL5 += @"INSERT INTO [dbo].[Customer_Details]
                               ([FUser_Name]
                               ,[Total_Money]
                               ,[Withdraw_Money]
                               ,[Deposit_Money]
                               ,[Transation_Money]
                               ,[Transation_To]
                               ,[WDate_Time]
                               ,[DDate_Time]
                               ,[TDate_Time]
                               ,[Saving_Time])
                         VALUES
                               ('" + UsernameTextbox.Text + "', '" + Totalmoney + "', '" + Withdraw + "', '" + deposit + "', '" + transationmoney + "', '" + transatioTo + "', '" + dateTimeVariable + "', '" + dateTimeVariable + "', '" + dateTimeVariable + "', '" + SavingAccountDateTimePicker.Value + "')";
                    }
                    else
                    {
                        string nullvalue = null;

                        mySQL5 += @"INSERT INTO [dbo].[Customer_Details]
                               ([FUser_Name]
                               ,[Total_Money]
                               ,[Withdraw_Money]
                               ,[Deposit_Money]
                               ,[Transation_Money]
                               ,[Transation_To]
                               ,[WDate_Time]
                               ,[DDate_Time]
                               ,[TDate_Time]
                                ,[Saving_Time])
                         VALUES
                               ('" + UsernameTextbox.Text + "', '" + Totalmoney + "', '" + Withdraw + "', '" + deposit + "', '" + transationmoney + "', '" + transatioTo + "', '" + dateTimeVariable + "', '" + dateTimeVariable + "', '" + dateTimeVariable + "', '" + nullvalue + "')";
                    }

                    if (PasswordtextBox.Text == RegPassword)
                    {
                        string mySQL1 = string.Empty;
                        string mySQL3 = string.Empty;

                        mySQL1 += "SELECT * FROM Parsonal ";
                        mySQL1 += "WHERE User_name = '" + UsernameTextbox.Text + "' ";

                        DataTable userData2 = ServerConnection.executeSQL(mySQL1);

                        if (userData2.Rows.Count > 0)
                        {
                            MessageBox.Show("User Name " + UsernameTextbox.Text + " Is Already Exist. Try Another One.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            UsernameTextbox.Clear();
                            UsernameTextbox.Select();

                        }
                        else
                        {
                            PictureBox.Image = null;
                            command.ExecuteNonQuery();
                            DataTable userData5 = ServerConnection.executeSQL(mySQL5);
                            DataTable userData6 = ServerConnection.executeSQL(mySQL6);
                            MessageBox.Show("Account Created Successfull", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Password Do Not Match. Enter Same Password.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PasswordtextBox.Clear();
                        ConfirmPasswordtextBox.Clear();
                        PasswordtextBox.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AccountTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AccountTypeComboBox.SelectedItem.ToString() == "Saving Account")
            {
                Yearlabel.Visible = true;
                SavingAccountDateTimePicker.Visible = true;
            }
            else
            {
                Yearlabel.Visible = false;
                SavingAccountDateTimePicker.Visible = false;
            }
        }
    }

}
