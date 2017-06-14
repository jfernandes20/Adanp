using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace ClassLibrary
{
    public class Software
    {
        public int Id { get; set; }
        public string NomeSoftware { get; set; }
        public string TecnologiaSoftware { get; set; }
        public string FornecedorSoftware { get; set; }
        public DateTime DataInsercao { get; set; }

        public List<Software> ListarSoftware(string nomesoftware)
        {
            DataTable tabelaRetorno = new DataTable();
            using (SQLiteConnection connection = AppSetting.retornaConexao())
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = string.Format("SELECT * FROM Software WHERE NomeSoftware LIKE '%{0}%'", nomesoftware);
                command.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(tabelaRetorno);
                connection.Close();
            }
            List<Software> listaResultado = new List<Software>();
            foreach (DataRow linha in tabelaRetorno.AsEnumerable())
            {
                Software soft = new Software();
                soft.Id = Convert.ToInt32(linha["Id"]);
                soft.NomeSoftware = linha["NomeSoftware"].ToString();
                soft.TecnologiaSoftware = linha["TecnologiaSoftware"].ToString();
                soft.FornecedorSoftware = linha["FornecedorSoftware"].ToString();
                soft.DataInsercao = Convert.ToDateTime(linha["DataInsercao"]);
            }
            return listaResultado;
        }
    }
}
