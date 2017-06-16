using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class NotaAvaliacao
    {
        public Int32 Id { get; set; }
        public Avaliacao AvaliacaoId { get; set; }
        public Questao QuestaoId { get; set; }
        public int Nota { get; set; }
    }
}
