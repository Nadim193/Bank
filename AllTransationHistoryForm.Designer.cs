
namespace Bank
{
    partial class AllTransationHistoryForm
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.HTransationMoneypanel = new System.Windows.Forms.Panel();
            this.AllHTransationMoneylabel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.AllHWithdrawMoneypanel = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.AllHWithdrawMoneylabel = new System.Windows.Forms.Label();
            this.AllHDepositMoneypanel = new System.Windows.Forms.Panel();
            this.AllHDepositMoneylabel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
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
            this.AlltransationdataGridView = new System.Windows.Forms.DataGridView();
            this.fieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLLTransationViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataBaseDataSet5 = new Bank.BankSystemDataBaseDataSet5();
            this.AllTransationNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aLLTransation_ViewTableAdapter = new Bank.BankSystemDataBaseDataSet5TableAdapters.ALLTransation_ViewTableAdapter();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.HTransationMoneypanel.SuspendLayout();
            this.AllHWithdrawMoneypanel.SuspendLayout();
            this.AllHDepositMoneypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.FromParsonalpanel.SuspendLayout();
            this.FromParsonalBalancepanel.SuspendLayout();
            this.FromParsonalLastNamepanel.SuspendLayout();
            this.FromParsonalFirstNamepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlltransationdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLTransationViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.FromParsonalpanel);
            this.panel1.Controls.Add(this.TotalBalance);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AlltransationdataGridView);
            this.panel1.Controls.Add(this.AllTransationNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 804);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.HTransationMoneypanel);
            this.panel8.Controls.Add(this.AllHWithdrawMoneypanel);
            this.panel8.Controls.Add(this.AllHDepositMoneypanel);
            this.panel8.Controls.Add(this.pictureBox13);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.panel16);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Location = new System.Drawing.Point(673, 168);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(522, 268);
            this.panel8.TabIndex = 69;
            // 
            // HTransationMoneypanel
            // 
            this.HTransationMoneypanel.Controls.Add(this.AllHTransationMoneylabel);
            this.HTransationMoneypanel.Controls.Add(this.label23);
            this.HTransationMoneypanel.Location = new System.Drawing.Point(122, 195);
            this.HTransationMoneypanel.Name = "HTransationMoneypanel";
            this.HTransationMoneypanel.Size = new System.Drawing.Size(438, 33);
            this.HTransationMoneypanel.TabIndex = 75;
            this.HTransationMoneypanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HTransationMoneypanel_Paint);
            // 
            // AllHTransationMoneylabel
            // 
            this.AllHTransationMoneylabel.AutoSize = true;
            this.AllHTransationMoneylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllHTransationMoneylabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.AllHTransationMoneylabel.Location = new System.Drawing.Point(215, 5);
            this.AllHTransationMoneylabel.Name = "AllHTransationMoneylabel";
            this.AllHTransationMoneylabel.Size = new System.Drawing.Size(73, 24);
            this.AllHTransationMoneylabel.TabIndex = 68;
            this.AllHTransationMoneylabel.Text = "Money";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DarkOrange;
            this.label23.Location = new System.Drawing.Point(3, 5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(174, 24);
            this.label23.TabIndex = 67;
            this.label23.Text = "> Transfer Money";
            // 
            // AllHWithdrawMoneypanel
            // 
            this.AllHWithdrawMoneypanel.Controls.Add(this.label24);
            this.AllHWithdrawMoneypanel.Controls.Add(this.AllHWithdrawMoneylabel);
            this.AllHWithdrawMoneypanel.Location = new System.Drawing.Point(123, 139);
            this.AllHWithdrawMoneypanel.Name = "AllHWithdrawMoneypanel";
            this.AllHWithdrawMoneypanel.Size = new System.Drawing.Size(435, 33);
            this.AllHWithdrawMoneypanel.TabIndex = 76;
            this.AllHWithdrawMoneypanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AllHWithdrawMoneypanel_Paint);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DarkOrange;
            this.label24.Location = new System.Drawing.Point(4, 5);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(183, 24);
            this.label24.TabIndex = 63;
            this.label24.Text = "> Withdraw Money";
            // 
            // AllHWithdrawMoneylabel
            // 
            this.AllHWithdrawMoneylabel.AutoSize = true;
            this.AllHWithdrawMoneylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllHWithdrawMoneylabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.AllHWithdrawMoneylabel.Location = new System.Drawing.Point(214, 5);
            this.AllHWithdrawMoneylabel.Name = "AllHWithdrawMoneylabel";
            this.AllHWithdrawMoneylabel.Size = new System.Drawing.Size(73, 24);
            this.AllHWithdrawMoneylabel.TabIndex = 64;
            this.AllHWithdrawMoneylabel.Text = "Money";
            // 
            // AllHDepositMoneypanel
            // 
            this.AllHDepositMoneypanel.Controls.Add(this.AllHDepositMoneylabel);
            this.AllHDepositMoneypanel.Controls.Add(this.label26);
            this.AllHDepositMoneypanel.Location = new System.Drawing.Point(122, 81);
            this.AllHDepositMoneypanel.Name = "AllHDepositMoneypanel";
            this.AllHDepositMoneypanel.Size = new System.Drawing.Size(437, 33);
            this.AllHDepositMoneypanel.TabIndex = 74;
            this.AllHDepositMoneypanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AllHDepositMoneypanel_Paint);
            // 
            // AllHDepositMoneylabel
            // 
            this.AllHDepositMoneylabel.AutoSize = true;
            this.AllHDepositMoneylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllHDepositMoneylabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.AllHDepositMoneylabel.Location = new System.Drawing.Point(215, 4);
            this.AllHDepositMoneylabel.Name = "AllHDepositMoneylabel";
            this.AllHDepositMoneylabel.Size = new System.Drawing.Size(73, 24);
            this.AllHDepositMoneylabel.TabIndex = 65;
            this.AllHDepositMoneylabel.Text = "Money";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.DarkOrange;
            this.label26.Location = new System.Drawing.Point(4, 5);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(167, 24);
            this.label26.TabIndex = 61;
            this.label26.Text = "> Deposit Money";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Bank.Properties.Resources.Screenshot_2021_07_15_235621_removebg_preview1;
            this.pictureBox13.Location = new System.Drawing.Point(-1, 83);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(106, 92);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 73;
            this.pictureBox13.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 63;
            this.label2.Text = "ALL HISTORY";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Red;
            this.panel16.Location = new System.Drawing.Point(13, 18);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(5, 30);
            this.panel16.TabIndex = 62;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Red;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(520, 5);
            this.panel12.TabIndex = 2;
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
            this.FromParsonalpanel.Location = new System.Drawing.Point(673, 506);
            this.FromParsonalpanel.Name = "FromParsonalpanel";
            this.FromParsonalpanel.Size = new System.Drawing.Size(523, 230);
            this.FromParsonalpanel.TabIndex = 97;
            // 
            // FromParsonalBalancepanel
            // 
            this.FromParsonalBalancepanel.Controls.Add(this.panel23);
            this.FromParsonalBalancepanel.Controls.Add(this.FromParsonalBalancelabel);
            this.FromParsonalBalancepanel.Controls.Add(this.label5);
            this.FromParsonalBalancepanel.Location = new System.Drawing.Point(28, 178);
            this.FromParsonalBalancepanel.Name = "FromParsonalBalancepanel";
            this.FromParsonalBalancepanel.Size = new System.Drawing.Size(533, 36);
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
            this.FromParsonalBalancelabel.Location = new System.Drawing.Point(310, 7);
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
            this.FromParsonalLastNamepanel.Size = new System.Drawing.Size(533, 36);
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
            this.FromParsonalLastNamlabel.Location = new System.Drawing.Point(310, 7);
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
            this.FromParsonalFirstNamepanel.Size = new System.Drawing.Size(533, 36);
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
            this.FromParsonalFirstNamlabel.Location = new System.Drawing.Point(310, 7);
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
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(11, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 30);
            this.panel3.TabIndex = 61;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(521, 5);
            this.panel5.TabIndex = 1;
            // 
            // TotalBalance
            // 
            this.TotalBalance.AutoSize = true;
            this.TotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBalance.ForeColor = System.Drawing.Color.DarkOrange;
            this.TotalBalance.Location = new System.Drawing.Point(1056, 54);
            this.TotalBalance.Name = "TotalBalance";
            this.TotalBalance.Size = new System.Drawing.Size(90, 25);
            this.TotalBalance.TabIndex = 96;
            this.TotalBalance.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(941, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 95;
            this.label4.Text = "Balance : ";
            // 
            // AlltransationdataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlltransationdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AlltransationdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlltransationdataGridView.AutoGenerateColumns = false;
            this.AlltransationdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.AlltransationdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlltransationdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AlltransationdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AlltransationdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlltransationdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.transferToDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.AlltransationdataGridView.DataSource = this.aLLTransationViewBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AlltransationdataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.AlltransationdataGridView.EnableHeadersVisualStyles = false;
            this.AlltransationdataGridView.Location = new System.Drawing.Point(6, 168);
            this.AlltransationdataGridView.Name = "AlltransationdataGridView";
            this.AlltransationdataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.AlltransationdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AlltransationdataGridView.RowTemplate.Height = 24;
            this.AlltransationdataGridView.Size = new System.Drawing.Size(652, 633);
            this.AlltransationdataGridView.TabIndex = 92;
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
            // transferToDataGridViewTextBoxColumn
            // 
            this.transferToDataGridViewTextBoxColumn.DataPropertyName = "Transfer_To";
            this.transferToDataGridViewTextBoxColumn.HeaderText = "Transfer_To";
            this.transferToDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transferToDataGridViewTextBoxColumn.Name = "transferToDataGridViewTextBoxColumn";
            this.transferToDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // aLLTransationViewBindingSource
            // 
            this.aLLTransationViewBindingSource.DataMember = "ALLTransation_View";
            this.aLLTransationViewBindingSource.DataSource = this.bankSystemDataBaseDataSet5;
            // 
            // bankSystemDataBaseDataSet5
            // 
            this.bankSystemDataBaseDataSet5.DataSetName = "BankSystemDataBaseDataSet5";
            this.bankSystemDataBaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AllTransationNumber
            // 
            this.AllTransationNumber.AutoSize = true;
            this.AllTransationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTransationNumber.ForeColor = System.Drawing.Color.DarkOrange;
            this.AllTransationNumber.Location = new System.Drawing.Point(12, 102);
            this.AllTransationNumber.Name = "AllTransationNumber";
            this.AllTransationNumber.Size = new System.Drawing.Size(87, 25);
            this.AllTransationNumber.TabIndex = 94;
            this.AllTransationNumber.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 93;
            this.label1.Text = "Number Of All Transation";
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
            this.panel2.TabIndex = 75;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources.purchase_history_icon_transaction_history_icon_11553476408pgondxxib0_removebg_preview;
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
            this.label3.Size = new System.Drawing.Size(298, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "ALL TRANSATION HISTORY";
            // 
            // aLLTransation_ViewTableAdapter
            // 
            this.aLLTransation_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // AllTransationHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 804);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllTransationHistoryForm";
            this.Text = "AllTransationHistoryForm";
            this.Load += new System.EventHandler(this.AllTransationHistoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.HTransationMoneypanel.ResumeLayout(false);
            this.HTransationMoneypanel.PerformLayout();
            this.AllHWithdrawMoneypanel.ResumeLayout(false);
            this.AllHWithdrawMoneypanel.PerformLayout();
            this.AllHDepositMoneypanel.ResumeLayout(false);
            this.AllHDepositMoneypanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.FromParsonalpanel.ResumeLayout(false);
            this.FromParsonalpanel.PerformLayout();
            this.FromParsonalBalancepanel.ResumeLayout(false);
            this.FromParsonalBalancepanel.PerformLayout();
            this.FromParsonalLastNamepanel.ResumeLayout(false);
            this.FromParsonalLastNamepanel.PerformLayout();
            this.FromParsonalFirstNamepanel.ResumeLayout(false);
            this.FromParsonalFirstNamepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlltransationdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLTransationViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet5)).EndInit();
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
        private System.Windows.Forms.DataGridView AlltransationdataGridView;
        private System.Windows.Forms.Label AllTransationNumber;
        private System.Windows.Forms.Label label1;
        private BankSystemDataBaseDataSet5 bankSystemDataBaseDataSet5;
        private System.Windows.Forms.BindingSource aLLTransationViewBindingSource;
        private BankSystemDataBaseDataSet5TableAdapters.ALLTransation_ViewTableAdapter aLLTransation_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel HTransationMoneypanel;
        private System.Windows.Forms.Label AllHTransationMoneylabel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel AllHWithdrawMoneypanel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label AllHWithdrawMoneylabel;
        private System.Windows.Forms.Panel AllHDepositMoneypanel;
        private System.Windows.Forms.Label AllHDepositMoneylabel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel12;
    }
}