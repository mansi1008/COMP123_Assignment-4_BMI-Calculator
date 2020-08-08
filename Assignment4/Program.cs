using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    static class Program
    {
        public static SplashForm splashform;
        public static BMICalculator bmiCalculator;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            splashform = new SplashForm();
            bmiCalculator = new BMICalculator();

            Application.Run(splashform);
        }
    }
}
