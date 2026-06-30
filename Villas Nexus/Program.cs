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

            // voor database connection test/template
            DatabaseConnection.MaakVerbinding();

            string naam = "";
            string genre = "";

            SqlCommand DBtest = new SqlCommand("SELECT naam, genre FROM dbo.ARTIEST", DatabaseConnection.connectionString);
            var DBtestReader = DBtest.ExecuteReader();
            while (DBtestReader.Read())
            {
                naam = DBtestReader.GetString(0);
                genre = DBtestReader.GetString(1);
                Console.WriteLine($"{naam} {genre}");
            } 
        }   
    }
}
