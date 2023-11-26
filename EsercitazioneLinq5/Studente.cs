using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq5
{
    internal class Studente : Persona
    {
        public Studente(string nome, string cognome, string matricola) : base(nome, cognome)
        {
            this.matricola = matricola;
        }

        public string matricola { get; set; }
    }
}
