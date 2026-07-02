using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    internal class VrijwilligerMenu
    {
        public void ToonMenu(string naam)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine($"Welkom {naam}\n");

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
                        isRunning = false;
                        break;

                    case "2":
                        VrijwilligerAfgerondeWerkzaamheden afgerond =
                            new VrijwilligerAfgerondeWerkzaamheden();
                        afgerond.ToonAfgerond();
                        isRunning = false;
                        break;

                    case "3":
                        Console.WriteLine("Hier komt de staff info.");
                        Console.ReadKey();
                        isRunning = false;
                        break;

                    case "4":
                        HoofdMenu hoofdMenu = new HoofdMenu();
                        hoofdMenu.ToonMenu();
                        return;
                }
            }
        }
    }
}