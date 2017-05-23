using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Configuration;

namespace ClassLibrary
{
    public class Class1
    {
        public static DataTable teste()
        {
            DataTable tabelaRetorno = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["AdanpConnectionString"].ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = "select * from teste";
                command.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(tabelaRetorno);
            }
            return tabelaRetorno;
        }
        public static void inserirRegistro(string nome, string fone)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["AdanpConnectionString"].ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = "insert into teste (nome, fone) values (@nome, @fone)";
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@fone", fone);
                command.CommandType = CommandType.Text;       
                      
                command.ExecuteNonQuery();
            }
        }
    }
}
