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
    public partial class HomePage : Form
    {

        string man;
        public HomePage(string m)
        {
            InitializeComponent();

            man = m;
           
        }
       
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Supplier_Click(object sender, EventArgs e)
        {
           
            Movingpanel.Height = btn_Supplier.Height;
            Movingpanel.Top = btn_Supplier.Top;
            supplier1.BringToFront();
            
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Movingpanel.Height = btn_Home.Height;
            Movingpanel.Top = btn_Home.Top;
            home1.BringToFront();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            if(man == "Manager")
            {
                btn_Supplier.Enabled = true;
            }
            else
            {
                btn_Supplier.Enabled = false;
            }

            Movingpanel.Height = btn_Home.Height;
            Movingpanel.Top = btn_Home.Top;
            home1.BringToFront();

            
        }

        private void products1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            Movingpanel.Height = btn_Products.Height;
            Movingpanel.Top = btn_Products.Top;
            products1.BringToFront();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            Movingpanel.Height = btn_payment.Height;
            Movingpanel.Top = btn_payment.Top;
            payment1.BringToFront();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            Movingpanel.Height = btn_Reports.Height;
            Movingpanel.Top = btn_Reports.Top;
            reports1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Movingpanel.Height = btn_logout.Height;
            Movingpanel.Top = btn_logout.Top;

            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();


        }
    }
}
