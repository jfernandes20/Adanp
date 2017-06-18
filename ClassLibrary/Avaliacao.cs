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
                        , this.SoftwareId.Id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), this.NomeAvaliador);
                    command.CommandType = CommandType.Text;
                    int retorno = Convert.ToInt32(command.ExecuteScalar());
                    foreach (NotaAvaliacao na in this.Notas)
                    {
                        command.CommandText = String.Format("INSERT INTO NotaAvaliacao (AvaliacaoId,QuestaoId,Nota) VALUES ({0},{1},'{2}')", retorno, na.QuestaoId.Id, na.Nota);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static bool SoftwareJaPossuiAvaliacao(Software soft)
        {
            try
            {
                bool retorno = false;
                using (SQLiteConnection connection = AppSetting.retornaConexao())
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand();
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT EXISTS(SELECT 1 FROM Avaliacao WHERE SOFTWAREID = {0}); ", soft.Id);
                    command.CommandType = CommandType.Text;
                    retorno = Convert.ToBoolean(command.ExecuteScalar());
                    connection.Close();
                }
                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static List<Avaliacao> ListarSoftwareAvaliacao(string nomesoftware)
        {
            DataSet tabelaRetorno = new DataSet();
            using (SQLiteConnection connection = AppSetting.retornaConexao())
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = string.Format("SELECT Software.Id SoftwareId,Software.NomeSoftware, Software.TecnologiaSoftware,Software.FornecedorSoftware, Software.DataInsercao, "
                    + "A.* FROM Software  LEFT JOIN Avaliacao A ON A.SoftwareId = Software.Id WHERE Software.NomeSoftware LIKE '%{0}%';"
                    + "SELECT * FROM View_Listar_Software_Avaliacao WHERE NomeSoftware LIKE '%{0}%'", nomesoftware);
                command.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(tabelaRetorno);
                connection.Close();
            }
            List<Avaliacao> listaResultado = new List<Avaliacao>();
            foreach (DataRow linha in tabelaRetorno.Tables[0].AsEnumerable())
            {
                Avaliacao Av = new Avaliacao();
                Av.Id = Convert.ToInt32(linha["Id"] == DBNull.Value ? 0 :  linha["Id"]);
                Av.DataAvaliacao = Convert.ToDateTime(linha["DataAvaliacao"] == DBNull.Value ? DateTime.MinValue : linha["DataAvaliacao"]);
                Av.NomeAvaliador = linha["NomeAvaliador"].ToString();
                Av.SoftwareId = new Software()
                {
                    Id = Convert.ToInt32(linha["SoftwareId"]),
                    NomeSoftware = linha["NomeSoftware"].ToString(),
                    TecnologiaSoftware = linha["TecnologiaSoftware"].ToString(),
                    FornecedorSoftware = linha["FornecedorSoftware"].ToString(),
                    DataInsercao = Convert.ToDateTime(linha["DataInsercao"])
                };
                Av.Notas = new List<NotaAvaliacao>();
                foreach (DataRow linhaNota in tabelaRetorno.Tables[1].Select(string.Format("AvaliacaoId = {0}", Av.Id)))
                {
                    NotaAvaliacao na = new NotaAvaliacao();
                    na.Id = Convert.ToInt32(linhaNota["NotaAvaliacaoId"]);
                    na.AvaliacaoId = Convert.ToInt32(linhaNota["AvaliacaoId"]);
                    na.Nota = Convert.ToInt32(linhaNota["Nota"]);

                    na.QuestaoId = new Questao()
                    {
                        Id = Convert.ToInt32(linhaNota["QuestaoId"]),
                        TextoQuestao = linhaNota["TextoQuestao"].ToString(),
                        SubCaracteristicaId = new SubCaracteristica()
                        {
                            Id = Convert.ToInt32(linhaNota["SubCaracteristicaId"]),
                            SubCaracteristicaNome = linhaNota["SubCaracteristicaNome"].ToString(),
                            CaracteristicaId = new Caracteristica()
                            {
                                Id = Convert.ToInt32(linhaNota["CaracteristicaId"]),
                                CaracteristicaNome = linhaNota["CaracteristicaNome"].ToString(),
                                CaracteristicaNumero = Convert.ToInt32(linhaNota["CaracteristicaNumero"])
                            }
                        }
                    };
                    Av.Notas.Add(na);
                }
                listaResultado.Add(Av);
            }
            return listaResultado;
        }
        public static DataTable ObterNotasPorSoftware(List<Software> soft)
        {

            DataTable tabelaRetorno = new DataTable();
            List<Software> retorno = new List<Software>();
            using (SQLiteConnection connection = AppSetting.retornaConexao())
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = string.Format("SELECT * FROM View_Obter_Notas_Por_Caracteristica V WHERE V.SoftwareId IN ({0})", string.Join(",", soft.Select(d => d.Id).ToArray()));
                command.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(tabelaRetorno);
                connection.Close();
            }
            //foreach (var softwareAtual in tabelaRetorno.AsEnumerable().Select(d => d["SoftwareId"]).Distinct())
            //{
            //    Software s = new Software();

            //    foreach (DataRow linha in tabelaRetorno.AsEnumerable().Where(d => d["SoftwareId"].ToString() == softwareAtual.ToString()))
            //    {
            //        s.Id = Convert.ToInt32(linha["SoftwareId"]);
            //        s.NomeSoftware = linha["NomeSoftware"].ToString();
            //        s.NotaFinal += Convert.ToInt32(linha["NotaTotal"]) * Convert.ToInt32((carac.Where(d => d.Id == Convert.ToInt32(linha["CaracteristicaId"])).Select(d => d.Peso)).First());
            //    }
            //    retorno.Add(s);
             
            //}
            return tabelaRetorno;
        }
    }
}
