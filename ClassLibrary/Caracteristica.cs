﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;


namespace ClassLibrary
{
    public class Caracteristica
    {
        public int Id { get; set; }
        public int CaracteristicaNumero { get; set; }
        public string CaracteristicaNome { get; set; }
        public List<SubCaracteristica> SubCaracteristicas { get; set; }
        public int Peso { get; set; }
        public static List<Caracteristica> ListarCaracteristicas()
        {
            DataTable tabelaRetorno = new DataTable();
            using (SQLiteConnection connection = AppSetting.retornaConexao())
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = "SELECT C.Id [CaracteristicaId], C.CaracteristicaNumero, C.CaracteristicaNome FROM Caracteristica C ORDER BY C.CaracteristicaNumero;";
                command.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(tabelaRetorno);
                connection.Close();
            }
            List<Caracteristica> lista = new List<Caracteristica>();
            List<SubCaracteristica> sub = new List<SubCaracteristica>();
            sub = SubCaracteristica.ListarSubCaracteristicas();
            foreach (DataRow linha in tabelaRetorno.AsEnumerable())
            {
                Caracteristica caract = new Caracteristica();
                caract.Id = Convert.ToInt32(linha["CaracteristicaId"]);
                caract.CaracteristicaNumero = Convert.ToInt32(linha["CaracteristicaNumero"]);
                caract.CaracteristicaNome = linha["CaracteristicaNome"].ToString();

                caract.SubCaracteristicas = new List<SubCaracteristica>();
                caract.SubCaracteristicas = sub.Where(d => d.CaracteristicaId.Id.Equals(caract.Id)).ToList();

                lista.Add(caract);
            }
            return lista;
        }
    }
}
