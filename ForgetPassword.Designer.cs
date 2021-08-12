
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.RestoreDownIcon = new System.Windows.Forms.PictureBox();
            this.maxIcon = new System.Windows.Forms.PictureBox();
            this.minIcon = new System.Windows.Forms.PictureBox();
            this.cerraricon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Verify.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDownIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerraricon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Verify);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1540, 850);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkOrange;
            this.panel6.Location = new System.Drawing.Point(-1, 248);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1542, 5);
            this.panel6.TabIndex = 10;
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
            this.Verify.Location = new System.Drawing.Point(502, 317);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(561, 474);
            this.Verify.TabIndex = 1;
            // 
            // forgetBackbutton
            // 
            this.forgetBackbutton.BackColor = System.Drawing.Color.DarkOrange;
            this.forgetBackbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetBackbutton.FlatAppearance.BorderSize = 0;
            this.forgetBackbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgetBackbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetBackbutton.ForeColor = System.Drawing.Color.Black;
            this.forgetBackbutton.Location = new System.Drawing.Point(304, 375);
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
            this.showconfirmpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showconfirmpassword.ForeColor = System.Drawing.Color.DarkOrange;
            this.showconfirmpassword.Location = new System.Drawing.Point(61, 312);
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
            this.label4.Location = new System.Drawing.Point(15, 76);
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
            this.label2.Location = new System.Drawing.Point(58, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Confirm Password";
            // 
            // SavePassword
            // 
            this.SavePassword.BackColor = System.Drawing.Color.DarkOrange;
            this.SavePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SavePassword.FlatAppearance.BorderSize = 0;
            this.SavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePassword.ForeColor = System.Drawing.Color.Black;
            this.SavePassword.Location = new System.Drawing.Point(144, 375);
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
            this.label1.Location = new System.Drawing.Point(57, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Password";
            // 
            // confirmpasswordtextBox
            // 
            this.confirmpasswordtextBox.BackColor = System.Drawing.Color.Wheat;
            this.confirmpasswordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasswordtextBox.ForeColor = System.Drawing.Color.Black;
            this.confirmpasswordtextBox.Location = new System.Drawing.Point(61, 268);
            this.confirmpasswordtextBox.Name = "confirmpasswordtextBox";
            this.confirmpasswordtextBox.Size = new System.Drawing.Size(499, 34);
            this.confirmpasswordtextBox.TabIndex = 1;
            this.confirmpasswordtextBox.UseSystemPasswordChar = true;
            // 
            // newpasswordTextBox
            // 
            this.newpasswordTextBox.BackColor = System.Drawing.Color.Wheat;
            this.newpasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.newpasswordTextBox.Location = new System.Drawing.Point(61, 179);
            this.newpasswordTextBox.Name = "newpasswordTextBox";
            this.newpasswordTextBox.Size = new System.Drawing.Size(499, 34);
            this.newpasswordTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.RestoreDownIcon);
            this.panel3.Controls.Add(this.maxIcon);
            this.panel3.Controls.Add(this.minIcon);
            this.panel3.Controls.Add(this.cerraricon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1540, 20);
            this.panel3.TabIndex = 10;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 10;
            this.gunaElipse2.TargetControl = this.SavePassword;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 10;
            this.gunaElipse3.TargetControl = this.forgetBackbutton;
            // 
            // RestoreDownIcon
            // 
            this.RestoreDownIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreDownIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreDownIcon.Image = global::Bank.Properties.Resources.restore_down;
            this.RestoreDownIcon.Location = new System.Drawing.Point(1467, 0);
            this.RestoreDownIcon.Name = "RestoreDownIcon";
            this.RestoreDownIcon.Size = new System.Drawing.Size(20, 20);
            this.RestoreDownIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RestoreDownIcon.TabIndex = 39;
            this.RestoreDownIcon.TabStop = false;
            this.RestoreDownIcon.Visible = false;
            this.RestoreDownIcon.Click += new System.EventHandler(this.RestoreDownIcon_Click);
            // 
            // maxIcon
            // 
            this.maxIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxIcon.Image = global::Bank.Properties.Resources._32763;
            this.maxIcon.Location = new System.Drawing.Point(1467, 0);
            this.maxIcon.Name = "maxIcon";
            this.maxIcon.Size = new System.Drawing.Size(20, 20);
            this.maxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxIcon.TabIndex = 40;
            this.maxIcon.TabStop = false;
            this.maxIcon.Click += new System.EventHandler(this.maxIcon_Click);
            // 
            // minIcon
            // 
            this.minIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minIcon.Image = global::Bank.Properties.Resources.minimize_window;
            this.minIcon.Location = new System.Drawing.Point(1429, 0);
            this.minIcon.Name = "minIcon";
            this.minIcon.Size = new System.Drawing.Size(20, 20);
            this.minIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minIcon.TabIndex = 38;
            this.minIcon.TabStop = false;
            this.minIcon.Click += new System.EventHandler(this.minIcon_Click);
            // 
            // cerraricon
            // 
            this.cerraricon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerraricon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerraricon.Image = global::Bank.Properties.Resources._60994;
            this.cerraricon.Location = new System.Drawing.Point(1505, 0);
            this.cerraricon.Name = "cerraricon";
            this.cerraricon.Size = new System.Drawing.Size(20, 20);
            this.cerraricon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerraricon.TabIndex = 37;
            this.cerraricon.TabStop = false;
            this.cerraricon.Click += new System.EventHandler(this.cerraricon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources.bank_account_banking_building_1_31235;
            this.pictureBox1.Location = new System.Drawing.Point(1, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 227);
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
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.panel1.ResumeLayout(false);
            this.Verify.ResumeLayout(false);
            this.Verify.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDownIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerraricon)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox RestoreDownIcon;
        private System.Windows.Forms.PictureBox maxIcon;
        private System.Windows.Forms.PictureBox minIcon;
        private System.Windows.Forms.PictureBox cerraricon;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
    }
}