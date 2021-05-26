
namespace Bank
{
    partial class LoginForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.UserTypecomboBox = new System.Windows.Forms.ComboBox();
            this.UserTypelabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.OpenRegistationlinkLabel = new System.Windows.Forms.LinkLabel();
            this.ShowRememberPasswordcheckBox = new System.Windows.Forms.CheckBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTxtbox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(12, 258);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1516, 577);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(3, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "© 2021 Bank. All Rights Reserved";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.UserTypecomboBox);
            this.panel5.Controls.Add(this.UserTypelabel);
            this.panel5.Controls.Add(this.LoginButton);
            this.panel5.Controls.Add(this.OpenRegistationlinkLabel);
            this.panel5.Controls.Add(this.ShowRememberPasswordcheckBox);
            this.panel5.Controls.Add(this.UsernameTextbox);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.PasswordTxtbox);
            this.panel5.Location = new System.Drawing.Point(517, 14);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(499, 537);
            this.panel5.TabIndex = 7;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // UserTypecomboBox
            // 
            this.UserTypecomboBox.BackColor = System.Drawing.Color.Wheat;
            this.UserTypecomboBox.FormattingEnabled = true;
            this.UserTypecomboBox.Items.AddRange(new object[] {
            "User",
            "",
            "Admin"});
            this.UserTypecomboBox.Location = new System.Drawing.Point(160, 396);
            this.UserTypecomboBox.Name = "UserTypecomboBox";
            this.UserTypecomboBox.Size = new System.Drawing.Size(99, 24);
            this.UserTypecomboBox.TabIndex = 16;
            this.UserTypecomboBox.SelectedIndexChanged += new System.EventHandler(this.UserTypecomboBox_SelectedIndexChanged);
            // 
            // UserTypelabel
            // 
            this.UserTypelabel.AutoSize = true;
            this.UserTypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypelabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.UserTypelabel.Location = new System.Drawing.Point(22, 396);
            this.UserTypelabel.Name = "UserTypelabel";
            this.UserTypelabel.Size = new System.Drawing.Size(123, 20);
            this.UserTypelabel.TabIndex = 15;
            this.UserTypelabel.Text = "User Types : ";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DarkOrange;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(191, 438);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(122, 55);
            this.LoginButton.TabIndex = 14;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click_1);
            // 
            // OpenRegistationlinkLabel
            // 
            this.OpenRegistationlinkLabel.ActiveLinkColor = System.Drawing.Color.Gray;
            this.OpenRegistationlinkLabel.AutoSize = true;
            this.OpenRegistationlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenRegistationlinkLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.OpenRegistationlinkLabel.LinkColor = System.Drawing.Color.DarkOrange;
            this.OpenRegistationlinkLabel.Location = new System.Drawing.Point(52, 505);
            this.OpenRegistationlinkLabel.Name = "OpenRegistationlinkLabel";
            this.OpenRegistationlinkLabel.Size = new System.Drawing.Size(360, 18);
            this.OpenRegistationlinkLabel.TabIndex = 11;
            this.OpenRegistationlinkLabel.TabStop = true;
            this.OpenRegistationlinkLabel.Text = "Don\'t have an account yet? Create an account.";
            this.OpenRegistationlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenRegistationlinkLabel_LinkClicked);
            // 
            // ShowRememberPasswordcheckBox
            // 
            this.ShowRememberPasswordcheckBox.AutoSize = true;
            this.ShowRememberPasswordcheckBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.ShowRememberPasswordcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRememberPasswordcheckBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.ShowRememberPasswordcheckBox.Location = new System.Drawing.Point(75, 355);
            this.ShowRememberPasswordcheckBox.Name = "ShowRememberPasswordcheckBox";
            this.ShowRememberPasswordcheckBox.Size = new System.Drawing.Size(152, 22);
            this.ShowRememberPasswordcheckBox.TabIndex = 12;
            this.ShowRememberPasswordcheckBox.Text = "Show Password";
            this.ShowRememberPasswordcheckBox.UseVisualStyleBackColor = false;
            this.ShowRememberPasswordcheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordcheckBox_CheckedChanged_1);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.AccessibleDescription = "";
            this.UsernameTextbox.AccessibleName = "";
            this.UsernameTextbox.BackColor = System.Drawing.Color.Wheat;
            this.UsernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextbox.ForeColor = System.Drawing.Color.Black;
            this.UsernameTextbox.Location = new System.Drawing.Point(75, 242);
            this.UsernameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(387, 34);
            this.UsernameTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(132, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "MEMBER LOGIN";
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.AccessibleDescription = "";
            this.PasswordTxtbox.AccessibleName = "";
            this.PasswordTxtbox.BackColor = System.Drawing.Color.Wheat;
            this.PasswordTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtbox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTxtbox.Location = new System.Drawing.Point(75, 306);
            this.PasswordTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTxtbox.Name = "PasswordTxtbox";
            this.PasswordTxtbox.Size = new System.Drawing.Size(387, 34);
            this.PasswordTxtbox.TabIndex = 1;
            this.PasswordTxtbox.UseSystemPasswordChar = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkOrange;
            this.linkLabel1.Location = new System.Drawing.Point(846, 629);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 18);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forget Password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1516, 243);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(649, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "BANK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(649, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(435, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "MANAGEMENT SYSTEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(649, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "WELCOME TO THE";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Bank.Properties.Resources.rsz_1804429_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(37, 306);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bank.Properties.Resources.rsz_full_icon_name_icon_round_icon_png_favpng_apcdd9afcsz9j53rzd6lhgcwg_t_removebg_preview_1;
            this.pictureBox3.Location = new System.Drawing.Point(37, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources.MemberLoginIcon;
            this.pictureBox1.Location = new System.Drawing.Point(150, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bank.Properties.Resources.bank_account_banking_building_1_31235;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 243);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel OpenRegistationlinkLabel;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.TextBox PasswordTxtbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ShowRememberPasswordcheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.ComboBox UserTypecomboBox;
        private System.Windows.Forms.Label UserTypelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}