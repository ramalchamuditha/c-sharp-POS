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


            

            

            Application.Run(new LoginPage());
=======
            Application.Run(new SoInvoice());
>>>>>>> 7d286ba86ac4d0aeab481c24aeaff2bf6ee7b49f
            
        
           
        }
    }
}
