using System;

namespace Gestione_Studenti.Classi
{
    class Persona
    {
        public Persona(string nome1, string cognome1, int eta1)
        {
            Nome = nome1;
            Cognome = cognome1;
            Eta = eta1;
        }

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }

    }

    class Studente : Persona
    {
        public Studente(string nome1, string cognome1, int eta1, string corso1, int anno1)
            : base(nome1, cognome1, eta1)
        {
            Nome = nome1;
            Cognome = cognome1;
            Eta = eta1;
            Corso= corso1;
            Anno = anno1;
        }

        public string Corso { get; set; }
        public int Anno { get; set; }

    }
}
    