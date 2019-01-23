using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace WindowsFormsApp2
{   
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int punkt = 0;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
