using System;
using System.Windows.Forms;

namespace PizzaProject
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
            Application.Run(new Splash());                          ///how splash screen was entered before main form
            Application.Run(new frmMiPi());     
        }
    }
}
