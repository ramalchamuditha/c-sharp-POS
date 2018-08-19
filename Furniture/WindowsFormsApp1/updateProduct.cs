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
    public partial class updateProduct : Form
    {
        public updateProduct()
        {
            InitializeComponent();
        }
         sqlDBConnection con;

        private void updateProduct_Load(object sender, EventArgs e)
        {
            try
            {
                con = new sqlDBConnection();
                con.SqlQuery("select * from furniture");
                dataGridView1.DataSource =  con.QueryEx();

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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_FurNo.Text = "";
            txt_Desc.Text = "";
            txt_price.Text = "";
            txt_qty.Text = "";
            combo_sup.Text = "";

            con = new sqlDBConnection();
            con.SqlQuery("select * from furniture");
            dataGridView1.DataSource = con.QueryEx();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_FurNo.Text = dataGridView1.CurrentRow.Cells["fur_No"].Value.ToString();
            combo_type.Text = dataGridView1.CurrentRow.Cells["type"].Value.ToString();
            txt_Desc.Text = dataGridView1.CurrentRow.Cells["Descr"].Value.ToString();
            txt_price.Text = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
            txt_qty.Text = dataGridView1.CurrentRow.Cells["qty"].Value.ToString();
            combo_sup.Text = dataGridView1.CurrentRow.Cells["sup_No"].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_Desc.Text))
                    MessageBox.Show("Please Enter Product Description", "New Product", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_price.Text))
                    MessageBox.Show("Please enter Price of Product", "New Product", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (txt_price.Text.Any(char.IsLetter))
                    MessageBox.Show("Please check some characters are entered in Price", "New Product", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(combo_type.Text))
                    MessageBox.Show("Please Select Type of Product", "New Product", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_qty.Text))
                    MessageBox.Show("Please Enter Quantity", "New Product", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (txt_qty.Text.Any(char.IsLetter))
                    MessageBox.Show("Please check some characters are entered in Quantity", "New Product", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(combo_sup.Text))
                    MessageBox.Show("Please Select Product Supplier", "New Product", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr.ToString() == "Yes")
                    {
                        con = new sqlDBConnection();
                        con.SqlQuery("Update furniture set Descr=@a ,price= @b ,type= @c ,qty= @d ,sup_No= @e where fur_No= @f");
                        con.cmd.Parameters.AddWithValue("@f", txt_FurNo.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@a", txt_Desc.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@b", txt_price.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@c", combo_type.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@d", txt_qty.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@e", combo_sup.Text.Trim());

                        con.NonQueryEx();

                        MessageBox.Show("Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        con = new sqlDBConnection();
                        con.SqlQuery("select * from furniture");
                        dataGridView1.DataSource = con.QueryEx();

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
    }
}
