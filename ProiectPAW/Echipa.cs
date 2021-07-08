using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
   public class Echipa
    {
      public  string nume;
       public string nationalitate;
        public int nrJucatori; 

        public Echipa()
        {
            nume = "";
            nationalitate = "";
            nrJucatori = 0;
        }
        public Echipa(string ne , string n ,int nr)
        {
            nume = ne;
            nationalitate = n;
            nrJucatori = nr; 
        }

        public override string ToString()
        {
            return "Echipa " + nume + " e de nationalitate " + nationalitate + " si are " + nrJucatori + " jucatori.";
        }


    }
}
