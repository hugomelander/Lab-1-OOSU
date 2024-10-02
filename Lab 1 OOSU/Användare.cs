using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_OOSU
{


    public class Användare
    {
        protected string Namn { get; set; }
        protected string Efternamn { get; set; }
        protected string Epost { get; set; }


        public Användare(string namn, string efternamn, string epost)
        {
            Namn = namn;
            Efternamn = efternamn;
            Epost = epost;
        }
        public void SkapaSchema()
            {
                
            }
        public void VisaSchema()
        {

        }
            
        }
}