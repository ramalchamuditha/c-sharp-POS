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
    public partial class addSalesOrder : Form
    {
        private sqlDBConnection con;
        public addSalesOrder()
        {
            InitializeComponent();
        }

        private void addSalesOrder_Load(object sender, EventArgs e)
        {
           /* con = new sqlDBConnection();
            con.SqlQuery("Select isnull(max(cast(S_order_no as int)),0 )+1 from salesOrderHeader");

            txt_s_o_No.Text = con.QueryEx().Rows[0][0].ToString(); */

            label2.Text = DateTime.Now.ToLongDateString();
            label6.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            SoInvoice soi = new SoInvoice();
            soi.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(combo_cus_No.Text))
                    MessageBox.Show("Please Select Customer Number", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(combo_fur_No.Text))
                    MessageBox.Show("Please Select Furniture Number", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_qty.Text))
                    MessageBox.Show("Please Enter Quantity", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (txt_qty.Text.Any(char.IsLetter))
                    MessageBox.Show("Please check some characters are entered in Quantity", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_price.Text))
                    MessageBox.Show("Please Enter Price", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (txt_price.Text.Any(char.IsLetter))
                    MessageBox.Show("Please check some characters are entered in rice", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr.ToString() == "Yes")
                    {
                        con = new sqlDBConnection();

                        con.SqlQuery("INSERT INTO salesOrder(S_order_no, fur_no, qty, price)VALUES (@a,@b,@c,@d)");
                        con.cmd.Parameters.AddWithValue("@a", txt_s_o_No.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@b", combo_fur_No.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@c", txt_qty.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@d", txt_price.Text.Trim());
                        con.NonQueryEx();


                        MessageBox.Show(" is Successfully updated");

                    }

                }


            }
            catch (SqlException)
            {
                MessageBox.Show("DataBase Error!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error on update!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void txt_s_o_No_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
