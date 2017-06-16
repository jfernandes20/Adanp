using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

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

        }
    }
}
