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

    
    public partial class supplier : UserControl
        
    {

        
        public supplier()
        {
            InitializeComponent();
            
        }


        private void supplier_Load(object sender, EventArgs e)
        {
         
           
        }

        private void btn_addSupplier_Click(object sender, EventArgs e)
        {

            
        }

        private void btn_viewSupplier_Click(object sender, EventArgs e)
        {
            updateSupplier ups = new updateSupplier();
            ups.Show();
        }

        private void btn_deleteSupplier_Click(object sender, EventArgs e)
        {
            deleteSupplier dls = new deleteSupplier();
            dls.Show();
        }
    }
}
