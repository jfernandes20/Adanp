using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data.SQLite;


namespace ClassLibrary
{
    public class AppSetting
    {
        Configuration config;

        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public void SaveConnectionString(string key)
        {
            config.ConnectionStrings.ConnectionStrings["AdanpConnectionString"].ConnectionString = GetConnectionString(key);
            config.ConnectionStrings.ConnectionStrings["AdanpConnectionString"].ProviderName = "System.Data.SQLite";
            config.Save(ConfigurationSaveMode.Modified);

        }
        public static SQLiteConnection retornaConexao()
        {

#if DEBUG
            return new SQLiteConnection(ConfigurationManager.ConnectionStrings["DebugAdanpConnectionString"].ConnectionString);
#else
           return new SQLiteConnection(ConfigurationManager.ConnectionStrings["ReleaseAdanpConnectionString"].ConnectionString);  
#endif
        }
    }
}
