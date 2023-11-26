using EsercitazioneLinq5;

GestoreCorsi gestoreCorsi = new GestoreCorsi();

Docente docente = new Docente("Mario", "Rossi", "università della strada");
Aula aula = new Aula(30, "1A", new List<string> { "Video Proiettore", "PC", "Notebook", "Tablet", "LIM" });

List<Studente> studentiPresenti = new List<Studente>();
Studente franco = new Studente("Franco", "Franchi" , "a1b2c3");
Studente felice = new Studente("Felice", "Natale" , "d4e5f6");

studentiPresenti.Add(franco);
studentiPresenti.Add(felice);

Lezione matematica = new Lezione("Area del quadrato", DateTime.Now, TimeSpan.FromHours(4), 5, docente, aula, studentiPresenti);
Corso corso = new Corso();

gestoreCorsi.aggiungiCorso(corso);

gestoreCorsi.aggiungiLezione(corso, matematica);
gestoreCorsi.aggiungiStudente(corso, franco);
gestoreCorsi.segnaAssenti(corso);
gestoreCorsi.elencoCorsi();
gestoreCorsi.elencoLezioni(corso);
gestoreCorsi.elencoIscritti(corso);
gestoreCorsi.schedaRiassuntivaLezione();
gestoreCorsi.elencoPresenti(corso);
gestoreCorsi.mediaPresentiLezione();
gestoreCorsi.mediaPresentiLezioni();