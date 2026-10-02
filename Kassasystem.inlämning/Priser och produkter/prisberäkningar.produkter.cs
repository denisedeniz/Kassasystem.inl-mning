using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem.inlämning.Priser_och_produkter
{
    public class prisberäkningar
    {

       public  string ID = "123456789";
        public string namn = "Bananer";
      
        public static decimal PrisMoms(decimal pris)
        {

            return pris * 1.25m;

        }

        public static decimal BPR(decimal pris, decimal rabattProcent)
        {
            if (rabattProcent < 0 || rabattProcent > 100)
            {
                throw new ArgumentException(" Fel procent mängd angiven ");

            }
            decimal efterrabatt = pris * (1 - rabattProcent / 100m);
            return efterrabatt;

        }
        public static decimal BeraknaMomsbelopp(decimal prisExklusiveMoms)
        {
            return prisExklusiveMoms * 0.25m;
        }

    }
}


