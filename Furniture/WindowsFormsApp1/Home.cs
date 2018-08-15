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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private int imageNumber =1;

        private void LoadNextImage()
        {
            if(imageNumber == 10)
            {
                imageNumber = 1; 

            }
            sildePic.ImageLocation = string.Format(@"image\{0}.jpg",imageNumber);
            imageNumber++;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
