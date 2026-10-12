using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Kassasystem.inlämning.SYS;

namespace Kassasystem.inlämning.Priser_och_produkter
{
    public class Meny
    {
        public static void Visameny()
        {
            Console.WriteLine("VÄLKOMEN TILL MENYN \n Välj ett val");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Ny kund");
            Console.WriteLine("2. Admin");
            Console.WriteLine("0. Avsluta");
        }
        public static void Start()
        {
            Visameny();

        }
    }
}



