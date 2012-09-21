using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle_de_Filmes
{
    class Filme
    {
        public string Nome;
        public string Data;
        public string Local;

        public Filme(string Nome, string Data, string Local)
        {
            this.Nome = Nome;
            this.Data = Data;
            this.Local = Local;
        }
    }
}
