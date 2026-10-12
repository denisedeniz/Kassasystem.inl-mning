using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem.inlämning.Priser_och_produkter
{
    public class Kvitto
    {
        public static void Skapakvitto(List<Varukorg> korg)
        {
            string namnpåkvittot = $"RECEIPT_{DateTime.Now: yyyyMMdd}.txt";
            StringBuilder onkvittot = new StringBuilder();
            Console.WriteLine("Denise´s MiniLivs");
            onkvittot.AppendLine("===========================");
            onkvittot.AppendLine($"Datum : {DateTime.Now}");
            onkvittot.AppendLine("===========================");
            double totalapriset = 0;
            foreach (var i in korg)
            {
                totalapriset += i.Produktlista.pris * i.Varumägnd;
            }

            Console.WriteLine($"Den totala summan är: {totalapriset} kr");


            foreach (var i in korg)
            {
                double row = i.Produktlista.pris * i.Varumägnd;
                onkvittot.AppendLine($"{i.Produktlista.Namn} | {i.Varumägnd} | {i.Pristyp} |  ");
            }
            onkvittot.AppendLine("===========================");
            onkvittot.AppendLine($"Det totala priset för dina produkter och antalet är {totalapriset}");
            onkvittot.AppendLine("============= KVITTO ===========");
            Console.WriteLine(onkvittot.ToString());
            File.AppendAllText(namnpåkvittot, onkvittot.ToString() + Environment.NewLine + Environment.NewLine);
            Console.WriteLine("Försäljningen har avslutats. \n Tryck på en valrfri knapp för att återgå till huvudmenyn");
            Console.ReadKey();
            
        }
    }
}
                      
