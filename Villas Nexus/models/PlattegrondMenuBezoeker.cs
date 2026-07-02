using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace Villas_Nexus.Models
{
    public class PlattegrondMenuBezoeker : Menu
    {
        private List<Zone> zones;

        public PlattegrondMenuBezoeker()
        {
            zones = new List<Zone>
            {
                new Zone(
                    "Pop zone",
                    new List<string>
                    {
                        "Foodtruck McDonald's",
                        "Podium 1",
                        "WC Mannen",
                        "WC Vrouwen"
                    }
                ),

                new Zone(
                    "Rock zone",
                    new List<string>
                    {
                        "Rock podium",
                        "Bar",
                        "Burger foodtruck",
                        "EHBO punt"
                    }
                ),

                new Zone(
                    "Hiphop zone",
                    new List<string>
                    {
                        "Hiphop podium",
                        "Snack foodtruck",
                        "Zitplaatsen",
                        "Drankpunt"
                    }
                )
            };
        }

        public override void ToonMenu()
        {
            while (true)
            {
                Console.Clear();

                ToonTitel("PLATTEGROND BEKIJKEN");

                for (int i = 0; i < zones.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {zones[i].Naam}");
                }

                Console.WriteLine("4. Hele plattegrond bekijken");
                Console.WriteLine("5. Terug");

                Console.Write("\nMaak een keuze: ");
                string keuze = Console.ReadLine();

                switch (keuze)
                {
                    case "1":
                        zones[0].ToonZone();
                        break;

                    case "2":
                        zones[1].ToonZone();
                        break;

                    case "3":
                        zones[2].ToonZone();
                        break;

                    case "4":
                        ToonHelePlattegrond();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Ongeldige keuze.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void ToonHelePlattegrond()
        {
            Console.Clear();
            ToonTitel("HELE PLATTEGROND");

            Console.WriteLine("+------------------------------------------------+");
            Console.WriteLine("|                                                |");
            Console.WriteLine("|   +---------------+     +-------------------+  |");
            Console.WriteLine("|   | HipHop zone   |     |                   |  |");
            Console.WriteLine("|   |               |     |     Pop zone      |  |");
            Console.WriteLine("|   +---------------+     |                   |  |");
            Console.WriteLine("|                         +-------------------+  |");
            Console.WriteLine("|                                                |");
            Console.WriteLine("|   +---------------+                            |");
            Console.WriteLine("|   | Rock zone     |                            |");
            Console.WriteLine("|   |               |      +---------+           |");
            Console.WriteLine("|   +---------------+      | Ingang  |           |");
            Console.WriteLine("|                          +---------+           |");
            Console.WriteLine("+------------------------------------------------+");

            Console.WriteLine("\nDruk op een toets om terug te gaan.");
            Console.ReadKey();
        }
    }
}
