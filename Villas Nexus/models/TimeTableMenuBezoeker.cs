using System;
using System.Collections.Generic;
using Villas_Nexus.DataAcces;

namespace Villas_Nexus.Models
{
    public class TimeTableMenuBezoeker : Menu
    {
        private TimetableRepository timetableRepository;

        public TimeTableMenuBezoeker()
        {
            timetableRepository = new TimetableRepository();
        }

        public override void ToonMenu()
        {
            Console.Clear();
            ToonTitel("PROGRAMMA");

            try
            {
                List<Timetable> optredens = timetableRepository.HaalAlleOptredensOp();

                if (optredens.Count == 0)
                {
                    Console.WriteLine("Er zijn nog geen optredens gevonden.");
                }
                else
                {
                    foreach (Timetable optreden in optredens)
                    {
                        optreden.ToonGegevens();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Er is iets fout gegaan bij het ophalen van het programma.");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nDruk op een toets om terug te gaan.");
            Console.ReadKey();
        }
    }
}
