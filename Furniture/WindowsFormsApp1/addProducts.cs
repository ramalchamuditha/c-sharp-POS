using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class addProducts : Form
    {
        private sqlDBConnection con;
        public addProducts()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        { 
            this.Hide();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_FurNo.Text = "";
            txt_Desc.Text = "";
            txt_price.Text = "";
            txt_qty.Text = "";
            combo_sup.Text = "";
            combo_type.Text = "";
        }

        private void addProducts_Load(object sender, EventArgs e)
        {

        }
          
        private void btn_add_Click(object sender, EventArgs e)
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
                    DialogResult dr = MessageBox.Show("Do you want to Continue ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr.ToString() == "Yes")
                    {
                        con = new sqlDBConnection();
                        con.SqlQuery("INSERT INTO furniture(fur_No, Descr, price, type, qty, sup_No)VALUES (@a, @b,@c,@d,@e,@f)");
                        con.cmd.Parameters.AddWithValue("@a", txt_FurNo.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@b", txt_Desc.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@c", txt_price.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@d", combo_type.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@e", txt_qty.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@f", combo_sup.Text.Trim());
                        con.nonQueryEx();
                        MessageBox.Show("Data inserted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                         txt_FurNo.Text = "";
                         txt_Desc.Text = "";
                         txt_price.Text = "";
                         txt_qty.Text = "";
                         combo_sup.Text = "";
                         combo_type.Text = "";
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
