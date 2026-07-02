using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    internal class VrijwilligerMenu
    {
        public void ToonMenu()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Vrijwilliger\n");

                Console.WriteLine("1. Openstaande werkzaamheden");
                Console.WriteLine("2. Afgeronde werkzaamheden");
                Console.WriteLine("3. Staff info");
                Console.WriteLine("4. Terug");

                Console.Write("\nMaak een keuze: ");
                string keuze = Console.ReadLine();

                switch (keuze)
                {
                    case "1":
                        VrijwilligerOpenstaandeWerkzaamheden open =
                            new VrijwilligerOpenstaandeWerkzaamheden();
                        open.Werkzaamheden();
                        break;

                    case "2":
                        VrijwilligerAfgerondeWerkzaamheden afgerond =
                            new VrijwilligerAfgerondeWerkzaamheden();
                        afgerond.ToonAfgerond();
                        break;

                    case "3":
                        Console.WriteLine("Hier komt de staff info.");
                        break;

                    case "4":
                        HoofdMenu hoofdMenu = new HoofdMenu();
                        hoofdMenu.ToonMenu();
                        break;
                }
            }
        }
    }
}
