using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    internal class VrijwilligerOpenstaandeWerkzaamheden
    {
        public void Werkzaamheden()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Werkzaamheden te doen\n");

                for (int i = 0; i < VrijwilligerWerkzaamheden.OpenstaandeWerkzaamheden.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {VrijwilligerWerkzaamheden.OpenstaandeWerkzaamheden[i]}");
                }

                if (VrijwilligerWerkzaamheden.OpenstaandeWerkzaamheden.Count == 0)
                {
                    Console.WriteLine("Er zijn geen openstaande werkzaamheden.");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("\n0. Exit");
                Console.Write("\nKies een werkzaamheid: ");
                string invoer = Console.ReadLine();

                if (invoer == "0")
                {
                    return;
                }

                if (!int.TryParse(invoer, out int keuze))
                {
                    Console.WriteLine("Ongeldige invoer!");
                    Console.ReadKey();
                    continue;
                }

                if (keuze >= 1 && keuze <= VrijwilligerWerkzaamheden.OpenstaandeWerkzaamheden.Count)
                {
                    TaakAfronden(keuze - 1);
                }
            }
        }

        private void TaakAfronden(int index)
        {
            Console.Clear();

            string taak = VrijwilligerWerkzaamheden.OpenstaandeWerkzaamheden[index];

            Console.WriteLine(taak);
            Console.WriteLine();
            Console.WriteLine("Is deze taak afgerond?");
            Console.WriteLine("1. Ja");
            Console.WriteLine("2. Nee");

            string keuze = Console.ReadLine();

            if (keuze == "1")
            {
                VrijwilligerWerkzaamheden.AfgerondeWerkzaamheden.Add(taak);
                VrijwilligerWerkzaamheden.OpenstaandeWerkzaamheden.RemoveAt(index);

                Console.WriteLine("\nTaak is afgerond!");
            }
            else
            {
                Console.WriteLine("\nTaak blijft openstaan.");
            }

            Console.WriteLine("\nDruk op een toets...");
            Console.ReadKey();
        }

    }
}
