using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Kassasystem.inlämning.Priser_och_produkter
{
    public class Varukorg
    {
        public Produkt Produktlista { get; set; }
        public double Varumägnd { get; set; }
        public string ID { get; set; }
        public string Namn { get; set; }
        public double pris { get; set; }
        public string Pristyp { get; set; }
        public double Rader
        {
            get { return Produktlista.pris * Varumägnd; }
        }
        
        public Varukorg(Produkt produktlista, double varumägnd)
        {
            Produktlista = produktlista;
            Varumägnd = varumägnd;
        }

        public void Varor()
        {
            string varor = $"Produktlista {Produktlista} | Varumägnd {Varumägnd}";
            Console.WriteLine(varor);
        }
    }
}
