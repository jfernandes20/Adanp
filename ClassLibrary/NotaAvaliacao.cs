﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class NotaAvaliacao
    {
        public Int32 Id { get; set; }
        public Int32 AvaliacaoId { get; set; }
        public Questao QuestaoId { get; set; }
        public Int32 Nota { get; set; }
    }
}
