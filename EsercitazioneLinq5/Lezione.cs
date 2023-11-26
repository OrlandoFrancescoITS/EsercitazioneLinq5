using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq5
{
    internal class Lezione
    {
        public string Descrizione { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan OrarioInizio { get; set; }
        public int Durata { get; set; }
        public Docente Docente { get; set; }
        public Aula Aula { get; set; }
        public List<Studente> Presenti { get; set; } = new List<Studente>();

        public Lezione(string descrizione, DateTime data, TimeSpan orarioInizio, int durata, Docente docente, Aula aula, List<Studente> presenti)
        {
            Descrizione = descrizione;
            Data = data;
            OrarioInizio = orarioInizio;
            Durata = durata;
            Docente = docente;
            Aula = aula;
            Presenti = presenti;
        }
    }
}
