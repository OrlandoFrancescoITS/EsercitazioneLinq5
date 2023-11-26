using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq5
{
    internal class Docente : Persona
    {
        public Docente(string nome, string cognome, string titoloDiStudio) : base(nome, cognome)
        {
            this.titoloDiStudio = titoloDiStudio;
        }

        string titoloDiStudio { get; set; }
    }
}
