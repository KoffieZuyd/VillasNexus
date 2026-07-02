using System;
using System.Collections.Generic;
using System.Security.Policy;
using Villas_Nexus.DataAcces;

namespace Villas_Nexus.Models
{
    public class GenreMenu : Menu
    {
        private Genre rock;
        private Genre pop;
        private Genre hiphop;

        private List<Artiest> artiesten;
        private List<Genre> genres;

        private ArtiestRepository artiestRepository;
        private GenreRepository genreRepository;

        public GenreMenu()
        {
            artiestRepository = new ArtiestRepository();
            genreRepository = new GenreRepository();

            artiesten = artiestRepository.HaalAlleArtiestenOp();
            genres = genreRepository.HaalAlleGenresOp();
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

                Console.WriteLine($"{artiesten.Count + 1}. Terug");

                Console.Write("\nMaak een keuze: ");
                int keuze = int.Parse(Console.ReadLine());

                if (keuze == artiesten.Count + 1)
                {
                    Menu organisatorMenu = new OrganisatorMenu();
                    organisatorMenu.ToonMenu();
                    return;
                }

                Artiest gekozenArtiest = artiesten[keuze - 1];

                ToonTitel("");
                Console.WriteLine($"Kies een genre voor {gekozenArtiest.Naam}:");

                for (int i = 0; i < genres.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {genres[i].Naam}");
                }

                Console.Write("\nMaak een keuze: ");
                string genreKeuze = Console.ReadLine();

                Genre gekozenGenre = genres[int.Parse(genreKeuze) - 1];

                if (genreRepository.VoegGenreToeAanArtiest(gekozenArtiest.Id, gekozenGenre.Id))
                {
                    Console.WriteLine("Genre toegevoegd.");
                }
                else
                {
                    Console.WriteLine("Dit genre is al toegevoegd.");
                }

                Console.WriteLine("\nDruk op een toets om terug te gaan");
                Console.ReadKey();
            }
        }




    }
}
