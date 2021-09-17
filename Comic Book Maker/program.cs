using System;
using System.Windows.Forms;

namespace Comic_Book_Maker
{
    static class program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formMain(args));
        }
    }
}
