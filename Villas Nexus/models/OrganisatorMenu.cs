using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    public class OrganisatorMenu : Menu
    {
        public override void ToonMenu()
        {
            //Console.Clear();
            ToonTitel("ORGANISATOR");

            Console.WriteLine("1. Terrein beheren");
            Console.WriteLine("2. Artiesten indelen op genre");
            Console.WriteLine("3. Artiesten beschikbaarheid bijhouden");
            Console.WriteLine("4. Opbouwschema maken");

            Console.Write("\nMaak een keuze: ");
            string keuze = Console.ReadLine();

            switch (keuze)
            {
                case "1":
                    Console.WriteLine("Terrein beheren");
                    break;

                case "2":
                    Console.WriteLine("Artiesten indelen op genre");
                    Menu genreMenu = new GenreMenu();
                    genreMenu.ToonMenu();
                    break;

                case "3":
                    Console.WriteLine("Beschikbaarheid beheren");
                    break;

                case "4":
                    Console.WriteLine("Opbouwschema maken");
                    break;

                default:
                    Console.WriteLine("Ongeldige keuze.");
                    break;
            }
        }
    }
}
