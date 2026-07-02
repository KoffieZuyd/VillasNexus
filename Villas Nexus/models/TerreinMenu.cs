using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    public class TerreinMenu : Menu
    {
        private List<Zone> zones { get; set; }

        public TerreinMenu()
        {
            zones = new List<Zone>();

            zones.Add(new Zone(1, "Pop zone"));
            zones.Add(new Zone(2, "Rock zone"));
            zones.Add(new Zone(3, "Hiphop zone"));
        }

        public override void ToonMenu()
        {
            bool doorgaan = true;

            while (doorgaan)
            {
                ToonTitel("TERREIN BEHEREN");

                Console.WriteLine("Welke zone wil je beheren?");

                for (int i = 0; i < zones.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + zones[i].Naam);
                }

                Console.WriteLine($"{zones.Count + 1}. Terug");

                Console.Write("\nMaak een keuze: ");
                string keuze = Console.ReadLine();

                if (keuze == (zones.Count + 1).ToString())
                {
                    Menu organisatorMenu = new OrganisatorMenu();
                    organisatorMenu.ToonMenu();

                }
                else
                {
                    int gekozenNummer = int.Parse(keuze);

                    Zone gekozenZone = zones[gekozenNummer - 1];

                    Console.Clear();
                    ToonTitel(gekozenZone.Naam.ToUpper());

                    Console.Write("Podium naam: ");
                    string podiumNaam = Console.ReadLine();

                    Console.Write("Aantal toiletten: ");
                    int aantalToiletten = int.Parse(Console.ReadLine());

                    Console.Write("Aantal foodtrucks: ");
                    int aantalFoodtrucks = int.Parse(Console.ReadLine());

                    gekozenZone.WijzigZone(podiumNaam, aantalToiletten, aantalFoodtrucks);

                    Console.WriteLine("\nZone is aangepast:");
                    Console.WriteLine("Podium: " + gekozenZone.PodiumNaam);
                    Console.WriteLine("Aantal toiletten: " + gekozenZone.AantalToiletten);
                    Console.WriteLine("Aantal foodtrucks: " + gekozenZone.AantalFoodtrucks);

                   



                    Console.WriteLine("\nDruk op Enter om verder te gaan...");
                    Console.ReadLine();
                }
            }
        }
    }

                
}
