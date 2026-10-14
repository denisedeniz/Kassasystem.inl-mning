using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.IO;
using System.Text;

namespace Kassasystem.inlämning.Priser_och_produkter
{
    public class Case
    {
        public static void MenyCASE(List<Varukorg> varukorgs, List<Produkt> produkters)
        {
            Console.WriteLine("Välkommen, ett nytt köp har startats");
            varukorgs.Clear();
            while (true)
            {
                foreach (var D in produkters)
                {

                    Console.WriteLine($"{D.ID} | {D.Namn} | {D.pris} ");
                }
                    Console.WriteLine("Vilken produkt vill du ha och hur många av varje produkt?");
                    Console.WriteLine("Skriv PAY för att avlsuta");

                    var input = Console.ReadLine();
                    if (input.ToUpper() == "PAY")
                    {
                        Console.WriteLine("Betalningen sker:");
                        if (varukorgs.Count == 0)
                        {
                            Console.WriteLine("Din varukorg är tom idiot, lägg in varorna :<!!!");
                            Console.WriteLine("Tryck på en knapp för att återvända till menyn");
                            break;
                        }
                    Kvitto.Skapakvitto(varukorgs);
                        break;
                    }

                    string[] Prader = input.Split(" ");
                    if (Prader.Length != 2)
                    {
                        Console.WriteLine("Fel inmatning, försök igen");
                        continue;
                    }
                    if (!int.TryParse(Prader[0], out int IDprodukt) ||
                    !int.TryParse(Prader[1], out int Vmängd) || Vmängd < 0)
                    {
                        Console.WriteLine("Fel val, försök igen");
                        continue;
                    }
                    bool körs = false;
                    foreach (var d in produkters)
                    {
                        if (d.ID == IDprodukt)
                        {
                            varukorgs.Add(new Varukorg(d, Vmängd));
                            Console.WriteLine($"{d.Namn} x {Vmängd} är tillagda i varukorgen");

                        double total = 0;
                        foreach (var vara in varukorgs)
                        {
                            Console.WriteLine($"{vara.Produktlista.Namn} x {vara.Varumägnd}");
                            total += vara.Produktlista.pris * vara.Varumägnd;
                        }
                        Console.WriteLine($"Totalt blir det: {total} kr");

                        körs = true;
                            break;

                        }


                    }

                    if (!körs)
                    {
                        Console.WriteLine("Produkten du har valt är inte tillgänlig");
                    }

                }

            }
        }

    }

