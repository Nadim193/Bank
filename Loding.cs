using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Loding : Form
    {
        public Loding()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar.Width += 3;
            if(ProgressBar.Width >= 750)
            {
                timer1.Stop();
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
        }
    }
}
