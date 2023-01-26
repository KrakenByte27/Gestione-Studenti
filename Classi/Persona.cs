namespace Gestione_Studenti.Classi
{
    class Persona
    {
        public Persona(string nome1, string cognome1, int gg1, int mm1, int aa1)
        {
            Nome = nome1;
            Cognome = cognome1;
            Gg = gg1;
            Mm = mm1;
            Aa = aa1;
        }

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Gg { get; set; }
        public int Mm { get; set; }
        public int Aa { get; set; }

    }

    class Studente : Persona
    {
        public Studente(string nome1, string cognome1, int gg1, int mm1, int aa1, string corso1, int anno1)
            : base(nome1, cognome1, gg1, mm1, aa1)
        {
            Nome = nome1;
            Cognome = cognome1;
            Gg = gg1;
            Mm = mm1;
            Aa = aa1;
            Corso = corso1;
            Anno = anno1;
        }

        public string Corso { get; set; }
        public int Anno { get; set; }

        public string Controllo()
        {
            string risultato = "";

            int anno = DateTime.Now.Year - Aa;

            if (Mm == DateTime.Now.Month)
            {
                if (Gg > DateTime.Now.Day) anno-=1;
            }
            else if (Mm<DateTime.Now.Day) anno-=1;

            risultato = "Hai un età di " + Convert.ToString(anno) + " anni\n" +
                "Frequenti la " + Convert.ToString(Anno) + "a " + Corso; ;

            return risultato;
        }
    }
}
