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

            switch (keuze)
            {
                case "1":
                    Console.WriteLine("Bezoeker geselecteerd.");
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
