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
        //public string Beschrijving { get; set; }

        private List<Genre> genres;


        public Artiest(int artiestID, string naam, List<Genre> genres)
        {
            ArtiestID = artiestID;
            Naam = naam;
            //Beschrijving = beschrijving;

            this.genres = genres;
        }

        public bool VoegGenreToe(Genre genre)
        {
            foreach (Genre g in genres)
            {
                if (g.GenreID == genre.GenreID)
                {
                    return false; 
                }
            }

            genres.Add(genre);
            return true; 
        }

        public List<Genre> GeefGenres()
        {
            
            return genres;
        }

        

    }

}
