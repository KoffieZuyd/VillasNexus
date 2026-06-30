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

            bool isLoggedIn = false;
            while (!isLoggedIn)
            {
                Console.Clear();
                Console.WriteLine("Vrijwilliger Login\n");

                Console.Write("Voer logincode in: ");
                string invoer = Console.ReadLine();

                if (invoer == code)
                {
                    VrijwilligerMenu menu = new VrijwilligerMenu();
                    menu.ToonMenu();
                    isLoggedIn = true;
                }
                else
                {
                    Console.WriteLine("Ongeldige code, druk spatie om opnieuw te proberen.");
                    Console.ReadKey();
                }
            }
        }
    }
}
