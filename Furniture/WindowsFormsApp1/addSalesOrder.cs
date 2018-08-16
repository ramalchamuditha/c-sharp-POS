using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class addSalesOrder : Form
    {
        public addSalesOrder()
        {
            InitializeComponent();
        }

        private void addSalesOrder_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label6.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            SoInvoice soi = new SoInvoice();
            soi.Show();
        }
    }
}
