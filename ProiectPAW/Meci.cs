using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
   public class Meci
    {
       public int id;
        public DateTime oraMeci;
        public string tipMeci;
        public string denumire;
        public Echipa echipa1;
        public int scorEchipa1;
        public Echipa echipa2;
        public int scorEchipa2;

        public Meci(int i, DateTime ora, string tM, string nume, Echipa e1,Echipa e2,int se1,int se2)
        {
            Random rand = new Random();
            id = i;
            oraMeci = ora;
            tipMeci = tM;
            denumire = nume;
            echipa1 = e1;
            echipa2 = e2;
            scorEchipa1 = rand.Next(0,5);
            scorEchipa2 = rand.Next(0, 5);
        }
        public override string ToString()
        {
            return "Meciul cu id" + id + " este intre " + echipa1.nume + " si " + echipa2.nume + " la ora " + oraMeci;
        }

    }

}
