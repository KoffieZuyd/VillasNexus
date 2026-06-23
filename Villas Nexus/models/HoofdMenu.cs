using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    public class HoofdMenu : Menu
    {
            public override void ToonMenu()
            {

                ToonTitel(
                   "██╗   ██╗ █████╗ ██╗     ██╗     ██╗███████╗\r\n" +
                   "██║   ██║██╔══██╗██║     ██║     ██║██╔════╝\r\n" +
                   "██║   ██║███████║██║     ██║     ██║███████╗\r\n" +
                   "╚██╗ ██╔╝██╔══██║██║     ██║     ██║╚════██║\r\n" +
                   " ╚████╔╝ ██║  ██║███████╗███████╗██║███████║\r\n" +
                   "  ╚═══╝  ╚═╝  ╚═╝╚══════╝╚══════╝╚═╝╚══════╝\r\n" +
                   "                                            \r\n" +
                   "███╗   ██╗███████╗██╗  ██╗██╗   ██╗███████╗ \r\n" +
                   "████╗  ██║██╔════╝╚██╗██╔╝██║   ██║██╔════╝ \r\n" +
                   "██╔██╗ ██║█████╗   ╚███╔╝ ██║   ██║███████╗ \r\n" +
                   "██║╚██╗██║██╔══╝   ██╔██╗ ██║   ██║╚════██║ \r\n" +
                   "██║ ╚████║███████╗██╔╝ ██╗╚██████╔╝███████║ \r\n" +
                   "╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚══════╝ \r\n");

                Console.WriteLine("1. Bezoeker");
                Console.WriteLine("2. Vrijwilliger");
                Console.WriteLine("3. Organisator");
                Console.WriteLine("4. Foodtruck eigenaar");

                Console.Write("\nMaak een keuze: ");
                string keuze = Console.ReadLine();

                switch (keuze)
                {
                    case "1":
                        Console.WriteLine("Bezoeker geselecteerd.");
                        break;

                    case "2":
                        Console.WriteLine("Vrijwilliger geselecteerd.");
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
