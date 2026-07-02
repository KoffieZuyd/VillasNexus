using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villas_Nexus.Models;

namespace Villas_Nexus.Models
{
    public class HoofdMenu : Menu
    {
        public override void ToonMenu()
        {

            ToonTitel("HOOFD MENU");

            Console.WriteLine("1. Bezoeker");
            Console.WriteLine("2. Vrijwilleger");
            Console.WriteLine("3. Organsiator");
            Console.WriteLine("4. Foodtruck Eigenaar");

            Console.Write("\nMaak een keuze: ");
            string keuze = Console.ReadLine();

            switch (keuze)
            {
                case "1":
                    BezoekerMenu bezoekerMenu = new BezoekerMenu();
                    bezoekerMenu.ToonMenu();
                    break;

                case "2":
                    VrijwilligerLogin vrijwilliger = new VrijwilligerLogin();
                    vrijwilliger.Login();
                    break;

                case "3":
                    Menu organisatorMenu = new OrganisatorMenu();
                    organisatorMenu.ToonMenu();
                    break;

                case "4":
                    Console.WriteLine("Foodtruck eigenaar geselecteerd.");
                    break;

                default:
                    Console.WriteLine("Ongeldige keuze.");
                    break;
            }
        }
    }
}
