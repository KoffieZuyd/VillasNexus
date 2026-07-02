using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    public class Zone
    {
        public int ZoneId { get; private set; }
        public string Naam { get; private set; }
        public string PodiumNaam { get; private set; }
        public int AantalToiletten { get; private set; }
        public int AantalFoodtrucks { get; private set; }

        public Zone(int zoneID, string naam)
        {
            ZoneId = zoneID;
            Naam = naam;
        }

        public void WijzigZone(string podiumNaam, int aantalToiletten, int aantalFoodtrucks)
        {
            PodiumNaam = podiumNaam;
            AantalToiletten = aantalToiletten;
            AantalFoodtrucks = aantalFoodtrucks;
        }

    }
}

