using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq5
{
    internal class Corso
    {
        public string Nome { get; set; }
        public int Edizione { get; set; }
        public List<Lezione> Lezioni { get; set; } = new List<Lezione>();
        public List<Studente> Studenti { get; set; } = new List<Studente>();
    }
}
