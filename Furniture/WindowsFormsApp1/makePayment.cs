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
    public partial class makePayment : Form
    {
        public makePayment()
        {
            InitializeComponent();
        }

        private void makePayment_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label6.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_payID.Text = "";
            txt_amount.Text = "";
            txt_balance.Text = "";
            comboBox1.Text = "";
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
