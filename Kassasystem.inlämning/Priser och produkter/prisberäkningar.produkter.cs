using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem.inlämning.Priser_och_produkter
{
    public class prisberäkningar
    {
        public static double PrisMoms(double pris)
        {

            return pris * 1.25;

        }

        public static double BPR(double pris, double rabattProcent)
        {
            if (rabattProcent < 0 || rabattProcent > 100)
            {
                throw new ArgumentException(" Fel procent mängd angiven ");

            }
            double efterrabatt = pris * (1 - rabattProcent / 100);
            return efterrabatt;

        }
        public static double BeraknaMomsbelopp(double prisExklusiveMoms)
        {
            return prisExklusiveMoms * 0.25;
        }

    }
}


