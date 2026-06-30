using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villas_Nexus.Models;

namespace Villas_Nexus.Models
{
        public class Timetable
        {
            public int Id { get; private set; }
            public string Artiest { get; private set; }
            public DateTime Dag { get; private set; }
            public TimeSpan StartTijd { get; private set; }
            public TimeSpan EindTijd { get; private set; }
            public string Podium { get; private set; }
            public string Plaats { get; private set; }

            public Timetable(int id, string artiest, DateTime dag, TimeSpan startTijd, TimeSpan eindTijd, string podium, string plaats)
            {
                Id = id;
                Artiest = artiest;
                Dag = dag;
                StartTijd = startTijd;
                EindTijd = eindTijd;
                Podium = podium;
                Plaats = plaats;
            }

            public Timetable(string artiest, DateTime dag, TimeSpan startTijd, TimeSpan eindTijd, string podium, string plaats)
            {
                Artiest = artiest;
                Dag = dag;
                StartTijd = startTijd;
                EindTijd = eindTijd;
                Podium = podium;
                Plaats = plaats;
            }

            public void ToonGegevens()
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Artiest: {Artiest}");
                Console.WriteLine($"Dag: {Dag:dd-MM-yyyy}");
                Console.WriteLine($"Tijd: {StartTijd} - {EindTijd}");
                Console.WriteLine($"Podium: {Podium}");
                Console.WriteLine($"Plaats: {Plaats}");
            }
        }
    
}
