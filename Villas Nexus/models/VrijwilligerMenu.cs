using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    internal class VrijwilligerMenu
    {

        public void Werkzaamheden()
        {
            Console.Clear();
            Console.WriteLine("Werkzaamheden\n");
            // Hier komt de code voor het tonen van de werkzaamheden
            Console.WriteLine("Hier komen de werkzaamheden als een lijst met nummers");
        }

        public void ToonMenu()
        {
            Console.Clear();

            Console.WriteLine("Vrijwilliger\n");

            Console.WriteLine("1. Werkzaamheden");
            Console.WriteLine("2. Afgeronde werkzaamheden");
            Console.WriteLine("3. Staff info");

            Console.Write("\nMaak een keuze: ");
            string keuze = Console.ReadLine();

            switch (keuze)
            {
                case "1":
                    Werkzaamheden();
                    break;

                case "2":
                    Console.WriteLine("2. Afgeronde werkzaamheden");
                    break;

                case "3":
                    Console.WriteLine("3. Staff info");
                    break;

            }
        }
    }
}
