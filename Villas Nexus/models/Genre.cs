using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string Naam { get; set; }

        public Genre(int genreID, string naam)
        {
            GenreID = genreID;
            Naam = naam;
        }

       

    }
}
