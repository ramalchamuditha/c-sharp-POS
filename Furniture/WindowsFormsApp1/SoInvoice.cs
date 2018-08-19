using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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

            con = new sqlDBConnection();
            con.SqlQuery("Select isnull(max(cast(Invoice_No as int)),0 )+1 from Invoice");

            txt_invoiceNo.Text = con.QueryEx().Rows[0][0].ToString();

            SqlDataReader mreader;
            try
            {
                con = new sqlDBConnection();
                con.SqlQuery("select S_order_No FROM salesOrder WHERE aval = 'yes'");
                mreader = con.cmd.ExecuteReader();
                while(mreader.Read())
                {
                    string sord = mreader.GetString(0);
                    combo_SONo.Items.Add(sord);
                }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            text_cusNo.Text = dataGridView1.CurrentRow.Cells["cus_no"].Value.ToString();
            text_Price.Text = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            float sum = 0;
            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            try
            {
                decimal tot = 0;

                for (int i = 1; i < dataGridView1.RowCount - 1; i++)
                {
                    tot += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                }

                if (tot == 0)
                {

                }
                txt_value.Text = tot.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
    }
}
