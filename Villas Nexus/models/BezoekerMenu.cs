using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villas_Nexus.DataAcces;
using Villas_Nexus.Models;

namespace Villas_Nexus.Models
{
    public class BezoekerMenu : Menu
    {
        public override void ToonMenu()
        {
            while (true)
            {
                Console.Clear();

                ToonTitel("BEZOEKER MENU");

                Console.WriteLine("1. Timetable bekijken");
                Console.WriteLine("2. Plattegrond bekijken");
                Console.WriteLine("3. Festival info");
                Console.WriteLine("4. Terug naar hoofdmenu");

                Console.Write("\nMaak een keuze: ");
                string keuze = Console.ReadLine();

                switch (keuze)
                {
                    case "1":
                        TimeTableMenuBezoeker timeTableMenuBezoeker = new TimeTableMenuBezoeker();
                        timeTableMenuBezoeker.ToonMenu();
                        break;

                    case "2":
                        PlattegrondMenuBezoeker plattegrondMenuBezoeker = new PlattegrondMenuBezoeker();
                        plattegrondMenuBezoeker.ToonMenu();
                        break;

                    case "3":
                        //ToonFestivalInfo();
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Ongeldige keuze.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}