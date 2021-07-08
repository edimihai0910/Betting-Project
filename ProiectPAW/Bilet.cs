using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Bilet
    {
        public int id;
        public DateTime biletPrintat;
        public double pret;
        public bool status; //(castigator, necastigator)
        public int nrMeciuri;
        public Pariu []pariuri;
        public static int nrBilet = 0;
        public Bilet(int id, DateTime biletP, double p, int nr, Pariu[] pr)
        {
            id = nrBilet;
            biletPrintat = biletP;
            pret = p;
            status = false;
            nrMeciuri = nr;

            pariuri = new Pariu[nr];
            for (int j = 0; j < nr; j++)
                pariuri[j] = pr[j];
            nrBilet++;
        }
        
       public double sansaCastig()
        {
            double sum = 0;
            for (int i = 0; i < nrMeciuri; i++)
                if (pariuri[i].cota != null)
                    sum += pariuri[i].cota;
                else sum += 1;
          
            return pret * sum;
        }
        public double totalCota()
        {
            double tCota=0;
            for (int i = 0; i < nrMeciuri; i++)
                tCota += pariuri[i].cota;
            

            return tCota;
        }

    }
}
