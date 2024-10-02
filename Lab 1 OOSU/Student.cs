namespace Lab_1_OOSU
{
    public class Student : Användare
    {
        public string Utbildning { get; set; }
        public Student(string namn, string efternamn, string epost, string utbildning): base (namn, efternamn, epost)
        {
            Utbildning = utbildning;
        }
    }

}
