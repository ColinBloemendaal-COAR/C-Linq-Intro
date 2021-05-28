using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Choose which form to run
            Application.Run(new Form12());

            // Form1 = Powerpoint slide 5 & 6
            // Form2 = Powerpoint slide 7
            // Form3 = Powerpoint slide 8 & 9
            // Form4 = Powerpoint slide 10 & 11
            // Form5 = Powerpoint slide 12 & 13
            // Form6 = Powerpoint slide 14 & 15
            // Form7 = Powerpoint slide 16 & 17
            // Form8 = Powerpoint slide 19 & 20
            // Form9 = Powerpoint slide 22, 23, 24 & 25
            // Form10 = Powerpoint slide 26 & 27
            // Form11 = Powerpoint slide 29 & 30
            // Form12 = Powerpoint slide 31 & 32

            
        }
    }
}
