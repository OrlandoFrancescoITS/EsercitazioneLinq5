using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq5
{
    internal class GestoreCorsi
    {
        public List<Corso> Corsi {  get; set; } = new List<Corso>();

        public void aggiungiCorso(Corso corso) 
        {
            Corsi.Add(corso);
        }
        public void aggiungiLezione(Corso corso, Lezione lezione) 
        {
            corso.Lezioni.Add(lezione);
        }
        public void aggiungiStudente(Corso corso, Studente studente) 
        {
            corso.Studenti.Add(studente);
        }
        public void segnaAssenti(Corso corso) 
        {
            //
        }
        public void elencoCorsi() 
        {
            foreach (Corso c in Corsi) 
            {
                Console.WriteLine($"Nome:{c.Nome} | Edizione:{c.Edizione}");
            }
        }
        public void elencoLezioni(Corso corso) 
        {
            foreach (Corso c in Corsi) 
            {
                foreach (Lezione l in c.Lezioni) 
                {
                    Console.WriteLine($"Docente:{l.Docente} | Durata:{l.Durata} | Descrizione:{l.Descrizione} | Presenti:{l.Presenti}");
                }
            }
        }
        public void elencoIscritti(Corso corso) 
        {
            //
        }
        public void schedaRiassuntivaLezione() 
        {
            //
        }
        public void elencoPresenti(Corso corso) 
        {
            foreach (Lezione l in corso.Lezioni)
            {
                foreach (Studente s in l.Presenti)
                {
                    Console.WriteLine($"Nome:{s.Nome} Cognome:{s.Cognome} Matricola{s.matricola}");
                }
            }
        }
        public void mediaPresentiLezione() 
        {
            //
        }
        public void mediaPresentiLezioni() 
        {
            //
        }
    }
}
