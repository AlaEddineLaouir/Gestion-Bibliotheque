using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioUIEmprenteur
{
    static class Program
    {
        public static Acceuil acceuil;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            acceuil = new Acceuil();
            Application.Run(acceuil);
        }
    }
}
