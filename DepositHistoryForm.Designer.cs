
namespace Bank
{
    partial class DepositHistoryForm
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.HDepositTimepanel = new System.Windows.Forms.Panel();
            this.HDepositTimelabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HDepositMoneypanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.HDepositMoneylabel = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.DepositTimeBalancePanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.HDepositBalancelabel = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.FromParsonalpanel = new System.Windows.Forms.Panel();
            this.FromParsonalBalancepanel = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.FromParsonalBalancelabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FromParsonalLastNamepanel = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.FromParsonalLastNamlabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FromParsonalFirstNamepanel = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.FromParsonalFirstNamlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TotalBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DepositNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DepositdataGridView = new System.Windows.Forms.DataGridView();
            this.fieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositHistoryviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataBaseDataSet3 = new Bank.BankSystemDataBaseDataSet3();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deposit_History_viewTableAdapter = new Bank.BankSystemDataBaseDataSet3TableAdapters.Deposit_History_viewTableAdapter();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.HDepositTimepanel.SuspendLayout();
            this.HDepositMoneypanel.SuspendLayout();
            this.DepositTimeBalancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.FromParsonalpanel.SuspendLayout();
            this.FromParsonalBalancepanel.SuspendLayout();
            this.FromParsonalLastNamepanel.SuspendLayout();
            this.FromParsonalFirstNamepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepositdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositHistoryviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.FromParsonalpanel);
            this.panel1.Controls.Add(this.TotalBalance);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DepositNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DepositdataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 804);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.HDepositTimepanel);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.HDepositMoneypanel);
            this.panel7.Controls.Add(this.panel14);
            this.panel7.Controls.Add(this.DepositTimeBalancePanel);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.pictureBox11);
            this.panel7.Location = new System.Drawing.Point(607, 168);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(590, 268);
            this.panel7.TabIndex = 86;
            // 
            // HDepositTimepanel
            // 
            this.HDepositTimepanel.Controls.Add(this.HDepositTimelabel);
            this.HDepositTimepanel.Controls.Add(this.label12);
            this.HDepositTimepanel.Location = new System.Drawing.Point(130, 195);
            this.HDepositTimepanel.Name = "HDepositTimepanel";
            this.HDepositTimepanel.Size = new System.Drawing.Size(459, 33);
            this.HDepositTimepanel.TabIndex = 71;
            this.HDepositTimepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HDepositTimepanel_Paint);
            // 
            // HDepositTimelabel
            // 
            this.HDepositTimelabel.AutoSize = true;
            this.HDepositTimelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDepositTimelabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.HDepositTimelabel.Location = new System.Drawing.Point(225, 5);
            this.HDepositTimelabel.Name = "HDepositTimelabel";
            this.HDepositTimelabel.Size = new System.Drawing.Size(57, 24);
            this.HDepositTimelabel.TabIndex = 68;
            this.HDepositTimelabel.Text = "Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrange;
            this.label12.Location = new System.Drawing.Point(3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 24);
            this.label12.TabIndex = 67;
            this.label12.Text = "> Deposit Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(24, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 29);
            this.label2.TabIndex = 61;
            this.label2.Text = "DEPOSIT HISTORY";
            // 
            // HDepositMoneypanel
            // 
            this.HDepositMoneypanel.Controls.Add(this.label13);
            this.HDepositMoneypanel.Controls.Add(this.HDepositMoneylabel);
            this.HDepositMoneypanel.Location = new System.Drawing.Point(131, 139);
            this.HDepositMoneypanel.Name = "HDepositMoneypanel";
            this.HDepositMoneypanel.Size = new System.Drawing.Size(458, 33);
            this.HDepositMoneypanel.TabIndex = 72;
            this.HDepositMoneypanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HDepositMoneypanel_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkOrange;
            this.label13.Location = new System.Drawing.Point(4, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 24);
            this.label13.TabIndex = 63;
            this.label13.Text = "> Deposit Money";
            // 
            // HDepositMoneylabel
            // 
            this.HDepositMoneylabel.AutoSize = true;
            this.HDepositMoneylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDepositMoneylabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.HDepositMoneylabel.Location = new System.Drawing.Point(225, 5);
            this.HDepositMoneylabel.Name = "HDepositMoneylabel";
            this.HDepositMoneylabel.Size = new System.Drawing.Size(73, 24);
            this.HDepositMoneylabel.TabIndex = 64;
            this.HDepositMoneylabel.Text = "Money";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.ForestGreen;
            this.panel14.Location = new System.Drawing.Point(13, 19);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(5, 30);
            this.panel14.TabIndex = 60;
            // 
            // DepositTimeBalancePanel
            // 
            this.DepositTimeBalancePanel.Controls.Add(this.label15);
            this.DepositTimeBalancePanel.Controls.Add(this.HDepositBalancelabel);
            this.DepositTimeBalancePanel.Location = new System.Drawing.Point(130, 81);
            this.DepositTimeBalancePanel.Name = "DepositTimeBalancePanel";
            this.DepositTimeBalancePanel.Size = new System.Drawing.Size(459, 33);
            this.DepositTimeBalancePanel.TabIndex = 70;
            this.DepositTimeBalancePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DepositTimeBalancePanel_Paint);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkOrange;
            this.label15.Location = new System.Drawing.Point(4, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 24);
            this.label15.TabIndex = 61;
            this.label15.Text = "> Balance";
            // 
            // HDepositBalancelabel
            // 
            this.HDepositBalancelabel.AutoSize = true;
            this.HDepositBalancelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDepositBalancelabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.HDepositBalancelabel.Location = new System.Drawing.Point(226, 5);
            this.HDepositBalancelabel.Name = "HDepositBalancelabel";
            this.HDepositBalancelabel.Size = new System.Drawing.Size(85, 24);
            this.HDepositBalancelabel.TabIndex = 62;
            this.HDepositBalancelabel.Text = "Balance";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.ForestGreen;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(588, 5);
            this.panel10.TabIndex = 1;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Bank.Properties.Resources.Screenshot_2021_07_15_231152_removebg_preview;
            this.pictureBox11.Location = new System.Drawing.Point(7, 83);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(106, 92);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 69;
            this.pictureBox11.TabStop = false;
            // 
            // FromParsonalpanel
            // 
            this.FromParsonalpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FromParsonalpanel.Controls.Add(this.FromParsonalBalancepanel);
            this.FromParsonalpanel.Controls.Add(this.FromParsonalLastNamepanel);
            this.FromParsonalpanel.Controls.Add(this.FromParsonalFirstNamepanel);
            this.FromParsonalpanel.Controls.Add(this.label8);
            this.FromParsonalpanel.Controls.Add(this.panel3);
            this.FromParsonalpanel.Controls.Add(this.panel5);
            this.FromParsonalpanel.Location = new System.Drawing.Point(606, 506);
            this.FromParsonalpanel.Name = "FromParsonalpanel";
            this.FromParsonalpanel.Size = new System.Drawing.Size(591, 230);
            this.FromParsonalpanel.TabIndex = 85;
            // 
            // FromParsonalBalancepanel
            // 
            this.FromParsonalBalancepanel.Controls.Add(this.panel23);
            this.FromParsonalBalancepanel.Controls.Add(this.FromParsonalBalancelabel);
            this.FromParsonalBalancepanel.Controls.Add(this.label5);
            this.FromParsonalBalancepanel.Location = new System.Drawing.Point(28, 178);
            this.FromParsonalBalancepanel.Name = "FromParsonalBalancepanel";
            this.FromParsonalBalancepanel.Size = new System.Drawing.Size(562, 36);
            this.FromParsonalBalancepanel.TabIndex = 66;
            this.FromParsonalBalancepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FromParsonalBalancepanel_Paint);
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.Wheat;
            this.panel23.Location = new System.Drawing.Point(223, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(2, 36);
            this.panel23.TabIndex = 10;
            // 
            // FromParsonalBalancelabel
            // 
            this.FromParsonalBalancelabel.AutoSize = true;
            this.FromParsonalBalancelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromParsonalBalancelabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.FromParsonalBalancelabel.Location = new System.Drawing.Point(328, 7);
            this.FromParsonalBalancelabel.Name = "FromParsonalBalancelabel";
            this.FromParsonalBalancelabel.Size = new System.Drawing.Size(85, 24);
            this.FromParsonalBalancelabel.TabIndex = 64;
            this.FromParsonalBalancelabel.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 63;
            this.label5.Text = "Balance";
            // 
            // FromParsonalLastNamepanel
            // 
            this.FromParsonalLastNamepanel.Controls.Add(this.panel22);
            this.FromParsonalLastNamepanel.Controls.Add(this.FromParsonalLastNamlabel);
            this.FromParsonalLastNamepanel.Controls.Add(this.label10);
            this.FromParsonalLastNamepanel.Location = new System.Drawing.Point(28, 122);
            this.FromParsonalLastNamepanel.Name = "FromParsonalLastNamepanel";
            this.FromParsonalLastNamepanel.Size = new System.Drawing.Size(562, 36);
            this.FromParsonalLastNamepanel.TabIndex = 65;
            this.FromParsonalLastNamepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FromParsonalLastNamepanel_Paint);
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.Wheat;
            this.panel22.Location = new System.Drawing.Point(223, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(2, 36);
            this.panel22.TabIndex = 65;
            // 
            // FromParsonalLastNamlabel
            // 
            this.FromParsonalLastNamlabel.AutoSize = true;
            this.FromParsonalLastNamlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromParsonalLastNamlabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.FromParsonalLastNamlabel.Location = new System.Drawing.Point(329, 7);
            this.FromParsonalLastNamlabel.Name = "FromParsonalLastNamlabel";
            this.FromParsonalLastNamlabel.Size = new System.Drawing.Size(108, 24);
            this.FromParsonalLastNamlabel.TabIndex = 64;
            this.FromParsonalLastNamlabel.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label10.Location = new System.Drawing.Point(6, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 24);
            this.label10.TabIndex = 63;
            this.label10.Text = "Last Name";
            // 
            // FromParsonalFirstNamepanel
            // 
            this.FromParsonalFirstNamepanel.Controls.Add(this.panel21);
            this.FromParsonalFirstNamepanel.Controls.Add(this.FromParsonalFirstNamlabel);
            this.FromParsonalFirstNamepanel.Controls.Add(this.label6);
            this.FromParsonalFirstNamepanel.Location = new System.Drawing.Point(28, 66);
            this.FromParsonalFirstNamepanel.Name = "FromParsonalFirstNamepanel";
            this.FromParsonalFirstNamepanel.Size = new System.Drawing.Size(562, 36);
            this.FromParsonalFirstNamepanel.TabIndex = 64;
            this.FromParsonalFirstNamepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FromParsonalFirstNamepanel_Paint);
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Wheat;
            this.panel21.Location = new System.Drawing.Point(223, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(2, 36);
            this.panel21.TabIndex = 9;
            // 
            // FromParsonalFirstNamlabel
            // 
            this.FromParsonalFirstNamlabel.AutoSize = true;
            this.FromParsonalFirstNamlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromParsonalFirstNamlabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.FromParsonalFirstNamlabel.Location = new System.Drawing.Point(329, 6);
            this.FromParsonalFirstNamlabel.Name = "FromParsonalFirstNamlabel";
            this.FromParsonalFirstNamlabel.Size = new System.Drawing.Size(111, 24);
            this.FromParsonalFirstNamlabel.TabIndex = 64;
            this.FromParsonalFirstNamlabel.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 63;
            this.label6.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(23, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(338, 29);
            this.label8.TabIndex = 62;
            this.label8.Text = "PERSONAL INFORMATION";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.Location = new System.Drawing.Point(11, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 30);
            this.panel3.TabIndex = 61;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.ForestGreen;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(589, 5);
            this.panel5.TabIndex = 1;
            // 
            // TotalBalance
            // 
            this.TotalBalance.AutoSize = true;
            this.TotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBalance.ForeColor = System.Drawing.Color.DarkOrange;
            this.TotalBalance.Location = new System.Drawing.Point(1053, 54);
            this.TotalBalance.Name = "TotalBalance";
            this.TotalBalance.Size = new System.Drawing.Size(90, 25);
            this.TotalBalance.TabIndex = 84;
            this.TotalBalance.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(938, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 83;
            this.label4.Text = "Balance : ";
            // 
            // DepositNumber
            // 
            this.DepositNumber.AutoSize = true;
            this.DepositNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositNumber.ForeColor = System.Drawing.Color.DarkOrange;
            this.DepositNumber.Location = new System.Drawing.Point(15, 105);
            this.DepositNumber.Name = "DepositNumber";
            this.DepositNumber.Size = new System.Drawing.Size(87, 25);
            this.DepositNumber.TabIndex = 82;
            this.DepositNumber.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 81;
            this.label1.Text = "Number Of Deposit";
            // 
            // DepositdataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DepositdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepositdataGridView.AutoGenerateColumns = false;
            this.DepositdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.DepositdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DepositdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DepositdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DepositdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepositdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.DepositdataGridView.DataSource = this.depositHistoryviewBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DepositdataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DepositdataGridView.EnableHeadersVisualStyles = false;
            this.DepositdataGridView.Location = new System.Drawing.Point(3, 168);
            this.DepositdataGridView.Name = "DepositdataGridView";
            this.DepositdataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DepositdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DepositdataGridView.RowTemplate.Height = 24;
            this.DepositdataGridView.Size = new System.Drawing.Size(586, 633);
            this.DepositdataGridView.TabIndex = 80;
            // 
            // fieldDataGridViewTextBoxColumn
            // 
            this.fieldDataGridViewTextBoxColumn.DataPropertyName = "Field";
            this.fieldDataGridViewTextBoxColumn.HeaderText = "Field";
            this.fieldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fieldDataGridViewTextBoxColumn.Name = "fieldDataGridViewTextBoxColumn";
            this.fieldDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // depositHistoryviewBindingSource
            // 
            this.depositHistoryviewBindingSource.DataMember = "Deposit_History_view";
            this.depositHistoryviewBindingSource.DataSource = this.bankSystemDataBaseDataSet3;
            // 
            // bankSystemDataBaseDataSet3
            // 
            this.bankSystemDataBaseDataSet3.DataSetName = "BankSystemDataBaseDataSet3";
            this.bankSystemDataBaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1207, 45);
            this.panel2.TabIndex = 73;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources.transaction_history_2697523_2237715;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(61, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "DEPOSIT HISTORY";
            // 
            // deposit_History_viewTableAdapter
            // 
            this.deposit_History_viewTableAdapter.ClearBeforeFill = true;
            // 
            // DepositHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 804);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepositHistoryForm";
            this.Text = "DepositHistoryForm";
            this.Load += new System.EventHandler(this.DepositHistoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.HDepositTimepanel.ResumeLayout(false);
            this.HDepositTimepanel.PerformLayout();
            this.HDepositMoneypanel.ResumeLayout(false);
            this.HDepositMoneypanel.PerformLayout();
            this.DepositTimeBalancePanel.ResumeLayout(false);
            this.DepositTimeBalancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.FromParsonalpanel.ResumeLayout(false);
            this.FromParsonalpanel.PerformLayout();
            this.FromParsonalBalancepanel.ResumeLayout(false);
            this.FromParsonalBalancepanel.PerformLayout();
            this.FromParsonalLastNamepanel.ResumeLayout(false);
            this.FromParsonalLastNamepanel.PerformLayout();
            this.FromParsonalFirstNamepanel.ResumeLayout(false);
            this.FromParsonalFirstNamepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepositdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositHistoryviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel FromParsonalpanel;
        private System.Windows.Forms.Panel FromParsonalBalancepanel;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label FromParsonalBalancelabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel FromParsonalLastNamepanel;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label FromParsonalLastNamlabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel FromParsonalFirstNamepanel;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label FromParsonalFirstNamlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label TotalBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DepositNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DepositdataGridView;
        private BankSystemDataBaseDataSet3 bankSystemDataBaseDataSet3;
        private System.Windows.Forms.BindingSource depositHistoryviewBindingSource;
        private BankSystemDataBaseDataSet3TableAdapters.Deposit_History_viewTableAdapter deposit_History_viewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel HDepositTimepanel;
        private System.Windows.Forms.Label HDepositTimelabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel HDepositMoneypanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label HDepositMoneylabel;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel DepositTimeBalancePanel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label HDepositBalancelabel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox11;
    }
}