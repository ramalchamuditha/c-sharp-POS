using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD


            

            

            Application.Run(new updateSupplier());
            

=======
            Application.Run(new HomePage());
>>>>>>> 6fc38f7c4a2d3d90fea7513c3fa8118d82cf1796

        }
    }
}
