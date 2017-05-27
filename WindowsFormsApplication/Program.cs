using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication
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
            ClassLibrary.AppSetting settings = new ClassLibrary.AppSetting();
#if DEBUG
            settings.SaveConnectionString("DebugAdanpConnectionString");
#else
            settings.SaveConnectionString("ReleaseAdanpConnectionString");
#endif

            Application.Run(new Form1());
        }
    }
}
