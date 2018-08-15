using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class products : UserControl
    {
        public products()
        {
            InitializeComponent();
        }

        private void btn_showProduct_Click(object sender, EventArgs e)
        {
            addProducts adp = new addProducts();
            adp.Show();
        }

        private void btn_showProduct_Click_1(object sender, EventArgs e)
        {
            updateProduct upd = new updateProduct();
            upd.Show();
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            deleteProduct dlp = new deleteProduct();
            dlp.Show();
        }
    }
}
