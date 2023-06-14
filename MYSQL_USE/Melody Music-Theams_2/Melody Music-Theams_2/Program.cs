using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melody_Music_Theams_2
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
#pragma warning disable CS0246 // The type or namespace name 'Form1' could not be found (are you missing a using directive or an assembly reference?)
            Application.Run(new Welcome());
#pragma warning restore CS0246 // The type or namespace name 'Form1' could not be found (are you missing a using directive or an assembly reference?)
        }
    }
}
