using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villas_Nexus.Models;

namespace Villas_Nexus
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            HoofdMenu menu = new HoofdMenu();
            menu.ToonMenu();
        }
    }
}
