
namespace Bank
{
    partial class AccountVerifyForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistrationVerifytextBox = new System.Windows.Forms.TextBox();
            this.RegistrationVerifybutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1516, 830);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.RegistrationVerifybutton);
            this.panel2.Controls.Add(this.RegistrationVerifytextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(527, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 511);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(38, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code : ";
            // 
            // RegistrationVerifytextBox
            // 
            this.RegistrationVerifytextBox.BackColor = System.Drawing.Color.Wheat;
            this.RegistrationVerifytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationVerifytextBox.ForeColor = System.Drawing.Color.Black;
            this.RegistrationVerifytextBox.Location = new System.Drawing.Point(114, 261);
            this.RegistrationVerifytextBox.Name = "RegistrationVerifytextBox";
            this.RegistrationVerifytextBox.Size = new System.Drawing.Size(343, 34);
            this.RegistrationVerifytextBox.TabIndex = 1;
            // 
            // RegistrationVerifybutton
            // 
            this.RegistrationVerifybutton.BackColor = System.Drawing.Color.DarkOrange;
            this.RegistrationVerifybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationVerifybutton.Location = new System.Drawing.Point(210, 364);
            this.RegistrationVerifybutton.Name = "RegistrationVerifybutton";
            this.RegistrationVerifybutton.Size = new System.Drawing.Size(101, 51);
            this.RegistrationVerifybutton.TabIndex = 2;
            this.RegistrationVerifybutton.Text = "Verify";
            this.RegistrationVerifybutton.UseVisualStyleBackColor = false;
            this.RegistrationVerifybutton.Click += new System.EventHandler(this.RegistrationVerifybutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(55, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Verification Code";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Bank.Properties.Resources.rsz_rsz_1pngtree_concept_banking_logo_png_image_712961_removebg_preview;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 234);
            this.panel3.TabIndex = 1;
            // 
            // AccountVerifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1540, 854);
            this.Controls.Add(this.panel1);
            this.Name = "AccountVerifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountVerifyForm";
            this.Load += new System.EventHandler(this.AccountVerifyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox RegistrationVerifytextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegistrationVerifybutton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}