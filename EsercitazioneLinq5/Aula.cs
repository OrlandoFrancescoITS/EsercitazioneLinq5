using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq5
{
    internal class Aula
    {
        int capienza { get; set; }
        string nome { get; set; }
        List<string> risorse { get; set;}

        public Aula(int capienza, string nome, List<string> risorse)
        {
            this.capienza = capienza;
            this.nome = nome;
            this.risorse = risorse;
        }
    }
}
