using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Kassasystem.inlämning.SYS
{
    public class InmatningsKoll
    {
        //klass för att hantera inmatningar
        public static int Valmojlighet(int min, int max)

            // valsiffra (1,4);
        {
            while (true)
            {

                if (!int.TryParse(Console.ReadLine(), out int input) || input < min || input > max) 
                {
                    Console.WriteLine("Fel inmatning, vänligen välj ett av alternativen");

                }
                else
                {
                    return input;
                }

            }
        }
    }
}
