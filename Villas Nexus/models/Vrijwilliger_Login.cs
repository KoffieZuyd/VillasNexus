using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villas_Nexus.DataAcces;

namespace Villas_Nexus.Models
{
    public class VrijwilligerLogin
    {
        public void Login()
        {
            VrijwilligerRepository repository = new VrijwilligerRepository();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Vrijwilliger Login\n");

                Console.Write("Voer logincode in: ");
                string invoer = Console.ReadLine();

                string ingelogdeNaam = repository.ControleerLogincode(invoer);

                if (ingelogdeNaam != null)
                {
                    VrijwilligerMenu menu = new VrijwilligerMenu();
                    menu.ToonMenu(ingelogdeNaam);
                    break;
                }
                else
                {
                    Console.WriteLine("\nOnjuiste logincode.");
                    Console.ReadKey();
                }
            }
        }
    }
}
