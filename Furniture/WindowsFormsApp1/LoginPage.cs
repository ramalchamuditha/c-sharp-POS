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
    public partial class LoginPage : Form
    {
       
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                    MessageBox.Show("Please Enter Username", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (String.IsNullOrEmpty(textBox2.Text))
                    MessageBox.Show("Please Enter Password", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-79N0E5I\SQLEXPRESS;Initial Catalog=Products;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username ='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);


                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        
                        HomePage hp = new HomePage(textBox1.Text);
                        hp.Show();
                        this.Hide();   
                    }
                    else
                    {
                        MessageBox.Show("Please enter Correct Username and Password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        textBox2.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetPW pw = new forgetPW(textBox1.Text);
            pw.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
