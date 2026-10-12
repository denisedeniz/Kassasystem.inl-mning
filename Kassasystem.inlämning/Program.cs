using Kassasystem.inlämning.Priser_och_produkter;
using Kassasystem.inlämning.SYS;
using System;
using System.IO;
using System.Text;
using System.Text.Json;


namespace Kassasystem.inlämning
{
    internal class program
    {
        static void Main(string[] args)
        {
            List<Produkt> produkters = new List<Produkt>();
            List<Varukorg> varukorgs = new List<Varukorg>();

            string fil = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fil.txt");
            Console.WriteLine($"Looking for data file at: {fil}");

            if (!File.Exists(fil))
            {
                Console.WriteLine("Filen kunde inte hittas:");
                Console.ReadKey();
                return;
            }
            try
            {
                foreach (string rad in File.ReadAllLines(fil))
                {
                    string[] Prader = rad.Split(";");
                    produkters.Add(new Produkt(int.Parse(Prader[0]), Prader[1], double.Parse(Prader[2]), Prader[3]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading or parsing the data file: " + ex.Message);
                Console.ReadKey();
                return;
            }
            
            bool körs = true;
            while (true)
            {
                Meny.Start();
                int valSiffra = InmatningsKoll.Valmojlighet(0, 2);

                switch (valSiffra)
                {
                    case 1:
                        Case.MenyCASE(varukorgs, produkters);
                        Console.WriteLine("Välkommen, ett nytt köp har startats");
                        break;

                    case 2:
                        Console.WriteLine("Admin");
                        break;

                    case 0:
                        Console.WriteLine("Programmet avslutas, ha det så bra!");
                        return;


                }
            }
        }

    }
}
