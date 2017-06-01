using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Configuration;

namespace ClassLibrary
{
    public class Caracteristica
    {
        public int Id { get; set; }
        public int CaracteristicaNumero { get; set; }
        public string CaracteristicaNome { get; set; }
        List<SubCaracteristica> SubCaracteristicas { get; set; }

        public List<Caracteristica> ListarCaracteristicas()
        {
            DataSet tabelaRetorno = new DataSet();
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["AdanpConnectionString"].ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = "SELECT C.Id [CaracteristicaId], C.CaracteristicaNumero, C.CaracteristicaNome FROM Caracteristica C; SELECT SC.Id [SubCaracteristicaId], SC.CaracteristicaId, SC.SubCaracteristicaNome FROM SubCaracteristica SC;";
                command.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(tabelaRetorno);
                connection.Close();
            }
            List<Caracteristica> lista = new List<Caracteristica>();

            foreach (DataRow linha in tabelaRetorno.Tables[0].AsEnumerable())
            {
                Caracteristica caract = new Caracteristica();
                caract.Id = Convert.ToInt32(linha["CaracteristicaId"]);
                caract.CaracteristicaNumero = Convert.ToInt32(linha["CaracteristicaNumero"]);
                caract.CaracteristicaNome = linha["CaracteristicaNome"].ToString();

                caract.SubCaracteristicas = new List<SubCaracteristica>();
                foreach (DataRow linhaSub in tabelaRetorno.Tables[1].AsEnumerable().Where(d => d["CaracteristicaId"].Equals(linha["CaracteristicaId"])))
                {
                    SubCaracteristica sub = new SubCaracteristica();
                    sub.Id = Convert.ToInt32(linhaSub["SubCaracteristicaId"]);
                    sub.SubCaracteristicaNome = linhaSub["SubCaracteristicaNome"].ToString();
                    caract.SubCaracteristicas.Add(sub);
                }
                lista.Add(caract);
            }
            return lista;
        }
    }
}
