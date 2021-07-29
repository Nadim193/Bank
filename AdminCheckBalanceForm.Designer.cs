
namespace Bank
{
    partial class AdminCheckBalanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerListdataGridView = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationalQualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilepictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parsonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataBaseDataSet13 = new Bank.BankSystemDataBaseDataSet13();
            this.CustomersListlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WithdrawUserNamepanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchAccountButton = new System.Windows.Forms.PictureBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.UseNameTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.WithdrawCurrentAmmountpanel = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.CurrentBalancelabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.WithdrawLastNamepanel = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.LastNamelabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.WithdrawFirstNamepanel = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.FirstNamelabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.parsonalTableAdapter = new Bank.BankSystemDataBaseDataSet13TableAdapters.ParsonalTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parsonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet13)).BeginInit();
            this.WithdrawUserNamepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchAccountButton)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel5.SuspendLayout();
            this.WithdrawCurrentAmmountpanel.SuspendLayout();
            this.WithdrawLastNamepanel.SuspendLayout();
            this.WithdrawFirstNamepanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.CustomerListdataGridView);
            this.panel1.Controls.Add(this.CustomersListlabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.WithdrawUserNamepanel);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 804);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CustomerListdataGridView
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.CustomerListdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.CustomerListdataGridView.AutoGenerateColumns = false;
            this.CustomerListdataGridView.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.CustomerListdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerListdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.CustomerListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerListdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailaddressDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.religionDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.educationalQualificationDataGridViewTextBoxColumn,
            this.occupationDataGridViewTextBoxColumn,
            this.accountTypeDataGridViewTextBoxColumn,
            this.profilepictureDataGridViewImageColumn,
            this.statusDataGridViewTextBoxColumn});
            this.CustomerListdataGridView.DataSource = this.parsonalBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerListdataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.CustomerListdataGridView.EnableHeadersVisualStyles = false;
            this.CustomerListdataGridView.Location = new System.Drawing.Point(567, 162);
            this.CustomerListdataGridView.Name = "CustomerListdataGridView";
            this.CustomerListdataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerListdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.CustomerListdataGridView.RowTemplate.Height = 24;
            this.CustomerListdataGridView.Size = new System.Drawing.Size(628, 594);
            this.CustomerListdataGridView.TabIndex = 136;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User_Name";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailaddressDataGridViewTextBoxColumn
            // 
            this.emailaddressDataGridViewTextBoxColumn.DataPropertyName = "Email_address";
            this.emailaddressDataGridViewTextBoxColumn.HeaderText = "Email_address";
            this.emailaddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailaddressDataGridViewTextBoxColumn.Name = "emailaddressDataGridViewTextBoxColumn";
            this.emailaddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "Marital_Status";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "Marital_Status";
            this.maritalStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            this.maritalStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 125;
            // 
            // religionDataGridViewTextBoxColumn
            // 
            this.religionDataGridViewTextBoxColumn.DataPropertyName = "Religion";
            this.religionDataGridViewTextBoxColumn.HeaderText = "Religion";
            this.religionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.religionDataGridViewTextBoxColumn.Name = "religionDataGridViewTextBoxColumn";
            this.religionDataGridViewTextBoxColumn.Width = 125;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "Income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Income";
            this.incomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            this.incomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // educationalQualificationDataGridViewTextBoxColumn
            // 
            this.educationalQualificationDataGridViewTextBoxColumn.DataPropertyName = "Educational_Qualification";
            this.educationalQualificationDataGridViewTextBoxColumn.HeaderText = "Educational_Qualification";
            this.educationalQualificationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.educationalQualificationDataGridViewTextBoxColumn.Name = "educationalQualificationDataGridViewTextBoxColumn";
            this.educationalQualificationDataGridViewTextBoxColumn.Width = 125;
            // 
            // occupationDataGridViewTextBoxColumn
            // 
            this.occupationDataGridViewTextBoxColumn.DataPropertyName = "Occupation";
            this.occupationDataGridViewTextBoxColumn.HeaderText = "Occupation";
            this.occupationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.occupationDataGridViewTextBoxColumn.Name = "occupationDataGridViewTextBoxColumn";
            this.occupationDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "Account_Type";
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "Account_Type";
            this.accountTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            this.accountTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // profilepictureDataGridViewImageColumn
            // 
            this.profilepictureDataGridViewImageColumn.DataPropertyName = "Profile_picture";
            this.profilepictureDataGridViewImageColumn.HeaderText = "Profile_picture";
            this.profilepictureDataGridViewImageColumn.MinimumWidth = 6;
            this.profilepictureDataGridViewImageColumn.Name = "profilepictureDataGridViewImageColumn";
            this.profilepictureDataGridViewImageColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // parsonalBindingSource
            // 
            this.parsonalBindingSource.DataMember = "Parsonal";
            this.parsonalBindingSource.DataSource = this.bankSystemDataBaseDataSet13;
            // 
            // bankSystemDataBaseDataSet13
            // 
            this.bankSystemDataBaseDataSet13.DataSetName = "BankSystemDataBaseDataSet13";
            this.bankSystemDataBaseDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustomersListlabel
            // 
            this.CustomersListlabel.AutoSize = true;
            this.CustomersListlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersListlabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CustomersListlabel.Location = new System.Drawing.Point(596, 98);
            this.CustomersListlabel.Name = "CustomersListlabel";
            this.CustomersListlabel.Size = new System.Drawing.Size(106, 29);
            this.CustomersListlabel.TabIndex = 76;
            this.CustomersListlabel.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(596, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 29);
            this.label3.TabIndex = 75;
            this.label3.Text = "TOTAL CUSTOMERS";
            // 
            // WithdrawUserNamepanel
            // 
            this.WithdrawUserNamepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WithdrawUserNamepanel.Controls.Add(this.label2);
            this.WithdrawUserNamepanel.Controls.Add(this.SearchAccountButton);
            this.WithdrawUserNamepanel.Controls.Add(this.panel15);
            this.WithdrawUserNamepanel.Controls.Add(this.panel11);
            this.WithdrawUserNamepanel.Controls.Add(this.panel7);
            this.WithdrawUserNamepanel.Location = new System.Drawing.Point(33, 166);
            this.WithdrawUserNamepanel.Name = "WithdrawUserNamepanel";
            this.WithdrawUserNamepanel.Size = new System.Drawing.Size(503, 230);
            this.WithdrawUserNamepanel.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(27, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 29);
            this.label2.TabIndex = 74;
            this.label2.Text = "SEARCH FOR ACCOUNT";
            // 
            // SearchAccountButton
            // 
            this.SearchAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchAccountButton.Image = global::Bank.Properties.Resources.png_clipart_computer_icons_android_web_search_engine_google_search_search_box_google_search_bar_blue_trademark_removebg_preview;
            this.SearchAccountButton.Location = new System.Drawing.Point(398, 171);
            this.SearchAccountButton.Name = "SearchAccountButton";
            this.SearchAccountButton.Size = new System.Drawing.Size(85, 50);
            this.SearchAccountButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchAccountButton.TabIndex = 73;
            this.SearchAccountButton.TabStop = false;
            this.SearchAccountButton.Click += new System.EventHandler(this.SearchAccountButton_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.UseNameTextbox);
            this.panel15.Controls.Add(this.label7);
            this.panel15.Location = new System.Drawing.Point(33, 77);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(469, 86);
            this.panel15.TabIndex = 61;
            // 
            // UseNameTextbox
            // 
            this.UseNameTextbox.BackColor = System.Drawing.SystemColors.Desktop;
            this.UseNameTextbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.UseNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseNameTextbox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.UseNameTextbox.Location = new System.Drawing.Point(9, 41);
            this.UseNameTextbox.Name = "UseNameTextbox";
            this.UseNameTextbox.Size = new System.Drawing.Size(460, 28);
            this.UseNameTextbox.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(5, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 62;
            this.label7.Text = "User Name";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel11.Location = new System.Drawing.Point(16, 18);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 30);
            this.panel11.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(501, 5);
            this.panel7.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.WithdrawCurrentAmmountpanel);
            this.panel5.Controls.Add(this.WithdrawLastNamepanel);
            this.panel5.Controls.Add(this.WithdrawFirstNamepanel);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.panel13);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Location = new System.Drawing.Point(33, 526);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(503, 230);
            this.panel5.TabIndex = 71;
            // 
            // WithdrawCurrentAmmountpanel
            // 
            this.WithdrawCurrentAmmountpanel.Controls.Add(this.panel23);
            this.WithdrawCurrentAmmountpanel.Controls.Add(this.CurrentBalancelabel);
            this.WithdrawCurrentAmmountpanel.Controls.Add(this.label11);
            this.WithdrawCurrentAmmountpanel.Location = new System.Drawing.Point(28, 178);
            this.WithdrawCurrentAmmountpanel.Name = "WithdrawCurrentAmmountpanel";
            this.WithdrawCurrentAmmountpanel.Size = new System.Drawing.Size(474, 36);
            this.WithdrawCurrentAmmountpanel.TabIndex = 66;
            this.WithdrawCurrentAmmountpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.WithdrawCurrentAmmountpanel_Paint);
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.SteelBlue;
            this.panel23.Location = new System.Drawing.Point(161, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(2, 36);
            this.panel23.TabIndex = 10;
            // 
            // CurrentBalancelabel
            // 
            this.CurrentBalancelabel.AutoSize = true;
            this.CurrentBalancelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalancelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CurrentBalancelabel.Location = new System.Drawing.Point(176, 6);
            this.CurrentBalancelabel.Name = "CurrentBalancelabel";
            this.CurrentBalancelabel.Size = new System.Drawing.Size(85, 24);
            this.CurrentBalancelabel.TabIndex = 64;
            this.CurrentBalancelabel.Text = "Balance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(6, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 24);
            this.label11.TabIndex = 63;
            this.label11.Text = "Balance";
            // 
            // WithdrawLastNamepanel
            // 
            this.WithdrawLastNamepanel.Controls.Add(this.panel22);
            this.WithdrawLastNamepanel.Controls.Add(this.LastNamelabel);
            this.WithdrawLastNamepanel.Controls.Add(this.label10);
            this.WithdrawLastNamepanel.Location = new System.Drawing.Point(28, 122);
            this.WithdrawLastNamepanel.Name = "WithdrawLastNamepanel";
            this.WithdrawLastNamepanel.Size = new System.Drawing.Size(474, 36);
            this.WithdrawLastNamepanel.TabIndex = 65;
            this.WithdrawLastNamepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.WithdrawLastNamepanel_Paint);
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.SteelBlue;
            this.panel22.Location = new System.Drawing.Point(161, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(2, 36);
            this.panel22.TabIndex = 65;
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.AutoSize = true;
            this.LastNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LastNamelabel.Location = new System.Drawing.Point(176, 6);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(108, 24);
            this.LastNamelabel.TabIndex = 64;
            this.LastNamelabel.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(6, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 24);
            this.label10.TabIndex = 63;
            this.label10.Text = "Last Name";
            // 
            // WithdrawFirstNamepanel
            // 
            this.WithdrawFirstNamepanel.Controls.Add(this.panel21);
            this.WithdrawFirstNamepanel.Controls.Add(this.FirstNamelabel);
            this.WithdrawFirstNamepanel.Controls.Add(this.label9);
            this.WithdrawFirstNamepanel.Location = new System.Drawing.Point(28, 66);
            this.WithdrawFirstNamepanel.Name = "WithdrawFirstNamepanel";
            this.WithdrawFirstNamepanel.Size = new System.Drawing.Size(474, 36);
            this.WithdrawFirstNamepanel.TabIndex = 64;
            this.WithdrawFirstNamepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.WithdrawFirstNamepanel_Paint);
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.SteelBlue;
            this.panel21.Location = new System.Drawing.Point(161, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(2, 36);
            this.panel21.TabIndex = 9;
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.AutoSize = true;
            this.FirstNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNamelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FirstNamelabel.Location = new System.Drawing.Point(176, 6);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(111, 24);
            this.FirstNamelabel.TabIndex = 64;
            this.FirstNamelabel.Text = "First Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(6, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 24);
            this.label9.TabIndex = 63;
            this.label9.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(23, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 29);
            this.label4.TabIndex = 62;
            this.label4.Text = "PERSONAL INFORMATION";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel13.Location = new System.Drawing.Point(11, 18);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(5, 30);
            this.panel13.TabIndex = 61;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(501, 5);
            this.panel9.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1207, 49);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bank.Properties.Resources.balance_check_1_974285;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHECK BALANCE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 799);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1207, 5);
            this.panel3.TabIndex = 1;
            // 
            // parsonalTableAdapter
            // 
            this.parsonalTableAdapter.ClearBeforeFill = true;
            // 
            // AdminCheckBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 804);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminCheckBalanceForm";
            this.Text = "AdminCheckBalanceForm";
            this.Load += new System.EventHandler(this.AdminCheckBalanceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parsonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet13)).EndInit();
            this.WithdrawUserNamepanel.ResumeLayout(false);
            this.WithdrawUserNamepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchAccountButton)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.WithdrawCurrentAmmountpanel.ResumeLayout(false);
            this.WithdrawCurrentAmmountpanel.PerformLayout();
            this.WithdrawLastNamepanel.ResumeLayout(false);
            this.WithdrawLastNamepanel.PerformLayout();
            this.WithdrawFirstNamepanel.ResumeLayout(false);
            this.WithdrawFirstNamepanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel WithdrawUserNamepanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox SearchAccountButton;
        private System.Windows.Forms.Panel panel15;
        private Bunifu.Framework.BunifuCustomTextbox UseNameTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel WithdrawCurrentAmmountpanel;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label CurrentBalancelabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel WithdrawLastNamepanel;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label LastNamelabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel WithdrawFirstNamepanel;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label FirstNamelabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label CustomersListlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView CustomerListdataGridView;
        private BankSystemDataBaseDataSet13 bankSystemDataBaseDataSet13;
        private System.Windows.Forms.BindingSource parsonalBindingSource;
        private BankSystemDataBaseDataSet13TableAdapters.ParsonalTableAdapter parsonalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationalQualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn profilepictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}