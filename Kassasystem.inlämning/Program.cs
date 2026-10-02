using System.Security.Cryptography.X509Certificates;

namespace Kassasystem.inlämning
{
    public class Produkt
    {
        public string ID { get; set; }
        public string Namn { get; set; }
        public double pris { get; set; }
        public string Pristyp { get; set; }

        public Produkt(string id, string namn, double Pris, string pristyp)
        {
            ID = id;
            Namn = namn;
            pris = Pris;
            Pristyp= pristyp;
        }
        public class program
        {
            static void Main(string[] args)
            {
                List<Produkt> produkter = new List<Produkt>();
                {
                    produkter.Add(new Produkt("1", "Bananer", 9.99, "Styck"));
                    produkter.Add(new Produkt("2", "Apelsiner", 14.50, "kg"));
                    produkter.Add(new Produkt("3", "Havremjölk 1 liter 3,0%", 23.50, "Styck"));
                    produkter.Add(new Produkt("4", "Pappardelle", 18.67, "Styck"));
                    produkter.Add(new Produkt("5", "Köttfärs 12% 1 kilo ", 128.80, "Styck"));
                    produkter.Add(new Produkt("6", "Matlagningsgrädde 2,5dl 12%", 15.60, "Styck"));
                    produkter.Add(new Produkt("7", "Potatis 2kg", 24.95, "kg"));
                    produkter.Add(new Produkt("8", "kalaspuffar 450g", 71.44, "Styck"));
                    produkter.Add(new Produkt("9", "Zoegas kaffe skånerost 450g", 79.00, "Styck"));
                    produkter.Add(new Produkt("10", "Olw Smash", 32.60, "Styck"));
                }
            }
        }
    }
}
        


