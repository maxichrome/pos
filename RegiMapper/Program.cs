using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegiMapper
{
    static class Program
    {
        public static AppInstance MainAppInstance { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainAppInstance = new AppInstance();
        }
    }

    class AppInstance
    {
        public WelcomeForm AppWelcomeForm;

        public AppInstance()
        {
            Program.MainAppInstance = this;

            AppWelcomeForm = new WelcomeForm();
            Application.Run(AppWelcomeForm);
        }
    }
}
