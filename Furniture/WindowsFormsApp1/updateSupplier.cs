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

        sqlDBConnection con;

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(txt_Fname.Text) || String.IsNullOrEmpty(txt_Lname.Text))
                    MessageBox.Show("Please Enter Name", "New Supplier", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (txt_NIC.Text.Any(char.IsLetter))
                    MessageBox.Show("Please check some characters are entered in NIC", "New Suppiler", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_NIC.Text))
                    MessageBox.Show("Please Enter NIC Number", "New Supplier", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_add1.Text) || String.IsNullOrEmpty(txt_add2.Text) || String.IsNullOrEmpty(txt_add3.Text))
                    MessageBox.Show("Please enter Address", "New Supplier", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_tele.Text))
                    MessageBox.Show("Please Enter Contact Number", "New Supplier", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (txt_tele.Text.Any(char.IsLetter))
                    MessageBox.Show("Please check some characters are entered in Contact Number", "New Supplier", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_reg.Text))
                    MessageBox.Show("Please Select Register Number", "New Supplier", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr.ToString() == "Yes")
                    {
                        con = new sqlDBConnection();
                        con.SqlQuery("Update supplier set sup_Fname= @a ,sup_Lname= @b ,sup_NIC= @c ,sup_add1= @d ,sup_add2= @e,sup_add3= @f,sup_tele= @g,sup_regNo= @h where sup_No= @i");
                        con.cmd.Parameters.AddWithValue("@i", txt_supNo.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@a", txt_Fname.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@b", txt_Lname.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@c", txt_NIC.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@d", txt_add1.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@e", txt_add2.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@f", txt_add3.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@g", txt_tele.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@h", txt_reg.Text.Trim());

                        con.NonQueryEx();

                        MessageBox.Show("Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        con = new sqlDBConnection();
                        con.SqlQuery("select * from supplier");
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
