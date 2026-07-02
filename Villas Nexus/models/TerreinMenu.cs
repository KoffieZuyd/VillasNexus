using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Villas_Nexus.DataAcces;

namespace Villas_Nexus.Models
{
    public class TerreinMenu : Menu
    {
        private List<Zone> zones;
        private List<Podium> podia;
        private List<Faciliteit> faciliteiten;

        private TerreinRepository terreinRepository;
        private PodiumRepository podiumRepository;
        private FaciliteitRepository faciliteitRepository;

        public TerreinMenu()
        {
            terreinRepository = new TerreinRepository();
            podiumRepository = new PodiumRepository();
            faciliteitRepository = new FaciliteitRepository();

            zones = terreinRepository.HaalAlleZonesOp();
            podia = podiumRepository.HaalAllePodiaOp();
            faciliteiten = faciliteitRepository.HaalAlleFaciliteitenOp();
        }

        public override void ToonMenu()
        {
            bool doorgaan = true;

            while (doorgaan)
            {
                ToonTitel("TERREIN BEHEREN");

                Console.WriteLine("Welke zone wil je beheren?");

                for (int i = 0; i < zones.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + zones[i].Naam);
                   
                }

                

                Console.Write("\nMaak een keuze: ");
               

                int gekozenNummer = int.Parse(Console.ReadLine());

                

                Zone gekozenZone = zones[gekozenNummer - 1];

                ToonTitel(gekozenZone.Naam.ToUpper());

                Console.WriteLine("Kies een podium:");

                for (int i = 0; i < podia.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + podia[i].PodiumNaam);
                }

                Console.Write("\nMaak een keuze: ");
                int podiumKeuze = int.Parse(Console.ReadLine());
                Podium gekozenPodium = podia[podiumKeuze - 1];

                Console.WriteLine("\nKies een faciliteit:");

                for (int i = 0; i < faciliteiten.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + faciliteiten[i].Naam);
                }

                Console.Write("\nMaak een keuze: ");
                int faciliteitKeuze = int.Parse(Console.ReadLine());
                Faciliteit gekozenFaciliteit = faciliteiten[faciliteitKeuze - 1];

                terreinRepository.UpdateZone(
                    gekozenZone.ZoneId,
                    gekozenPodium.PodiumId,
                    gekozenFaciliteit.FaciliteitId
                );

                Console.WriteLine("\nZone is aangepast:");
                Console.WriteLine("Zone: " + gekozenZone.Naam);
                Console.WriteLine("Podium: " + gekozenPodium.PodiumNaam);
                Console.WriteLine("Faciliteit: " + gekozenFaciliteit.Naam);

                Console.WriteLine("\nDruk op Enter om verder te gaan...");
                Console.ReadLine();
            }
        }

    }

}
