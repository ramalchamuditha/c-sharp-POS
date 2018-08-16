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
    public partial class updateSupplier : Form
    {
        public updateSupplier()
        {
            InitializeComponent();
        }

        new sqlDBConnection con;

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_supNo.Text = "";
            txt_Fname.Text = "";
            txt_Lname.Text = "";
            txt_NIC.Text = "";
            txt_add1.Text = "";
            txt_add2.Text = "";
            txt_add3.Text = "";
            txt_tele.Text = "";
            txt_reg.Text = "";

            con = new sqlDBConnection();
            con.SqlQuery("select * from supplier");
            dataGridView1.DataSource = con.QueryEx();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updateSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                con = new sqlDBConnection();
                con.SqlQuery("select * from supplier");
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
            txt_supNo.Text = dataGridView1.CurrentRow.Cells["sup_No"].Value.ToString();
            txt_Fname.Text = dataGridView1.CurrentRow.Cells["sup_Fname"].Value.ToString();
            txt_Lname.Text = dataGridView1.CurrentRow.Cells["sup_Lname"].Value.ToString();
            txt_NIC.Text = dataGridView1.CurrentRow.Cells["sup_NIC"].Value.ToString();
            txt_add1.Text = dataGridView1.CurrentRow.Cells["sup_add1"].Value.ToString();
            txt_add2.Text = dataGridView1.CurrentRow.Cells["sup_add2"].Value.ToString();
            txt_add3.Text = dataGridView1.CurrentRow.Cells["sup_add3"].Value.ToString();
            txt_tele.Text = dataGridView1.CurrentRow.Cells["sup_tele"].Value.ToString();
            txt_reg.Text = dataGridView1.CurrentRow.Cells["sup_regNO"].Value.ToString();
        }
    }
}
