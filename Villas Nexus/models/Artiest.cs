using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    public class Artiest
    {
        public int ArtiestID { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }

        private List<Genre> genres;


        public Artiest(int artiestID, string naam, string beschrijving)
        {
            ArtiestID = artiestID;
            Naam = naam;
            Beschrijving = beschrijving;

            genres = new List<Genre>();
        }

        public void VoegGenreToe(Genre genre)
        {
            genres.Add(genre);
        }

        public List<Genre> GeefGenres()
        {
            return genres;
        }

    }

}
