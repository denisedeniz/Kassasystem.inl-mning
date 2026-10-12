using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Kassasystem.inlämning
{
    public class Produkt
    {

        public int ID { get; set; }
        public string Namn { get; set; }
        public double pris { get; set; }
        public string Pristyp { get; set; }

        public Produkt(int id, string namn, double Pris, string pristyp)
        {
            ID = id;
            Namn = namn;
            pris = Pris;
            Pristyp = pristyp;
        }
    }
}
      

