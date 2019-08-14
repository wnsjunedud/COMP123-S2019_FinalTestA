using COMP123_S2019_FinalTestA.Views;
using COMP123_S2019_FinalTestA.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Student Name : Juneyeong Lee
 * Student Id : 301043697
 * Description : This is the Program Class
 */

namespace COMP123_S2019_FinalTestA
{
    static class Program
    {
        public static HeroGenerator heroGenerator;
        public static AboutForm aboutForm;
        public static Hero character;
        //this temporary
        //The main entry point for the application
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            heroGenerator = new HeroGenerator();
            aboutForm = new AboutForm();
            character = new Hero();

            Application.Run(heroGenerator);
        }
    }
}
