using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Configuration;

namespace ClassLibrary
{
    public class SubCaracteristica
    {
        public int Id { get; set; }
        public int CaracteristicaId { get; set; }
        public string SubCaracteristicaNome { get; set; }

        public static List<SubCaracteristica> ListarSubCaracteristicas()
        {
            DataTable tabelaRetorno = new DataTable();
            using (SQLiteConnection connection = AppSetting.retornaConexao())
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = "SELECT SC.Id [SubCaracteristicaId], SC.CaracteristicaId, SC.SubCaracteristicaNome FROM SubCaracteristica SC;";
                command.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(tabelaRetorno);
                connection.Close();
            }
            List<SubCaracteristica> lista = new List<SubCaracteristica>();
            foreach (DataRow linhaSub in tabelaRetorno.AsEnumerable())
            {
                SubCaracteristica sub = new SubCaracteristica();
                sub.Id = Convert.ToInt32(linhaSub["SubCaracteristicaId"]);
                sub.CaracteristicaId = Convert.ToInt32(linhaSub["CaracteristicaId"]);
                sub.SubCaracteristicaNome = linhaSub["SubCaracteristicaNome"].ToString();
                lista.Add(sub);
            }
            return lista;
        }
    }
}
