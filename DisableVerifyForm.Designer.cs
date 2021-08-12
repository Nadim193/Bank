
namespace Bank
{
    partial class DisableVerifyForm
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
            this.Verify = new System.Windows.Forms.Panel();
            this.VerifyMailLable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.verifyBackbutton = new System.Windows.Forms.Button();
            this.DisiableCodetextBox = new System.Windows.Forms.TextBox();
            this.Verifybutton = new System.Windows.Forms.Button();
            this.OTPLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.RestoreDownIcon = new System.Windows.Forms.PictureBox();
            this.maxIcon = new System.Windows.Forms.PictureBox();
            this.minIcon = new System.Windows.Forms.PictureBox();
            this.cerraricon = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1.SuspendLayout();
            this.Verify.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDownIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerraricon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.Verify);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 761);
            this.panel1.TabIndex = 0;
            // 
            // Verify
            // 
            this.Verify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Verify.Controls.Add(this.VerifyMailLable);
            this.Verify.Controls.Add(this.label4);
            this.Verify.Controls.Add(this.label1);
            this.Verify.Controls.Add(this.verifyBackbutton);
            this.Verify.Controls.Add(this.DisiableCodetextBox);
            this.Verify.Controls.Add(this.Verifybutton);
            this.Verify.Controls.Add(this.OTPLable);
            this.Verify.Controls.Add(this.label3);
            this.Verify.Location = new System.Drawing.Point(268, 144);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(575, 469);
            this.Verify.TabIndex = 23;
            this.Verify.Paint += new System.Windows.Forms.PaintEventHandler(this.Verify_Paint);
            // 
            // VerifyMailLable
            // 
            this.VerifyMailLable.AutoSize = true;
            this.VerifyMailLable.BackColor = System.Drawing.SystemColors.Desktop;
            this.VerifyMailLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyMailLable.ForeColor = System.Drawing.Color.DarkOrange;
            this.VerifyMailLable.Location = new System.Drawing.Point(36, 177);
            this.VerifyMailLable.Name = "VerifyMailLable";
            this.VerifyMailLable.Size = new System.Drawing.Size(52, 25);
            this.VerifyMailLable.TabIndex = 18;
            this.VerifyMailLable.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(36, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "OTP From email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(36, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "To verify your account, You have to enter your";
            // 
            // verifyBackbutton
            // 
            this.verifyBackbutton.BackColor = System.Drawing.Color.DarkOrange;
            this.verifyBackbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.verifyBackbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyBackbutton.ForeColor = System.Drawing.Color.Black;
            this.verifyBackbutton.Location = new System.Drawing.Point(336, 365);
            this.verifyBackbutton.Name = "verifyBackbutton";
            this.verifyBackbutton.Size = new System.Drawing.Size(105, 49);
            this.verifyBackbutton.TabIndex = 15;
            this.verifyBackbutton.Text = "Back";
            this.verifyBackbutton.UseVisualStyleBackColor = false;
            this.verifyBackbutton.Click += new System.EventHandler(this.verifyBackbutton_Click);
            // 
            // DisiableCodetextBox
            // 
            this.DisiableCodetextBox.BackColor = System.Drawing.Color.Wheat;
            this.DisiableCodetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisiableCodetextBox.Location = new System.Drawing.Point(41, 270);
            this.DisiableCodetextBox.Name = "DisiableCodetextBox";
            this.DisiableCodetextBox.Size = new System.Drawing.Size(533, 34);
            this.DisiableCodetextBox.TabIndex = 14;
            // 
            // Verifybutton
            // 
            this.Verifybutton.BackColor = System.Drawing.Color.DarkOrange;
            this.Verifybutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Verifybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verifybutton.ForeColor = System.Drawing.Color.Black;
            this.Verifybutton.Location = new System.Drawing.Point(165, 365);
            this.Verifybutton.Name = "Verifybutton";
            this.Verifybutton.Size = new System.Drawing.Size(105, 49);
            this.Verifybutton.TabIndex = 11;
            this.Verifybutton.Text = "Verify";
            this.Verifybutton.UseVisualStyleBackColor = false;
            this.Verifybutton.Click += new System.EventHandler(this.Verifybutton_Click);
            // 
            // OTPLable
            // 
            this.OTPLable.AutoSize = true;
            this.OTPLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPLable.ForeColor = System.Drawing.Color.DarkOrange;
            this.OTPLable.Location = new System.Drawing.Point(37, 231);
            this.OTPLable.Name = "OTPLable";
            this.OTPLable.Size = new System.Drawing.Size(108, 24);
            this.OTPLable.TabIndex = 9;
            this.OTPLable.Text = "Enter OTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(131, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Verify Your Account";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkOrange;
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Controls.Add(this.RestoreDownIcon);
            this.panel7.Controls.Add(this.maxIcon);
            this.panel7.Controls.Add(this.minIcon);
            this.panel7.Controls.Add(this.cerraricon);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1189, 41);
            this.panel7.TabIndex = 22;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::Bank.Properties.Resources.bank_account_banking_building_1_31235;
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(51, 38);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 45;
            this.pictureBox7.TabStop = false;
            // 
            // RestoreDownIcon
            // 
            this.RestoreDownIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreDownIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreDownIcon.Image = global::Bank.Properties.Resources.restore_down;
            this.RestoreDownIcon.Location = new System.Drawing.Point(1117, 10);
            this.RestoreDownIcon.Name = "RestoreDownIcon";
            this.RestoreDownIcon.Size = new System.Drawing.Size(20, 20);
            this.RestoreDownIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RestoreDownIcon.TabIndex = 43;
            this.RestoreDownIcon.TabStop = false;
            this.RestoreDownIcon.Visible = false;
            this.RestoreDownIcon.Click += new System.EventHandler(this.RestoreDownIcon_Click);
            // 
            // maxIcon
            // 
            this.maxIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxIcon.Image = global::Bank.Properties.Resources._32763;
            this.maxIcon.Location = new System.Drawing.Point(1117, 10);
            this.maxIcon.Name = "maxIcon";
            this.maxIcon.Size = new System.Drawing.Size(20, 20);
            this.maxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxIcon.TabIndex = 44;
            this.maxIcon.TabStop = false;
            this.maxIcon.Click += new System.EventHandler(this.maxIcon_Click);
            // 
            // minIcon
            // 
            this.minIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minIcon.Image = global::Bank.Properties.Resources.minimize_window;
            this.minIcon.Location = new System.Drawing.Point(1084, 10);
            this.minIcon.Name = "minIcon";
            this.minIcon.Size = new System.Drawing.Size(20, 20);
            this.minIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minIcon.TabIndex = 42;
            this.minIcon.TabStop = false;
            this.minIcon.Click += new System.EventHandler(this.minIcon_Click);
            // 
            // cerraricon
            // 
            this.cerraricon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerraricon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerraricon.Image = global::Bank.Properties.Resources._60994;
            this.cerraricon.Location = new System.Drawing.Point(1150, 10);
            this.cerraricon.Name = "cerraricon";
            this.cerraricon.Size = new System.Drawing.Size(20, 20);
            this.cerraricon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerraricon.TabIndex = 41;
            this.cerraricon.TabStop = false;
            this.cerraricon.Click += new System.EventHandler(this.cerraricon_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 10;
            this.gunaElipse2.TargetControl = this.verifyBackbutton;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 10;
            this.gunaElipse3.TargetControl = this.Verifybutton;
            // 
            // DisableVerifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 761);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisableVerifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisableVerifyForm";
            this.panel1.ResumeLayout(false);
            this.Verify.ResumeLayout(false);
            this.Verify.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDownIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerraricon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox RestoreDownIcon;
        private System.Windows.Forms.PictureBox maxIcon;
        private System.Windows.Forms.PictureBox minIcon;
        private System.Windows.Forms.PictureBox cerraricon;
        private System.Windows.Forms.Panel Verify;
        private System.Windows.Forms.Label VerifyMailLable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button verifyBackbutton;
        private System.Windows.Forms.TextBox DisiableCodetextBox;
        private System.Windows.Forms.Button Verifybutton;
        private System.Windows.Forms.Label OTPLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
    }
}