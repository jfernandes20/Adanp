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

            string releaseConnectionString = @"Data Source=adanp.db";
            string debugConnectionString = @"Data Source=..\..\..\DB\adanp.db";
            ClassLibrary.AppSetting settings = new ClassLibrary.AppSetting();
#if DEBUG
            settings.SaveConnectionString(debugConnectionString, "AdanpConnectionString");
#else
            settings.SaveConnectionString(releaseConnectionString, "AdanpConnectionString");
#endif

            Application.Run(new Form1());
        }
    }
}
