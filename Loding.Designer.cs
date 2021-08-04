
namespace Bank
{
    partial class Loding
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
            this.label1 = new System.Windows.Forms.Label();
            this.Progresspanel = new System.Windows.Forms.Panel();
            this.ProgressBar = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RestoreDownIcon = new System.Windows.Forms.PictureBox();
            this.maxIcon = new System.Windows.Forms.PictureBox();
            this.minIcon = new System.Windows.Forms.PictureBox();
            this.cerraricon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDownIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerraricon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(406, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOADING.....";
            // 
            // Progresspanel
            // 
            this.Progresspanel.Location = new System.Drawing.Point(1, 439);
            this.Progresspanel.Name = "Progresspanel";
            this.Progresspanel.Size = new System.Drawing.Size(987, 18);
            this.Progresspanel.TabIndex = 4;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.DarkOrange;
            this.ProgressBar.Location = new System.Drawing.Point(4, 439);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(98, 18);
            this.ProgressBar.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(57, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "© 2021 Bank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(57, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = " All Rights Reserved";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(57, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "v1.0.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources.bank_account_banking_building_1_31235;
            this.pictureBox1.Location = new System.Drawing.Point(400, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // RestoreDownIcon
            // 
            this.RestoreDownIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreDownIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreDownIcon.Image = global::Bank.Properties.Resources.restore_down;
            this.RestoreDownIcon.Location = new System.Drawing.Point(927, 11);
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
            this.maxIcon.Location = new System.Drawing.Point(927, 11);
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
            this.minIcon.Location = new System.Drawing.Point(894, 11);
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
            this.cerraricon.Location = new System.Drawing.Point(960, 11);
            this.cerraricon.Name = "cerraricon";
            this.cerraricon.Size = new System.Drawing.Size(20, 20);
            this.cerraricon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerraricon.TabIndex = 37;
            this.cerraricon.TabStop = false;
            this.cerraricon.Click += new System.EventHandler(this.cerraricon_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(392, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 2);
            this.panel2.TabIndex = 41;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkOrange;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(626, 94);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(2, 159);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Location = new System.Drawing.Point(395, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 2);
            this.panel3.TabIndex = 43;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DarkOrange;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(392, 95);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(2, 159);
            this.flowLayoutPanel2.TabIndex = 44;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 10;
            this.gunaElipse2.TargetControl = this.ProgressBar;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // Loding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(991, 460);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RestoreDownIcon);
            this.Controls.Add(this.maxIcon);
            this.Controls.Add(this.minIcon);
            this.Controls.Add(this.cerraricon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Progresspanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loding";
            this.Load += new System.EventHandler(this.Loding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDownIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerraricon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Progresspanel;
        private System.Windows.Forms.Panel ProgressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox RestoreDownIcon;
        private System.Windows.Forms.PictureBox maxIcon;
        private System.Windows.Forms.PictureBox minIcon;
        private System.Windows.Forms.PictureBox cerraricon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}