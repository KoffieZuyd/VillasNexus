using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    public class Menu
    {

        protected void ToonTitel(string titel)
        {
            Console.Clear();
            Console.WriteLine(titel);
            Console.WriteLine();
            
           
        }

        public virtual void ToonMenu()
        {

            Console.WriteLine("Menu");

        }

       
        }
    }


