using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    public class Podium
    {
        public int PodiumId { get; set; }
        public string PodiumNaam { get; set; }

        public Podium(int podiumId, string podiumNaam)
        {
            PodiumId = podiumId;
            PodiumNaam = podiumNaam;
        }
    }
}
