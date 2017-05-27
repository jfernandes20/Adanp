using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

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

        public void SaveConnectionString(string newConnection, string key)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = newConnection;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SQLite";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
