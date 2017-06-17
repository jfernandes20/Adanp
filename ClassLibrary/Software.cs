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

        public static List<Software> ListarSoftware(string nomesoftware)
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
                listaResultado.Add(soft);
            }
            return listaResultado;
        }

        public void Salvar()
        {
            try
            {
                if (this.Id == 0)
                {
                    using (SQLiteConnection connection = AppSetting.retornaConexao())
                    {
                        connection.Open();
                        SQLiteCommand command = new SQLiteCommand();
                        command.Connection = connection;
                        command.CommandText = String.Format("INSERT INTO Software (NomeSoftware,TecnologiaSoftware, FornecedorSoftware, DataInsercao) VALUES ('{0}','{1}','{2}','{3}')",
                            this.NomeSoftware, this.TecnologiaSoftware, this.FornecedorSoftware, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                else
                {
                    using (SQLiteConnection connection = AppSetting.retornaConexao())
                    {
                        connection.Open();
                        SQLiteCommand command = new SQLiteCommand();
                        command.Connection = connection;
                        command.CommandText = String.Format("UPDATE Software SET NomeSoftware = '{0}', TecnologiaSoftware = '{1}', FornecedorSoftware = '{2}' where Id = {3}",
                            this.NomeSoftware, this.TecnologiaSoftware, this.FornecedorSoftware, this.Id);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Excluir()
        {
            try
            {
                bool retorno;
                using (SQLiteConnection connection = AppSetting.retornaConexao())
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand();
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT EXISTS(SELECT 1 FROM Avaliacao WHERE SoftwareId = {0})", this.Id);
                    command.CommandType = CommandType.Text;
                    bool possuiAvaliacao = Convert.ToBoolean(command.ExecuteScalar());
                    if (possuiAvaliacao)
                        retorno = false;
                    else
                    {
                        command.CommandText = String.Format("DELETE FROM Software where Id = {0}", this.Id);
                        command.ExecuteNonQuery();
                        retorno = true;
                    }
                    connection.Close();
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

