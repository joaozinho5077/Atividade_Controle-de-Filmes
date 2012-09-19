using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle_de_Filmes
{
    class Filme
    {
        public string Nome;
        public string Genero;
        public string Data;
        public string Local;

        public Filme(string Nome, string Genero, string Data, string Local)
        {
            this.Nome = Nome;
            this.Genero = Genero;
            this.Data = Data;
            this.Local = Local;
        }
    }
}
