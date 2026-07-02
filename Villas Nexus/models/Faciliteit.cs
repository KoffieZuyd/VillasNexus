using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villas_Nexus.Models
{
    public class Faciliteit
    {
        public int FaciliteitId { get; set; }
        public string Naam { get; set; }

        public Faciliteit(int faciliteitId, string naam)
        {
            FaciliteitId = faciliteitId;
            Naam = naam;
        }
    }
}
