using System.Xml;

namespace Lab_1_OOSU
{
    public class Lärare : Användare
    {
        public int TelefonNummer {  get; set; }
        public string Signatur {  get; set; }
        public Lärare(string namn, string efternamn, string epost, int telefonNummer, string signatur) : base(namn, efternamn, epost)
        {
            TelefonNummer = telefonNummer;
            Signatur = signatur;
        }


    }
}
