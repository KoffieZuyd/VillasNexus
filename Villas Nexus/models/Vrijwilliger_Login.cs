using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    public class Vrijwilliger_Login
    {
        public void Login()
        {
            Console.Clear();

            string code = "VN2026";

            Console.Write("Voer logincode in: ");
            string invoer = Console.ReadLine();

            if (invoer == code)
            {
                ToonMenu();
            }
            else
            {
                Console.WriteLine("Ongeldige code.");
            }
        }

        private void ToonMenu()
        {
            Console.Clear();

            Console.WriteLine("=== Vrijwilliger Pagina ===");
            Console.WriteLine("1. Werkzaamheden");
            Console.WriteLine("2. Afgeronde werkzaamheden");
            Console.WriteLine("3. Staff info");
        }
    }
}
