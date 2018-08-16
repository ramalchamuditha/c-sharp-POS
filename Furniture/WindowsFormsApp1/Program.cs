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
<<<<<<< HEAD

            Application.Run(new addProducts());

            
=======
            Application.Run(new updateProduct());
>>>>>>> c49de22100a29dc9f93468d7ceb72ecf1ca5c7b2
=======
            Application.Run(new addProducts());
>>>>>>> 436ecc6b4554a540e4fd0a98888e9f035ca5b3e8

        }
    }
}
