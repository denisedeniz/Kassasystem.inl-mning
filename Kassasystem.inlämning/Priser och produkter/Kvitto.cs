using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem.inlämning.Priser_och_produkter
{
    public class Kvitto
    {
        public static void Skapakvitto(List<Varukorg> korg)
        {
            string namnpåkvittot = $"RECEIPT_{DateTime.Now:yyyyMMdd}.txt";
            StringBuilder onkvittot = new StringBuilder();
            onkvittot.AppendLine("Denise´s MiniLivs");
            onkvittot.AppendLine("===========================");
            onkvittot.AppendLine($"Datum : {DateTime.Now}");
            onkvittot.AppendLine("===========================");
            onkvittot.AppendLine("Produkt | Antal | Enhet | Pris ");
       
            double totalapriset = 0;
            foreach (var i in korg)
            {
                double row = i.Produktlista.pris * i.Varumägnd;
                row = Math.Round(row, 2);
                onkvittot.AppendLine($"{i.Produktlista.Namn} | {i.Varumägnd} | {i.Produktlista.Pristyp} | {row} ");
                totalapriset += row;
            }

            onkvittot.AppendLine("===========================");
            onkvittot.AppendLine($"Totalt: {totalapriset} kr ");
            onkvittot.AppendLine("Tack för ditt köp och välkommen åter");
            onkvittot.AppendLine("============= KVITTO ===========");
            Console.WriteLine(onkvittot.ToString());
            File.AppendAllText(namnpåkvittot, onkvittot.ToString() + Environment.NewLine + Environment.NewLine);
            Console.WriteLine("Försäljningen har avslutats. \n Tryck på en valrfri knapp för att återgå till huvudmenyn");
            Console.ReadKey();
            
        }
    }
}
                      

