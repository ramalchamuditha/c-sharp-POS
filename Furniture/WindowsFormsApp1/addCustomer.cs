using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class addCustomer : Form
    {
        sqlDBConnection con;
        public addCustomer()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_Fname.Text) || String.IsNullOrEmpty(txt_Lname.Text))
                    MessageBox.Show("Please Enter Name Correctly", "New Customer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (txt_NIC.Text.Any(char.IsLetter))
                    MessageBox.Show("Please check some characters are entered in NIC", "New Customer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_NIC.Text))
                    MessageBox.Show("Please Enter NIC Number", "New Customer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_add1.Text) || String.IsNullOrEmpty(txt_add2.Text) || String.IsNullOrEmpty(txt_add3.Text))
                    MessageBox.Show("Please enter Address", "New Customer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(txt_tele.Text))
                    MessageBox.Show("Please Enter Contact Number", "New Customer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (txt_tele.Text.Any(char.IsLetter))
                    MessageBox.Show("Please check some characters are entered in Contact Number", "New Customer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                

                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to Continue ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr.ToString() == "Yes")
                    {

                        con = new sqlDBConnection();
                        con.SqlQuery("INSERT INTO customer(cus_No, cus_Fname, cus_Lname, cus_NIC, cus_add1, cus_add2, cus_add3, cus_Tele)VALUES (@a,@b,@c,@d,@e,@f,@g,@h)");
                        con.cmd.Parameters.AddWithValue("@a", txt_cusNo.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@b", txt_Fname.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@c", txt_Lname.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@d", txt_NIC.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@e", txt_add1.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@f", txt_add2.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@g", txt_add3.Text.Trim());
                        con.cmd.Parameters.AddWithValue("@h", txt_tele.Text.Trim());
                        
                        con.NonQueryEx();
                        MessageBox.Show("Suppiler is Successfully updated");

                        addSalesOrder aso = new addSalesOrder();
                        aso.Show();
                        this.Hide();

                        

                    }
                    else
                        txt_cusNo.Text = "";
                        txt_Fname.Text = "";
                        txt_Lname.Text = "";
                        txt_NIC.Text = "";
                        txt_add1.Text = "";
                        txt_add2.Text = "";
                        txt_add3.Text = "";
                        txt_tele.Text = "";
                   

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_cusNo.Text = "";
            txt_Fname.Text = "";
            txt_Lname.Text = "";
            txt_NIC.Text = "";
            txt_add1.Text = "";
            txt_add2.Text = "";
            txt_add3.Text = "";
            txt_tele.Text = "";
           

            con = new sqlDBConnection();
            con.SqlQuery("Select isnull(max(cast(cus_No as int)),0 )+1 from customer");

            txt_cusNo.Text = con.QueryEx().Rows[0][0].ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addCustomer_Load(object sender, EventArgs e)
        {
            con = new sqlDBConnection();
            con.SqlQuery("Select isnull(max(cast(cus_No as int)),0 )+1 from customer");

            txt_cusNo.Text = con.QueryEx().Rows[0][0].ToString();
        }
    }
}
