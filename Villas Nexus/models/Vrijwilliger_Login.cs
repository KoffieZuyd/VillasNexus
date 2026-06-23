using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    public class VrijwilligerLogin
    {
        public void Login()
        {
            string code = "VN2026";

            while (true)
            {
                Console.Clear();

                Console.Write("Voer logincode in: ");
                string invoer = Console.ReadLine();

                if (invoer == code)
                {
                    ToonMenu();
                    break;
                }
                else
                {
                    Console.WriteLine("Ongeldige code, probeer opnieuw.");
                    Console.ReadKey();
                }
            }
        }

        private void ToonMenu()
        {
            Console.Clear();

            Console.Write("\nMaak een keuze: ");
            string keuze = Console.ReadLine();

            switch (keuze)
            {
                case "1":
                    Console.WriteLine("1. Werkzaamheden");
                    break;

                case "2":
                    Console.WriteLine("2. Afgeronde werkzaamheden");
                    break;

                case "3":
                    Console.WriteLine("3. Staff info");
                    break;

            }
            Console.WriteLine("=== Vrijwilliger Pagina ===");
        }
    }
}
