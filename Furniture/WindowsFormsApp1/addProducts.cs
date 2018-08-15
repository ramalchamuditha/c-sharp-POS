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
            txt_supNo.Text = "";
            combo_type.Text = "";
        }

        private void addProducts_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            con = new sqlDBConnection();
            con.SqlQuery("INSERT INTO furniture(fur_No, Descr, price, type, qty, sup_No)VALUES (@a, @b,@c,@d,@e,@f)");
            con.cmd.Parameters.AddWithValue("@a", txt_FurNo.Text.Trim());
            con.cmd.Parameters.AddWithValue("@b", txt_Desc.Text.Trim());
            con.cmd.Parameters.AddWithValue("@c", txt_price.Text.Trim());
            con.cmd.Parameters.AddWithValue("@d", combo_type.Text.Trim());
            con.cmd.Parameters.AddWithValue("@e", txt_qty.Text.Trim());
            con.cmd.Parameters.AddWithValue("@f", txt_supNo.Text.Trim());
            con.NonQueryEx();
            MessageBox.Show("Product is Successfully updated");

        }
    }
}
