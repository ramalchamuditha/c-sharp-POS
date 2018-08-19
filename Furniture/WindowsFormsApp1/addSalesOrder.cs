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
            // TODO: This line of code loads data into the 'productsDataSet2.furniture' table. You can move, or remove it, as needed.
            this.furnitureTableAdapter.Fill(this.productsDataSet2.furniture);
            // TODO: This line of code loads data into the 'cus_NO_DataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cus_NO_DataSet.customer);
            con = new sqlDBConnection();
            con.SqlQuery("Select isnull(max(cast(S_order_No as int)),0 )+1 from salesOrder");

            txt_s_o_No.Text = con.QueryEx().Rows[0][0].ToString(); 

            label2.Text = DateTime.Now.ToLongDateString();
            label6.Text = DateTime.Now.ToLongTimeString();

            

        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(combo_cus_No.Text))
                    MessageBox.Show("Please Select Customer Number", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (string.IsNullOrEmpty(combo_fur_No.Text))
                    MessageBox.Show("Please Select Furniture Number", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (string.IsNullOrEmpty(txt_qty.Text))
                    MessageBox.Show("Please Enter Quantity", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (txt_qty.Text.Any(char.IsLetter))
                    MessageBox.Show("Please check some characters are entered in Quantity", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (string.IsNullOrEmpty(txt_price.Text))
                    MessageBox.Show("Please Enter Price", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (txt_price.Text.Any(char.IsLetter))
                    MessageBox.Show("Please check some characters are entered in rice", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr.ToString() == "Yes")
                    {
                        con = new sqlDBConnection();

                        con.SqlQuery("INSERT INTO salesOrder(S_order_No, fur_no, qty, price, cus_no, date_Time,aval )VALUES (@a,@b,@c,@d,@e,@f,@g)");
                        con.cmd.Parameters.AddWithValue("@a", txt_s_o_No.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@b", combo_fur_No.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@c", txt_qty.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@d", txt_price.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@e", combo_cus_No.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@f", label2.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@g", "yes");
                        con.NonQueryEx();


                        MessageBox.Show("sales Order is Successfully inserted");

                        SoInvoice soi = new SoInvoice();
                        soi.Show();
                        this.Hide();

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

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(combo_cus_No.Text))
                    MessageBox.Show("Please Select Customer Number", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (string.IsNullOrEmpty(combo_fur_No.Text))
                    MessageBox.Show("Please Select Furniture Number", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (string.IsNullOrEmpty(txt_qty.Text))
                    MessageBox.Show("Please Enter Quantity", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (txt_qty.Text.Any(char.IsLetter))
                    MessageBox.Show("Please check some characters are entered in Quantity", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (string.IsNullOrEmpty(txt_price.Text))
                    MessageBox.Show("Please Enter Price", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (txt_price.Text.Any(char.IsLetter))
                    MessageBox.Show("Please check some characters are entered in rice", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr.ToString() == "Yes")
                    {

                        con = new sqlDBConnection();

                        
                        con.SqlQuery("INSERT INTO salesOrder(S_order_No, fur_no, qty, price, cus_no, date_Time,aval )VALUES (@a,@b,@c,@d,@e,@f,@g)");

                        con.cmd.Parameters.AddWithValue("@a", txt_s_o_No.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@b", combo_fur_No.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@c", txt_qty.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@d", txt_price.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@e", combo_cus_No.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@f", label2.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@g", "yes");
                        con.NonQueryEx();
                        
                        MessageBox.Show("sales Order is Successfully inserted");

                        con = new sqlDBConnection();
                        con.SqlQuery("Select isnull(max(cast(S_order_No as int)),0 )+1 from salesOrder");

                        txt_s_o_No.Text = con.QueryEx().Rows[0][0].ToString();

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

            
            txt_s_o_No.Text = "";
            combo_cus_No = null;
            combo_fur_No.Text = null;
            txt_qty.Text = "";
            txt_price.Text = "";




        }

        private void txt_s_o_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addMore_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (string.IsNullOrEmpty(combo_cus_No.Text))
                    MessageBox.Show("Please Select Customer Number", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (string.IsNullOrEmpty(combo_fur_No.Text))
                    MessageBox.Show("Please Select Furniture Number", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (string.IsNullOrEmpty(txt_qty.Text))
                    MessageBox.Show("Please Enter Quantity", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (txt_qty.Text.Any(char.IsLetter))
                    MessageBox.Show("Please check some characters are entered in Quantity", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (string.IsNullOrEmpty(txt_price.Text))
                    MessageBox.Show("Please Enter Price", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (txt_price.Text.Any(char.IsLetter))
                    MessageBox.Show("Please check some characters are entered in rice", "New Sales Order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr.ToString() == "Yes")
                    {
                        con = new sqlDBConnection();

                        con.SqlQuery("INSERT INTO salesOrder(S_order_No, fur_no, qty, price, cus_no, date_Time,aval )VALUES (@a,@b,@c,@d,@e,@f,@g)");
                        con.cmd.Parameters.AddWithValue("@a", txt_s_o_No.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@b", combo_fur_No.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@c", txt_qty.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@d", txt_price.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@e", combo_cus_No.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@f", label2.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@g", "yes");
                        con.NonQueryEx();


                        MessageBox.Show("sales Order is Successfully inserted");

                        
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

            combo_fur_No.Text = null;
            txt_qty.Text = "";
            txt_price.Text = "";
        }
    }
}
