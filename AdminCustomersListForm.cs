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
    public partial class AdminCustomersListForm : Form
    {
        public AdminCustomersListForm()
        {
            InitializeComponent();
        }

        private void AdminCustomersListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet14.Parsonal' table. You can move, or remove it, as needed.
            this.parsonalTableAdapter.Fill(this.bankSystemDataBaseDataSet14.Parsonal);
            // TODO: This line of code loads data into the 'bankSystemDataBaseDataSet9.Parsonal' table. You can move, or remove it, as needed.

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            TotalCustomerslabel.Text = $"{CustomerListdataGridView.RowCount - 1}";
        }
    }
}
