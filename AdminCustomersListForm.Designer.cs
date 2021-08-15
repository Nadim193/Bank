
namespace Bank
{
    partial class AdminCustomersListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DepositUserNamepanel = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.ActiveButton = new Guna.UI.WinForms.GunaButton();
            this.DeactiveButton = new Guna.UI.WinForms.GunaButton();
            this.NameTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            this.Deletebutton = new Guna.UI.WinForms.GunaButton();
            this.Namelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.CustomerListdataGridView = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.bankSystemDataBaseDataSet14 = new Bank.BankSystemDataBaseDataSet14();
            this.TotalCustomerslabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bankSystemDataBaseDataSet9 = new Bank.BankSystemDataBaseDataSet9();
            this.parsonalTableAdapter = new Bank.BankSystemDataBaseDataSet14TableAdapters.ParsonalTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DepositUserNamepanel.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parsonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet14)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.DepositUserNamepanel);
            this.panel1.Controls.Add(this.CustomerListdataGridView);
            this.panel1.Controls.Add(this.TotalCustomerslabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 804);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Bank.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(311, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DepositUserNamepanel
            // 
            this.DepositUserNamepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepositUserNamepanel.Controls.Add(this.panel15);
            this.DepositUserNamepanel.Controls.Add(this.label2);
            this.DepositUserNamepanel.Controls.Add(this.panel11);
            this.DepositUserNamepanel.Controls.Add(this.panel7);
            this.DepositUserNamepanel.Location = new System.Drawing.Point(366, 54);
            this.DepositUserNamepanel.Name = "DepositUserNamepanel";
            this.DepositUserNamepanel.Size = new System.Drawing.Size(816, 209);
            this.DepositUserNamepanel.TabIndex = 138;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.ActiveButton);
            this.panel15.Controls.Add(this.DeactiveButton);
            this.panel15.Controls.Add(this.NameTextbox);
            this.panel15.Controls.Add(this.Deletebutton);
            this.panel15.Controls.Add(this.Namelabel);
            this.panel15.Location = new System.Drawing.Point(33, 53);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(782, 155);
            this.panel15.TabIndex = 61;
            // 
            // ActiveButton
            // 
            this.ActiveButton.Animated = true;
            this.ActiveButton.AnimationHoverSpeed = 0.07F;
            this.ActiveButton.AnimationSpeed = 0.03F;
            this.ActiveButton.BackColor = System.Drawing.Color.Transparent;
            this.ActiveButton.BaseColor = System.Drawing.Color.RoyalBlue;
            this.ActiveButton.BorderColor = System.Drawing.Color.Black;
            this.ActiveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActiveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ActiveButton.FocusedColor = System.Drawing.Color.Empty;
            this.ActiveButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveButton.ForeColor = System.Drawing.Color.Black;
            this.ActiveButton.Image = global::Bank.Properties.Resources.active_1;
            this.ActiveButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ActiveButton.Location = new System.Drawing.Point(632, 16);
            this.ActiveButton.Name = "ActiveButton";
            this.ActiveButton.OnHoverBaseColor = System.Drawing.Color.SlateBlue;
            this.ActiveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ActiveButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ActiveButton.OnHoverImage = null;
            this.ActiveButton.OnPressedColor = System.Drawing.Color.Black;
            this.ActiveButton.Radius = 10;
            this.ActiveButton.Size = new System.Drawing.Size(134, 50);
            this.ActiveButton.TabIndex = 136;
            this.ActiveButton.Text = "Active";
            this.ActiveButton.Click += new System.EventHandler(this.ActiveButton_Click);
            // 
            // DeactiveButton
            // 
            this.DeactiveButton.Animated = true;
            this.DeactiveButton.AnimationHoverSpeed = 0.07F;
            this.DeactiveButton.AnimationSpeed = 0.03F;
            this.DeactiveButton.BackColor = System.Drawing.Color.Transparent;
            this.DeactiveButton.BaseColor = System.Drawing.Color.RoyalBlue;
            this.DeactiveButton.BorderColor = System.Drawing.Color.Black;
            this.DeactiveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeactiveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeactiveButton.FocusedColor = System.Drawing.Color.Empty;
            this.DeactiveButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeactiveButton.ForeColor = System.Drawing.Color.Black;
            this.DeactiveButton.Image = global::Bank.Properties.Resources._207_2079206_correct_icon_x_in_red_circle_removebg_preview;
            this.DeactiveButton.ImageSize = new System.Drawing.Size(20, 20);
            this.DeactiveButton.Location = new System.Drawing.Point(632, 86);
            this.DeactiveButton.Name = "DeactiveButton";
            this.DeactiveButton.OnHoverBaseColor = System.Drawing.Color.SlateBlue;
            this.DeactiveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DeactiveButton.OnHoverForeColor = System.Drawing.Color.White;
            this.DeactiveButton.OnHoverImage = null;
            this.DeactiveButton.OnPressedColor = System.Drawing.Color.Black;
            this.DeactiveButton.Radius = 10;
            this.DeactiveButton.Size = new System.Drawing.Size(134, 50);
            this.DeactiveButton.TabIndex = 135;
            this.DeactiveButton.Text = "Deactive";
            this.DeactiveButton.Click += new System.EventHandler(this.DeactiveButton_Click);
            // 
            // NameTextbox
            // 
            this.NameTextbox.BackColor = System.Drawing.SystemColors.Desktop;
            this.NameTextbox.BorderColor = System.Drawing.Color.SteelBlue;
            this.NameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextbox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.NameTextbox.Location = new System.Drawing.Point(11, 38);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(459, 28);
            this.NameTextbox.TabIndex = 68;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Animated = true;
            this.Deletebutton.AnimationHoverSpeed = 0.07F;
            this.Deletebutton.AnimationSpeed = 0.03F;
            this.Deletebutton.BackColor = System.Drawing.Color.Transparent;
            this.Deletebutton.BaseColor = System.Drawing.Color.RoyalBlue;
            this.Deletebutton.BorderColor = System.Drawing.Color.Black;
            this.Deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Deletebutton.FocusedColor = System.Drawing.Color.Empty;
            this.Deletebutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.Black;
            this.Deletebutton.Image = global::Bank.Properties.Resources.delete_1432400_1211078;
            this.Deletebutton.ImageSize = new System.Drawing.Size(20, 20);
            this.Deletebutton.Location = new System.Drawing.Point(476, 86);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.OnHoverBaseColor = System.Drawing.Color.SlateBlue;
            this.Deletebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Deletebutton.OnHoverForeColor = System.Drawing.Color.White;
            this.Deletebutton.OnHoverImage = null;
            this.Deletebutton.OnPressedColor = System.Drawing.Color.Black;
            this.Deletebutton.Radius = 10;
            this.Deletebutton.Size = new System.Drawing.Size(127, 50);
            this.Deletebutton.TabIndex = 134;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Namelabel.Location = new System.Drawing.Point(7, 8);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(114, 24);
            this.Namelabel.TabIndex = 62;
            this.Namelabel.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(28, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 60;
            this.label2.Text = "ACCOUNTS";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel11.Location = new System.Drawing.Point(16, 18);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 30);
            this.panel11.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(814, 5);
            this.panel7.TabIndex = 0;
            // 
            // CustomerListdataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.CustomerListdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerListdataGridView.AutoGenerateColumns = false;
            this.CustomerListdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.CustomerListdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerListdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerListdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerListdataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerListdataGridView.EnableHeadersVisualStyles = false;
            this.CustomerListdataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.CustomerListdataGridView.Location = new System.Drawing.Point(12, 287);
            this.CustomerListdataGridView.Name = "CustomerListdataGridView";
            this.CustomerListdataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerListdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerListdataGridView.RowTemplate.Height = 24;
            this.CustomerListdataGridView.Size = new System.Drawing.Size(1183, 488);
            this.CustomerListdataGridView.TabIndex = 137;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User_Name";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
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
            this.parsonalBindingSource.DataSource = this.bankSystemDataBaseDataSet14;
            // 
            // bankSystemDataBaseDataSet14
            // 
            this.bankSystemDataBaseDataSet14.DataSetName = "BankSystemDataBaseDataSet14";
            this.bankSystemDataBaseDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TotalCustomerslabel
            // 
            this.TotalCustomerslabel.AutoSize = true;
            this.TotalCustomerslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCustomerslabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TotalCustomerslabel.Location = new System.Drawing.Point(59, 122);
            this.TotalCustomerslabel.Name = "TotalCustomerslabel";
            this.TotalCustomerslabel.Size = new System.Drawing.Size(106, 29);
            this.TotalCustomerslabel.TabIndex = 78;
            this.TotalCustomerslabel.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(59, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 29);
            this.label3.TabIndex = 77;
            this.label3.Text = "TOTAL CUSTOMERS";
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
            this.panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bank.Properties.Resources.customer_customer_icon_146530250_removebg_preview;
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
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER\'S LIST";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 799);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1207, 5);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bankSystemDataBaseDataSet9
            // 
            this.bankSystemDataBaseDataSet9.DataSetName = "BankSystemDataBaseDataSet9";
            this.bankSystemDataBaseDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parsonalTableAdapter
            // 
            this.parsonalTableAdapter.ClearBeforeFill = true;
            // 
            // AdminCustomersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 804);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminCustomersListForm";
            this.Text = "AdminCustomersListForm";
            this.Load += new System.EventHandler(this.AdminCustomersListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DepositUserNamepanel.ResumeLayout(false);
            this.DepositUserNamepanel.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parsonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet14)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label TotalCustomerslabel;
        private System.Windows.Forms.Label label3;
        private BankSystemDataBaseDataSet9 bankSystemDataBaseDataSet9;
        private System.Windows.Forms.DataGridView CustomerListdataGridView;
        private BankSystemDataBaseDataSet14 bankSystemDataBaseDataSet14;
        private System.Windows.Forms.BindingSource parsonalBindingSource;
        private BankSystemDataBaseDataSet14TableAdapters.ParsonalTableAdapter parsonalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Panel DepositUserNamepanel;
        private System.Windows.Forms.Panel panel15;
        private Guna.UI.WinForms.GunaButton DeactiveButton;
        private Bunifu.Framework.BunifuCustomTextbox NameTextbox;
        private Guna.UI.WinForms.GunaButton Deletebutton;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI.WinForms.GunaButton ActiveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}