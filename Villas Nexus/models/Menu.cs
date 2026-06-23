using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    public class Menu
    {

        public void ToonHoofdMenu()
        {
          
            Console.WriteLine();

            Console.WriteLine("1. Bezoeker");
            Console.WriteLine("2. Vrijwilliger");
            Console.WriteLine("3. Organisator");
            Console.WriteLine("4. Foodtruck eigenaar");
            Console.WriteLine();

            Console.Write("Maak een keuze: ");
            string keuze = Console.ReadLine();

            VerwerkKeuze(keuze);
        }

        private void VerwerkKeuze(string keuze)
        {
            switch (keuze)
            {
                case "1":
                    Console.WriteLine("Bezoeker geselecteerd.");
                    break;

                case "2":
                    Vrijwilliger_Login vrijwilliger = new Vrijwilliger_Login();
                    vrijwilliger.Login();
                    break;

                case "3":
                    Console.WriteLine("Organisator geselecteerd.");
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
