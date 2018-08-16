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
    public partial class SoInvoice : Form
    {
        public SoInvoice()
        {
            InitializeComponent();
        }

        private void newInvoice_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
            label6.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            makePayment mkp = new makePayment();
            mkp.Show();
        }
    }
}
