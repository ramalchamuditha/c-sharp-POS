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
    public partial class updateProduct : Form
    {
        public updateProduct()
        {
            InitializeComponent();
        }

        private void updateProduct_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_FurNo.Text = "";
            txt_Desc.Text = "";
            txt_price.Text = "";
            txt_qty.Text = "";
            txt_supNo.Text = "";
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
