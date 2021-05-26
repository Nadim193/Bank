
namespace Bank
{
    partial class ForgetPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Verify = new System.Windows.Forms.Panel();
            this.forgetBackbutton = new System.Windows.Forms.Button();
            this.showconfirmpassword = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SavePassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmpasswordtextBox = new System.Windows.Forms.TextBox();
            this.newpasswordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Verify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Verify);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1516, 826);
            this.panel1.TabIndex = 0;
            // 
            // Verify
            // 
            this.Verify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Verify.Controls.Add(this.forgetBackbutton);
            this.Verify.Controls.Add(this.showconfirmpassword);
            this.Verify.Controls.Add(this.label4);
            this.Verify.Controls.Add(this.label2);
            this.Verify.Controls.Add(this.SavePassword);
            this.Verify.Controls.Add(this.label3);
            this.Verify.Controls.Add(this.label1);
            this.Verify.Controls.Add(this.confirmpasswordtextBox);
            this.Verify.Controls.Add(this.newpasswordTextBox);
            this.Verify.Location = new System.Drawing.Point(515, 176);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(520, 474);
            this.Verify.TabIndex = 1;
            // 
            // forgetBackbutton
            // 
            this.forgetBackbutton.BackColor = System.Drawing.Color.DarkOrange;
            this.forgetBackbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetBackbutton.ForeColor = System.Drawing.Color.Black;
            this.forgetBackbutton.Location = new System.Drawing.Point(350, 375);
            this.forgetBackbutton.Name = "forgetBackbutton";
            this.forgetBackbutton.Size = new System.Drawing.Size(100, 47);
            this.forgetBackbutton.TabIndex = 11;
            this.forgetBackbutton.Text = "Back";
            this.forgetBackbutton.UseVisualStyleBackColor = false;
            this.forgetBackbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // showconfirmpassword
            // 
            this.showconfirmpassword.AutoSize = true;
            this.showconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showconfirmpassword.ForeColor = System.Drawing.Color.DarkOrange;
            this.showconfirmpassword.Location = new System.Drawing.Point(190, 330);
            this.showconfirmpassword.Name = "showconfirmpassword";
            this.showconfirmpassword.Size = new System.Drawing.Size(142, 21);
            this.showconfirmpassword.TabIndex = 10;
            this.showconfirmpassword.Text = "Show Password";
            this.showconfirmpassword.UseVisualStyleBackColor = true;
            this.showconfirmpassword.CheckedChanged += new System.EventHandler(this.ForgetShowPassword_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(25, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "other accounts. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(10, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Confirm Password :";
            // 
            // SavePassword
            // 
            this.SavePassword.BackColor = System.Drawing.Color.DarkOrange;
            this.SavePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePassword.ForeColor = System.Drawing.Color.Black;
            this.SavePassword.Location = new System.Drawing.Point(190, 375);
            this.SavePassword.Name = "SavePassword";
            this.SavePassword.Size = new System.Drawing.Size(100, 47);
            this.SavePassword.TabIndex = 7;
            this.SavePassword.Text = "Save";
            this.SavePassword.UseVisualStyleBackColor = false;
            this.SavePassword.Click += new System.EventHandler(this.SavePassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(15, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose a strong password and don\'t reuse it for";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(15, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Password :";
            // 
            // confirmpasswordtextBox
            // 
            this.confirmpasswordtextBox.BackColor = System.Drawing.Color.Wheat;
            this.confirmpasswordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasswordtextBox.ForeColor = System.Drawing.Color.Black;
            this.confirmpasswordtextBox.Location = new System.Drawing.Point(190, 274);
            this.confirmpasswordtextBox.Name = "confirmpasswordtextBox";
            this.confirmpasswordtextBox.Size = new System.Drawing.Size(260, 34);
            this.confirmpasswordtextBox.TabIndex = 1;
            this.confirmpasswordtextBox.UseSystemPasswordChar = true;
            // 
            // newpasswordTextBox
            // 
            this.newpasswordTextBox.BackColor = System.Drawing.Color.Wheat;
            this.newpasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.newpasswordTextBox.Location = new System.Drawing.Point(190, 179);
            this.newpasswordTextBox.Name = "newpasswordTextBox";
            this.newpasswordTextBox.Size = new System.Drawing.Size(260, 34);
            this.newpasswordTextBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources.bank_account_banking_building_1_31235;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1540, 850);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.panel1.ResumeLayout(false);
            this.Verify.ResumeLayout(false);
            this.Verify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Verify;
        private System.Windows.Forms.CheckBox showconfirmpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SavePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmpasswordtextBox;
        private System.Windows.Forms.TextBox newpasswordTextBox;
        private System.Windows.Forms.Button forgetBackbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}