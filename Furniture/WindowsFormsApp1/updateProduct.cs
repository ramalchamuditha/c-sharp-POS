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
            // TODO: This line of code loads data into the 'productsDataSet1.furniture' table. You can move, or remove it, as needed.
            this.furnitureTableAdapter.Fill(this.productsDataSet1.furniture);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_FurNo.Text = dataGridView1.CurrentRow.Cells["fur_No"].Value.ToString();
            combo_type.Text = dataGridView1.CurrentRow.Cells["type"].Value.ToString();
            txt_Desc.Text = dataGridView1.CurrentRow.Cells["Descr"].Value.ToString();
            txt_price.Text = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
            txt_qty.Text = dataGridView1.CurrentRow.Cells["qty"].Value.ToString();
            txt_supNo.Text = dataGridView1.CurrentRow.Cells["sup_No"].Value.ToString();
        }
    }
}
