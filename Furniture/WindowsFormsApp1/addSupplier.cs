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
    public partial class addSupplier : Form
    {
        private sqlDBConnection con;
        public addSupplier()
        {
            InitializeComponent();
        }

        private void addSupplier_Load(object sender, EventArgs e)
        {
            con = new sqlDBConnection();
            con.SqlQuery("Select isnull(max(cast(sup_No as int)),0 )+1 from supplier");
            
            txt_supNo.Text = con.QueryEx().Rows[0][0].ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            con.SqlQuery("Select isnull(max(cast(sup_No as int)),0 )+1 from supplier");

            txt_supNo.Text = con.QueryEx().Rows[0][0].ToString();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_Fname.Text)|| String.IsNullOrEmpty(txt_Lname.Text))
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
                    DialogResult dr = MessageBox.Show("Do you want to Continue ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr.ToString() == "Yes")
                    {

                        con = new sqlDBConnection();
                        con.SqlQuery("INSERT INTO supplier(sup_No, sup_Fname, sup_Lname, sup_NIC, sup_add1, sup_add2, sup_add3, sup_tele, sup_regNo)VALUES (@a,@b,@c,@d,@e,@f,@g,@h,@i)");
                        con.cmd.Parameters.AddWithValue("@a", txt_supNo.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@b", txt_Fname.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@c", txt_Lname.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@d", txt_NIC.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@e", txt_add1.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@f", txt_add2.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@g", txt_add3.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@h", txt_tele.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@i", txt_reg.Text.Trim());
                        con.NonQueryEx();
                        MessageBox.Show("Suppiler is Successfully updated");

                        con = new sqlDBConnection();
                        con.SqlQuery("Select isnull(max(cast(sup_No as int)),0 )+1 from supplier");

                        txt_supNo.Text = con.QueryEx().Rows[0][0].ToString();

                    }
                    else
                         txt_supNo.Text = "";
                         txt_Fname.Text = "";
                         txt_Lname.Text = "";
                         txt_NIC.Text = "";
                         txt_add1.Text = "";
                         txt_add2.Text = "";
                         txt_add3.Text = "";
                         txt_tele.Text = "";
                         txt_reg.Text = "";
                   
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
