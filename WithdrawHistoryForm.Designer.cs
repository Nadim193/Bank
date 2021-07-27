
namespace Bank
{
    partial class WithdrawHistoryForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.WithdrawTimepanel = new System.Windows.Forms.Panel();
            this.HWithdrawTimelabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.WithdrawMoneypanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.HWithdrawMoneylabel = new System.Windows.Forms.Label();
            this.WithdrawTimeBalancepanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.HWithdrawBanlacelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.withdrawNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WithdrawdataGridView = new System.Windows.Forms.DataGridView();
            this.fieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.withdrawHistoryViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataBaseDataSet2 = new Bank.BankSystemDataBaseDataSet2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.withdraw_History_ViewTableAdapter = new Bank.BankSystemDataBaseDataSet2TableAdapters.Withdraw_History_ViewTableAdapter();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.FromParsonalpanel.SuspendLayout();
            this.FromParsonalBalancepanel.SuspendLayout();
            this.FromParsonalLastNamepanel.SuspendLayout();
            this.FromParsonalFirstNamepanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.WithdrawTimepanel.SuspendLayout();
            this.WithdrawMoneypanel.SuspendLayout();
            this.WithdrawTimeBalancepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WithdrawdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawHistoryViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.FromParsonalpanel);
            this.panel1.Controls.Add(this.TotalBalance);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.withdrawNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.WithdrawdataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 804);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.FromParsonalpanel.Location = new System.Drawing.Point(603, 509);
            this.FromParsonalpanel.Name = "FromParsonalpanel";
            this.FromParsonalpanel.Size = new System.Drawing.Size(591, 230);
            this.FromParsonalpanel.TabIndex = 79;
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
            this.panel23.Location = new System.Drawing.Point(161, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(2, 36);
            this.panel23.TabIndex = 10;
            // 
            // FromParsonalBalancelabel
            // 
            this.FromParsonalBalancelabel.AutoSize = true;
            this.FromParsonalBalancelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromParsonalBalancelabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.FromParsonalBalancelabel.Location = new System.Drawing.Point(183, 6);
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
            this.panel22.Location = new System.Drawing.Point(161, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(2, 36);
            this.panel22.TabIndex = 65;
            // 
            // FromParsonalLastNamlabel
            // 
            this.FromParsonalLastNamlabel.AutoSize = true;
            this.FromParsonalLastNamlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromParsonalLastNamlabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.FromParsonalLastNamlabel.Location = new System.Drawing.Point(183, 6);
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
            this.panel21.Location = new System.Drawing.Point(161, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(2, 36);
            this.panel21.TabIndex = 9;
            // 
            // FromParsonalFirstNamlabel
            // 
            this.FromParsonalFirstNamlabel.AutoSize = true;
            this.FromParsonalFirstNamlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromParsonalFirstNamlabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.FromParsonalFirstNamlabel.Location = new System.Drawing.Point(183, 6);
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
            this.TotalBalance.Location = new System.Drawing.Point(1050, 57);
            this.TotalBalance.Name = "TotalBalance";
            this.TotalBalance.Size = new System.Drawing.Size(90, 25);
            this.TotalBalance.TabIndex = 78;
            this.TotalBalance.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(935, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 77;
            this.label4.Text = "Balance : ";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.WithdrawTimepanel);
            this.panel4.Controls.Add(this.WithdrawMoneypanel);
            this.panel4.Controls.Add(this.WithdrawTimeBalancepanel);
            this.panel4.Controls.Add(this.pictureBox9);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Location = new System.Drawing.Point(602, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(589, 268);
            this.panel4.TabIndex = 76;
            // 
            // WithdrawTimepanel
            // 
            this.WithdrawTimepanel.Controls.Add(this.HWithdrawTimelabel);
            this.WithdrawTimepanel.Controls.Add(this.label11);
            this.WithdrawTimepanel.Location = new System.Drawing.Point(130, 194);
            this.WithdrawTimepanel.Name = "WithdrawTimepanel";
            this.WithdrawTimepanel.Size = new System.Drawing.Size(457, 33);
            this.WithdrawTimepanel.TabIndex = 68;
            this.WithdrawTimepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.WithdrawTimepanel_Paint);
            // 
            // HWithdrawTimelabel
            // 
            this.HWithdrawTimelabel.AutoSize = true;
            this.HWithdrawTimelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HWithdrawTimelabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.HWithdrawTimelabel.Location = new System.Drawing.Point(225, 5);
            this.HWithdrawTimelabel.Name = "HWithdrawTimelabel";
            this.HWithdrawTimelabel.Size = new System.Drawing.Size(57, 24);
            this.HWithdrawTimelabel.TabIndex = 68;
            this.HWithdrawTimelabel.Text = "Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkOrange;
            this.label11.Location = new System.Drawing.Point(3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 24);
            this.label11.TabIndex = 67;
            this.label11.Text = "> Withdraw Time";
            // 
            // WithdrawMoneypanel
            // 
            this.WithdrawMoneypanel.Controls.Add(this.label9);
            this.WithdrawMoneypanel.Controls.Add(this.HWithdrawMoneylabel);
            this.WithdrawMoneypanel.Location = new System.Drawing.Point(131, 138);
            this.WithdrawMoneypanel.Name = "WithdrawMoneypanel";
            this.WithdrawMoneypanel.Size = new System.Drawing.Size(457, 33);
            this.WithdrawMoneypanel.TabIndex = 68;
            this.WithdrawMoneypanel.Paint += new System.Windows.Forms.PaintEventHandler(this.WithdrawMoneypanel_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(4, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 24);
            this.label9.TabIndex = 63;
            this.label9.Text = "> Withdraw Money";
            // 
            // HWithdrawMoneylabel
            // 
            this.HWithdrawMoneylabel.AutoSize = true;
            this.HWithdrawMoneylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HWithdrawMoneylabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.HWithdrawMoneylabel.Location = new System.Drawing.Point(225, 5);
            this.HWithdrawMoneylabel.Name = "HWithdrawMoneylabel";
            this.HWithdrawMoneylabel.Size = new System.Drawing.Size(73, 24);
            this.HWithdrawMoneylabel.TabIndex = 64;
            this.HWithdrawMoneylabel.Text = "Money";
            // 
            // WithdrawTimeBalancepanel
            // 
            this.WithdrawTimeBalancepanel.Controls.Add(this.label7);
            this.WithdrawTimeBalancepanel.Controls.Add(this.HWithdrawBanlacelabel);
            this.WithdrawTimeBalancepanel.Location = new System.Drawing.Point(130, 80);
            this.WithdrawTimeBalancepanel.Name = "WithdrawTimeBalancepanel";
            this.WithdrawTimeBalancepanel.Size = new System.Drawing.Size(458, 33);
            this.WithdrawTimeBalancepanel.TabIndex = 67;
            this.WithdrawTimeBalancepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.WithdrawTimeBalancepanel_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(4, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 61;
            this.label7.Text = "> Balance";
            // 
            // HWithdrawBanlacelabel
            // 
            this.HWithdrawBanlacelabel.AutoSize = true;
            this.HWithdrawBanlacelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HWithdrawBanlacelabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.HWithdrawBanlacelabel.Location = new System.Drawing.Point(226, 5);
            this.HWithdrawBanlacelabel.Name = "HWithdrawBanlacelabel";
            this.HWithdrawBanlacelabel.Size = new System.Drawing.Size(85, 24);
            this.HWithdrawBanlacelabel.TabIndex = 62;
            this.HWithdrawBanlacelabel.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(24, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 29);
            this.label2.TabIndex = 59;
            this.label2.Text = "WITHDRAW HISTORY";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.ForestGreen;
            this.panel13.Location = new System.Drawing.Point(13, 17);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(5, 30);
            this.panel13.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.ForestGreen;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(587, 5);
            this.panel9.TabIndex = 0;
            // 
            // withdrawNumber
            // 
            this.withdrawNumber.AutoSize = true;
            this.withdrawNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawNumber.ForeColor = System.Drawing.Color.DarkOrange;
            this.withdrawNumber.Location = new System.Drawing.Point(12, 100);
            this.withdrawNumber.Name = "withdrawNumber";
            this.withdrawNumber.Size = new System.Drawing.Size(87, 25);
            this.withdrawNumber.TabIndex = 75;
            this.withdrawNumber.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Number Of Withdraw";
            // 
            // WithdrawdataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.WithdrawdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WithdrawdataGridView.AutoGenerateColumns = false;
            this.WithdrawdataGridView.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.WithdrawdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WithdrawdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WithdrawdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.WithdrawdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WithdrawdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.WithdrawdataGridView.DataSource = this.withdrawHistoryViewBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WithdrawdataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.WithdrawdataGridView.EnableHeadersVisualStyles = false;
            this.WithdrawdataGridView.Location = new System.Drawing.Point(0, 171);
            this.WithdrawdataGridView.Name = "WithdrawdataGridView";
            this.WithdrawdataGridView.RowHeadersVisible = false;
            this.WithdrawdataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.WithdrawdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.WithdrawdataGridView.RowTemplate.Height = 24;
            this.WithdrawdataGridView.Size = new System.Drawing.Size(586, 633);
            this.WithdrawdataGridView.TabIndex = 73;
            this.WithdrawdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WithdrawdataGridView_CellContentClick);
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
            // withdrawHistoryViewBindingSource
            // 
            this.withdrawHistoryViewBindingSource.DataMember = "Withdraw_History_View";
            this.withdrawHistoryViewBindingSource.DataSource = this.bankSystemDataBaseDataSet2;
            // 
            // bankSystemDataBaseDataSet2
            // 
            this.bankSystemDataBaseDataSet2.DataSetName = "BankSystemDataBaseDataSet2";
            this.bankSystemDataBaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel2.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(61, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "WITHDRAW HISTORY";
            // 
            // withdraw_History_ViewTableAdapter
            // 
            this.withdraw_History_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Bank.Properties.Resources.Screenshot_2021_07_15_231152_removebg_preview;
            this.pictureBox9.Location = new System.Drawing.Point(7, 82);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(106, 92);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 60;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources._176_1766289_atm_withdrawal_svg_png_icon_free_download_atm_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // WithdrawHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 804);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WithdrawHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrawHistoryForm";
            this.Load += new System.EventHandler(this.WithdrawHistoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FromParsonalpanel.ResumeLayout(false);
            this.FromParsonalpanel.PerformLayout();
            this.FromParsonalBalancepanel.ResumeLayout(false);
            this.FromParsonalBalancepanel.PerformLayout();
            this.FromParsonalLastNamepanel.ResumeLayout(false);
            this.FromParsonalLastNamepanel.PerformLayout();
            this.FromParsonalFirstNamepanel.ResumeLayout(false);
            this.FromParsonalFirstNamepanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.WithdrawTimepanel.ResumeLayout(false);
            this.WithdrawTimepanel.PerformLayout();
            this.WithdrawMoneypanel.ResumeLayout(false);
            this.WithdrawMoneypanel.PerformLayout();
            this.WithdrawTimeBalancepanel.ResumeLayout(false);
            this.WithdrawTimeBalancepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WithdrawdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawHistoryViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataBaseDataSet2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label withdrawNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView WithdrawdataGridView;
        private System.Windows.Forms.BindingSource withdrawHistoryViewBindingSource;
        private BankSystemDataBaseDataSet2TableAdapters.Withdraw_History_ViewTableAdapter withdraw_History_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private BankSystemDataBaseDataSet2 bankSystemDataBaseDataSet2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel WithdrawTimepanel;
        private System.Windows.Forms.Label HWithdrawTimelabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel WithdrawMoneypanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label HWithdrawMoneylabel;
        private System.Windows.Forms.Panel WithdrawTimeBalancepanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label HWithdrawBanlacelabel;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label TotalBalance;
        private System.Windows.Forms.Label label4;
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
    }
}