
namespace Bank
{
    partial class AdminSearchAccountForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.DepositUserNamepanel = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.GenderComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.NationalityComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.NameTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            this.SearchButton = new System.Windows.Forms.PictureBox();
            this.SearchComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.parsonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataBaseDataSet15 = new Bank.BankSystemDataBaseDataSet15();
            this.bankSystemDataBaseDataSet7 = new Bank.BankSystemDataBaseDataSet7();
            this.bankSystemDataBaseDataSet8 = new Bank.BankSystemDataBaseDataSet8();
            this.parsonalTableAdapter = new Bank.BankSystemDataBaseDataSet15TableAdapters.ParsonalTableAdapter();
            this.OccupationComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.DepositUserNamepanel.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parsonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.DepositUserNamepanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 804);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(26, 337);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1159, 440);
            this.dataGridView.TabIndex = 136;
            // 
            // DepositUserNamepanel
            // 
            this.DepositUserNamepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepositUserNamepanel.Controls.Add(this.panel15);
            this.DepositUserNamepanel.Controls.Add(this.label2);
            this.DepositUserNamepanel.Controls.Add(this.panel11);
            this.DepositUserNamepanel.Controls.Add(this.panel7);
            this.DepositUserNamepanel.Location = new System.Drawing.Point(26, 92);
            this.DepositUserNamepanel.Name = "DepositUserNamepanel";
            this.DepositUserNamepanel.Size = new System.Drawing.Size(1160, 227);
            this.DepositUserNamepanel.TabIndex = 10;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.OccupationComboBox);
            this.panel15.Controls.Add(this.GenderComboBox);
            this.panel15.Controls.Add(this.NationalityComboBox);
            this.panel15.Controls.Add(this.NameTextbox);
            this.panel15.Controls.Add(this.SearchButton);
            this.panel15.Controls.Add(this.SearchComboBox);
            this.panel15.Controls.Add(this.Namelabel);
            this.panel15.Location = new System.Drawing.Point(33, 71);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1126, 155);
            this.panel15.TabIndex = 61;
            this.panel15.Paint += new System.Windows.Forms.PaintEventHandler(this.panel15_Paint);
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.GenderComboBox.BaseColor = System.Drawing.SystemColors.Desktop;
            this.GenderComboBox.BorderColor = System.Drawing.Color.Silver;
            this.GenderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.GenderComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderComboBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(11, 44);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.OnHoverItemBaseColor = System.Drawing.Color.LightSteelBlue;
            this.GenderComboBox.OnHoverItemForeColor = System.Drawing.Color.RoyalBlue;
            this.GenderComboBox.Size = new System.Drawing.Size(459, 32);
            this.GenderComboBox.TabIndex = 137;
            this.GenderComboBox.Visible = false;
            // 
            // NationalityComboBox
            // 
            this.NationalityComboBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.NationalityComboBox.BaseColor = System.Drawing.SystemColors.Desktop;
            this.NationalityComboBox.BorderColor = System.Drawing.Color.Silver;
            this.NationalityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NationalityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NationalityComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.NationalityComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalityComboBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.NationalityComboBox.FormattingEnabled = true;
            this.NationalityComboBox.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Argentina",
            "Australia",
            "Bangladesh",
            "Belgium",
            "Bolivia",
            "Brazil",
            "Cambodia",
            "Canada",
            "Chile",
            "China",
            "Costa Rica",
            "Denmark\tDanish",
            "Ecuador",
            "Egypt",
            "England",
            "France",
            "Germany",
            "Hungary",
            "India",
            "Indonesia",
            "Iran",
            "Italy",
            "Malaysia",
            "Mexico",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Pakistan",
            "Philippines",
            "Saudi Arabia",
            "Spain",
            "Sweden",
            "Switzerland",
            "(The) United Kingdom",
            "(The) United States\tAmerican ",
            "Zambia",
            "Zimbabwe"});
            this.NationalityComboBox.Location = new System.Drawing.Point(11, 44);
            this.NationalityComboBox.Name = "NationalityComboBox";
            this.NationalityComboBox.OnHoverItemBaseColor = System.Drawing.Color.LightSteelBlue;
            this.NationalityComboBox.OnHoverItemForeColor = System.Drawing.Color.RoyalBlue;
            this.NationalityComboBox.Size = new System.Drawing.Size(459, 32);
            this.NationalityComboBox.TabIndex = 136;
            this.NationalityComboBox.Visible = false;
            this.NationalityComboBox.SelectedIndexChanged += new System.EventHandler(this.NationalityComboBox_SelectedIndexChanged);
            // 
            // NameTextbox
            // 
            this.NameTextbox.BackColor = System.Drawing.SystemColors.Desktop;
            this.NameTextbox.BorderColor = System.Drawing.Color.SteelBlue;
            this.NameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextbox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.NameTextbox.Location = new System.Drawing.Point(11, 44);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(459, 28);
            this.NameTextbox.TabIndex = 68;
            // 
            // SearchButton
            // 
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Image = global::Bank.Properties.Resources.png_clipart_computer_icons_android_web_search_engine_google_search_search_box_google_search_bar_blue_trademark_removebg_preview;
            this.SearchButton.Location = new System.Drawing.Point(717, 90);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(85, 50);
            this.SearchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchButton.TabIndex = 62;
            this.SearchButton.TabStop = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.SearchComboBox.BaseColor = System.Drawing.SystemColors.Desktop;
            this.SearchComboBox.BorderColor = System.Drawing.Color.Silver;
            this.SearchComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.SearchComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchComboBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Items.AddRange(new object[] {
            "-By First Name",
            "-By Last Name",
            "-By Nationality",
            "-By Email",
            "-By Occupation",
            "-By Status",
            "-By Gender",
            "-By Account Type",
            "- By All"});
            this.SearchComboBox.Location = new System.Drawing.Point(498, 42);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.OnHoverItemBaseColor = System.Drawing.Color.LightSteelBlue;
            this.SearchComboBox.OnHoverItemForeColor = System.Drawing.Color.RoyalBlue;
            this.SearchComboBox.Size = new System.Drawing.Size(304, 32);
            this.SearchComboBox.TabIndex = 69;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Namelabel.Location = new System.Drawing.Point(7, 13);
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
            this.label2.Size = new System.Drawing.Size(311, 29);
            this.label2.TabIndex = 60;
            this.label2.Text = "SEARCH FOR ACCOUNT";
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
            this.panel7.Size = new System.Drawing.Size(1158, 5);
            this.panel7.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1207, 49);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bank.Properties.Resources._599350;
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
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEARCH ACCOUNT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 799);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1207, 5);
            this.panel2.TabIndex = 0;
            // 
            // parsonalBindingSource
            // 
            this.parsonalBindingSource.DataMember = "Parsonal";
            this.parsonalBindingSource.DataSource = this.bankSystemDataBaseDataSet15;
            // 
            // bankSystemDataBaseDataSet15
            // 
            this.bankSystemDataBaseDataSet15.DataSetName = "BankSystemDataBaseDataSet15";
            this.bankSystemDataBaseDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankSystemDataBaseDataSet7
            // 
            this.bankSystemDataBaseDataSet7.DataSetName = "BankSystemDataBaseDataSet7";
            this.bankSystemDataBaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankSystemDataBaseDataSet8
            // 
            this.bankSystemDataBaseDataSet8.DataSetName = "BankSystemDataBaseDataSet8";
            this.bankSystemDataBaseDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parsonalTableAdapter
            // 
            this.parsonalTableAdapter.ClearBeforeFill = true;
            // 
            // OccupationComboBox
            // 
            this.OccupationComboBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.OccupationComboBox.BaseColor = System.Drawing.SystemColors.Desktop;
            this.OccupationComboBox.BorderColor = System.Drawing.Color.Silver;
            this.OccupationComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OccupationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OccupationComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.OccupationComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OccupationComboBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.OccupationComboBox.FormattingEnabled = true;
            this.OccupationComboBox.Items.AddRange(new object[] {
            "Salaried",
            "Self-Employed",
            "Business",
            "Student",
            "Retired",
            "Other"});
            this.OccupationComboBox.Location = new System.Drawing.Point(11, 44);
            this.OccupationComboBox.Name = "OccupationComboBox";
            this.OccupationComboBox.OnHoverItemBaseColor = System.Drawing.Color.LightSteelBlue;
            this.OccupationComboBox.OnHoverItemForeColor = System.Drawing.Color.RoyalBlue;
            this.OccupationComboBox.Size = new System.Drawing.Size(459, 32);
            this.OccupationComboBox.TabIndex = 138;
            this.OccupationComboBox.Visible = false;
            // 
            // AdminSearchAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1207, 804);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSearchAccountForm";
            this.Text = "AdminSearchAccountForm";
            this.Load += new System.EventHandler(this.AdminSearchAccountForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.DepositUserNamepanel.ResumeLayout(false);
            this.DepositUserNamepanel.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parsonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel DepositUserNamepanel;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox SearchButton;
        private Guna.UI.WinForms.GunaComboBox SearchComboBox;
        private Bunifu.Framework.BunifuCustomTextbox NameTextbox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel7;
        private BankSystemDataBaseDataSet7 bankSystemDataBaseDataSet7;
        private BankSystemDataBaseDataSet8 bankSystemDataBaseDataSet8;
        private Guna.UI.WinForms.GunaComboBox NationalityComboBox;
        private Guna.UI.WinForms.GunaComboBox GenderComboBox;
        private BankSystemDataBaseDataSet15 bankSystemDataBaseDataSet15;
        private System.Windows.Forms.BindingSource parsonalBindingSource;
        private BankSystemDataBaseDataSet15TableAdapters.ParsonalTableAdapter parsonalTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
        private Guna.UI.WinForms.GunaComboBox OccupationComboBox;
    }
}