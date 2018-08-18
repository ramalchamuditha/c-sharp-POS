using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class SoInvoice : Form
    {
        public SoInvoice()
        {
            InitializeComponent();
        }
        sqlDBConnection con;

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

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                con = new sqlDBConnection();
                con.SqlQuery("select fur_no, qty, price, cus_no, date_Time FROM salesOrder where S_order_No= @a");
                con.cmd.Parameters.AddWithValue("@a", combo_SONo.Text.Trim());
                dataGridView1.DataSource = con.QueryEx();

            }
            catch (SqlException)
            {
                MessageBox.Show("DataBase Error!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error on display!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
