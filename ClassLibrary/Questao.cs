using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace ClassLibrary
{
    public class Questao
    {
        public Int32 Id { get; set; }
        public SubCaracteristica SubCaracteristicaId { get; set; }
        public String TextoQuestao { get; set; }
        public Int32 NumeroQuestao { get; set; }

        public static List<Questao> ListarQuestao(string filtro, int caracteristicaId, int subCaracteristicaId)
        {
            DataTable tabelaRetorno = new DataTable();
            using (SQLiteConnection connection = AppSetting.retornaConexao())
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = string.Format("SELECT * FROM View_Listar_Questoes WHERE TextoQuestao LIKE '%{0}%'  AND ({1} = 0 or SubCaracteristicaId = {1}) AND ({2} = 0 or CaracteristicaId = {2})",filtro,subCaracteristicaId,caracteristicaId);
                command.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(tabelaRetorno);
                connection.Close();
            }
            int numeroQuestao = 0;
            List<Questao> listaResultado = new List<Questao>();
            foreach (DataRow linha in tabelaRetorno.AsEnumerable())
            {
                Questao quest = new Questao();
                quest.Id = Convert.ToInt32(linha["QuestaoId"]);
                quest.TextoQuestao = linha["TextoQuestao"].ToString();
                quest.NumeroQuestao = numeroQuestao++;
                quest.SubCaracteristicaId = new SubCaracteristica()
                {
                    Id = Convert.ToInt32(linha["SubCaracteristicaId"]),
                    SubCaracteristicaNome = linha["SubCaracteristicaNome"].ToString(),
                    CaracteristicaId = new Caracteristica()
                    {
                        Id = Convert.ToInt32(linha["CaracteristicaId"]),
                        CaracteristicaNome = linha["CaracteristicaNome"].ToString(),
                        CaracteristicaNumero = Convert.ToInt32(linha["CaracteristicaNumero"])
                    }
                };
                listaResultado.Add(quest);
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
                        command.CommandText = String.Format("INSERT INTO Questao (SubCaracteristicaId,TextoQuestao) VALUES ({0},'{1}')", this.SubCaracteristicaId.Id, this.TextoQuestao);
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
                        command.CommandText = String.Format("UPDATE Questao SET SubCaracteristicaId = {0}, TextoQuestao = '{1}' where Id = {2}", this.SubCaracteristicaId.Id, this.TextoQuestao,this.Id);
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
            //FALTA VALIDAR SER A QUESTÃO JÁ TEVE AVALIAÇÃO
            try
            {
                using (SQLiteConnection connection = AppSetting.retornaConexao())
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand();
                    command.Connection = connection;
                    command.CommandText = String.Format("DELETE FROM Questao where Id = {0}", this.Id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
