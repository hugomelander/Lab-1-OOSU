namespace Lab_1_OOSU
{
        public class Administratör : Användare
        {
            public int TelefonNummer { get; set; }
            public string Signatur { get; set; }
            public Administratör(string namn, string efternamn, string epost, int telefonNummer, string signatur) : base(namn, efternamn, epost)
            {
                TelefonNummer = telefonNummer;
                Signatur = signatur;
            }


        }
}
