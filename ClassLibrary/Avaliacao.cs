using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace ClassLibrary
{
    public class Avaliacao
    {
        public Int32 Id { get; set; }
        public Software SoftwareId { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public string NomeAvaliador { get; set; }
        public List<NotaAvaliacao> Notas { get; set; }

        public void Salvar()
        {
            try
            {
                using (SQLiteConnection connection = AppSetting.retornaConexao())
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand();
                    command.Connection = connection;
                    command.CommandText = String.Format("INSERT INTO Avaliacao (SoftwareId,DataAvaliacao,NomeAvaliador) VALUES ({0},'{1}','{2}'); SELECT last_insert_rowid()"
                        , this.SoftwareId.Id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),this.NomeAvaliador);
                    command.CommandType = CommandType.Text;
                    int retorno = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
