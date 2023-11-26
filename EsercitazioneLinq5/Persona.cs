using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq5
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Persona(string nome, string cognome)
        {
            this.Nome = nome;
            this.Cognome = cognome;
        }
    }
}
