﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Domain
{
   public class Contato
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public bool Status { get; set; }

        public class ContatoCollection : List<Contato>
        {

        }

    }
}
