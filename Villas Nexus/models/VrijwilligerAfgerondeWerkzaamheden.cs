using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    internal class VrijwilligerAfgerondeWerkzaamheden
    {
        public void ToonAfgerond()
        {
            Console.Clear();
            Console.WriteLine("Afgeronde werkzaamheden\n");

            if (VrijwilligerWerkzaamheden.AfgerondeWerkzaamheden.Count == 0)
            {
                Console.WriteLine("Er zijn nog geen afgeronde werkzaamheden.");
            }
            else
            {
                for (int i = 0; i < VrijwilligerWerkzaamheden.AfgerondeWerkzaamheden.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {VrijwilligerWerkzaamheden.AfgerondeWerkzaamheden[i]}");
                }
            }

            Console.WriteLine("\nDruk op een toets...");
            Console.ReadKey();
        }
    }
}
