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
using System.Data.SqlTypes;

namespace WindowsFormsApp1
{
    public partial class forgetPW : Form
    {
        String uname;
        public forgetPW(String un)
        {
            InitializeComponent();
            uname = un;
        }
        new sqlDBConnection con;

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_npw.Text = "";
            txt_cpw.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }

        private void forgetPW_Load(object sender, EventArgs e)
        {
            if (uname!= "")
                txt_username.Text = uname;
            else
                txt_username.Enabled = true;
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            try
            {

                string newPassword = txt_npw.Text;
                string confirmPassword = txt_cpw.Text;

                if (String.IsNullOrEmpty(newPassword))
                    MessageBox.Show("Please Enter New Password", "Forget Password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(confirmPassword))
                    MessageBox.Show("Please Enter Confirm Password", "Forget Password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);


                else if (!string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(newPassword) && newPassword.Equals(confirmPassword))
                {
                    con = new sqlDBConnection();
                    con.SqlQuery("Update login set password = @a  where username = @i");
                    con.cmd.Parameters.AddWithValue("@i", txt_username.Text.Trim());
                    con.cmd.Parameters.AddWithValue("@a", txt_cpw.Text.Trim());

                    con.NonQueryEx();

                    MessageBox.Show("successfull Password Change", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginPage lp = new LoginPage();
                    lp.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Confirm password not matching with new passsword", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Error", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          

        }
    }
}
