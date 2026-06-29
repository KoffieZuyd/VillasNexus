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

            artiesten.Add(new Artiest(1, "Imagine Dragons", "Rockband"));
            artiesten.Add(new Artiest(2, "Eminem", "Rapper"));
            artiesten.Add(new Artiest(3, "Coldplay", "Popband"));

            rock = new Genre(1, "Rock");
            pop = new Genre(2, "Pop");
            hiphop = new Genre(3, "Hip-Hop");
        }

        public override void ToonMenu()
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

            Console.WriteLine("\nKies een genre:");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Hip-Hop");

            Console.Write("\nMaak een keuze: ");
            string genreKeuze = Console.ReadLine();

            switch (genreKeuze)
            {
                case "1":
                    gekozenArtiest.VoegGenreToe(rock);
                    break;

                case "2":
                    gekozenArtiest.VoegGenreToe(pop);
                    break;

                case "3":
                    gekozenArtiest.VoegGenreToe(hiphop);
                    break;

                default:
                    Console.WriteLine("Ongeldige keuze.");
                    return;
            }

            Console.WriteLine("\nGenres van " + gekozenArtiest.Naam + ":");

            foreach (Genre genre in gekozenArtiest.GeefGenres())
            {
                Console.WriteLine("- " + genre.Naam);
            }

            Console.ReadKey();
        }
    }
}