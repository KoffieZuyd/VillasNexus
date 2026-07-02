using System;
using System.Collections.Generic;

namespace Villas_Nexus.Models
{
    public class Zone
    {
        public string Naam { get; set; }
        public List<string> Onderdelen { get; set; }

        public Zone(string naam, List<string> onderdelen)
        {
            Naam = naam;
            Onderdelen = onderdelen;
        }

        public void ToonZone()
        {
            Console.Clear();

            Console.WriteLine(Naam.ToUpper());
            Console.WriteLine();

            Console.WriteLine("+-----------------------------------------------+");
            Console.WriteLine("|                                               |");

            foreach (string onderdeel in Onderdelen)
            {
                Console.WriteLine($"|   {onderdeel.PadRight(43)} |");
            }

            Console.WriteLine("|                                               |");
            Console.WriteLine("+-----------------------------------------------+");

            Console.WriteLine("\nDruk op een toets om terug te gaan.");
            Console.ReadKey();
        }
    }
}
