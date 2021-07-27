
namespace Bank
{
    partial class EmailVerifyForm
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
            this.cerraricon = new System.Windows.Forms.PictureBox();
            this.varifyEmailpanel = new System.Windows.Forms.Panel();
            this.EmalAddresslabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailVerifybutton = new System.Windows.Forms.Button();
            this.EmailVerifytextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerraricon)).BeginInit();
            this.varifyEmailpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cerraricon);
            this.panel1.Controls.Add(this.varifyEmailpanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 524);
            this.panel1.TabIndex = 0;
            // 
            // cerraricon
            // 
            this.cerraricon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerraricon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerraricon.Image = global::Bank.Properties.Resources._60994;
            this.cerraricon.Location = new System.Drawing.Point(590, 12);
            this.cerraricon.Name = "cerraricon";
            this.cerraricon.Size = new System.Drawing.Size(20, 20);
            this.cerraricon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerraricon.TabIndex = 38;
            this.cerraricon.TabStop = false;
            this.cerraricon.Click += new System.EventHandler(this.cerraricon_Click);
            // 
            // varifyEmailpanel
            // 
            this.varifyEmailpanel.Controls.Add(this.EmalAddresslabel);
            this.varifyEmailpanel.Controls.Add(this.label4);
            this.varifyEmailpanel.Controls.Add(this.label3);
            this.varifyEmailpanel.Controls.Add(this.label2);
            this.varifyEmailpanel.Controls.Add(this.EmailVerifybutton);
            this.varifyEmailpanel.Controls.Add(this.EmailVerifytextBox);
            this.varifyEmailpanel.Controls.Add(this.label1);
            this.varifyEmailpanel.Location = new System.Drawing.Point(46, 38);
            this.varifyEmailpanel.Name = "varifyEmailpanel";
            this.varifyEmailpanel.Size = new System.Drawing.Size(526, 451);
            this.varifyEmailpanel.TabIndex = 1;
            this.varifyEmailpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.varifyEmailpanel_Paint);
            // 
            // EmalAddresslabel
            // 
            this.EmalAddresslabel.AutoSize = true;
            this.EmalAddresslabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.EmalAddresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmalAddresslabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.EmalAddresslabel.Location = new System.Drawing.Point(55, 182);
            this.EmalAddresslabel.Name = "EmalAddresslabel";
            this.EmalAddresslabel.Size = new System.Drawing.Size(151, 25);
            this.EmalAddresslabel.TabIndex = 6;
            this.EmalAddresslabel.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(55, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password (OTP) to your email ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(55, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "To verify your email, we\'ve sent a One Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(55, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verify Email Address";
            // 
            // EmailVerifybutton
            // 
            this.EmailVerifybutton.BackColor = System.Drawing.Color.DarkOrange;
            this.EmailVerifybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailVerifybutton.Location = new System.Drawing.Point(62, 335);
            this.EmailVerifybutton.Name = "EmailVerifybutton";
            this.EmailVerifybutton.Size = new System.Drawing.Size(344, 51);
            this.EmailVerifybutton.TabIndex = 2;
            this.EmailVerifybutton.Text = "Verify";
            this.EmailVerifybutton.UseVisualStyleBackColor = false;
            this.EmailVerifybutton.Click += new System.EventHandler(this.EmailVerifybutton_Click);
            // 
            // EmailVerifytextBox
            // 
            this.EmailVerifytextBox.BackColor = System.Drawing.Color.Wheat;
            this.EmailVerifytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailVerifytextBox.ForeColor = System.Drawing.Color.Black;
            this.EmailVerifytextBox.Location = new System.Drawing.Point(63, 271);
            this.EmailVerifytextBox.Name = "EmailVerifytextBox";
            this.EmailVerifytextBox.Size = new System.Drawing.Size(343, 34);
            this.EmailVerifytextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(58, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter OTP ";
            // 
            // EmailVerifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 524);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmailVerifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailVerifyForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerraricon)).EndInit();
            this.varifyEmailpanel.ResumeLayout(false);
            this.varifyEmailpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel varifyEmailpanel;
        private System.Windows.Forms.Label EmalAddresslabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EmailVerifybutton;
        private System.Windows.Forms.TextBox EmailVerifytextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox cerraricon;
    }
}