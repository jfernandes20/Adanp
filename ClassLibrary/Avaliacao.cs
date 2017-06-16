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
        public string NomePessoa { get; set; }
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
                   // command.CommandText = String.Format("INSERT INTO Avaliacao (SoftwareId,DataAvaliacao) VALUES ({0},'{1}')", this.SubCaracteristicaId.Id, this.TextoQuestao);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
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
