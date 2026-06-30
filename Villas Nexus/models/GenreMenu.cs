using System;
using System.Collections.Generic;

namespace Villas_Nexus.Models
{
    public class GenreMenu : Menu
    {
        private List<Artiest> artiesten;
        private Genre rock;
        private Genre pop;
        private Genre hiphop;

        public GenreMenu()
        {
            artiesten = new List<Artiest>();


            rock = new Genre(1, "Rock");
            pop = new Genre(2, "Pop");
            hiphop = new Genre(3, "HipHop");

            artiesten.Add(new Artiest(1, "Imagine Dragons", "Rockband", new List<Genre> { rock } ));
            artiesten.Add(new Artiest(2, "Eminem", "Rapper", new List<Genre> { hiphop } ));
            artiesten.Add(new Artiest(3, "Coldplay", "Popband", new List<Genre> { pop }));

            
        }

        public override void ToonMenu()
        {

            bool doorgaan = true;

            while (doorgaan)
            {
                ToonTitel("ARTIESTEN INDELEN OP GENRE");

                Console.WriteLine("Kies een artiest:");

                for (int i = 0; i < artiesten.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + artiesten[i].Naam);
                    
                }

                Console.Write("\nMaak een keuze: ");
                int keuze = int.Parse(Console.ReadLine());

               

                Artiest gekozenArtiest = artiesten[keuze - 1];

                ToonTitel("");
                Console.WriteLine($"Kies een genre voor {gekozenArtiest.Naam}({gekozenArtiest.GeefGenreNamen()}):");
                
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Hip-Hop");

                Console.Write("\nMaak een keuze: ");
                string genreKeuze = Console.ReadLine();

                switch (genreKeuze)
                {
                    case "1":
                        

                        if (!gekozenArtiest.VoegGenreToe(rock))
                        {
                            Console.WriteLine("Dit genre is al toegevoegd aan deze artiest.");
                        }
                        break;

                    case "2":
                        

                        if (!gekozenArtiest.VoegGenreToe(pop))
                        {
                            Console.WriteLine("Dit genre is al toegevoegd aan deze artiest.");
                        }
                        break;

                    case "3":
                        

                        if (!gekozenArtiest.VoegGenreToe(hiphop))
                        {
                            Console.WriteLine("Dit genre is al toegevoegd aan deze artiest.");
                        }

                        break;

                    default:
                        Console.WriteLine("Ongeldige keuze.");
                        break;
                }

                Console.WriteLine("\nGenres van " + gekozenArtiest.Naam + ":");

                foreach (Genre genre in gekozenArtiest.GeefGenres())
                {
                    Console.WriteLine("- " + genre.Naam);
                }

                Console.WriteLine("\nDruk op Spatie om terug te gaan");

                Console.ReadKey();

            }

            

            
        }
    }
}