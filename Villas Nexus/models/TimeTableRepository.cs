using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Villas_Nexus.Models;

namespace Villas_Nexus.Models
{
        public class TimetableRepository
        {
            private DBConnector DBConnector;

            public TimetableRepository()
            {
                DBConnector = new DBConnector();
            }

            public List<Timetable> HaalAlleOptredensOp()
            {
                
                return new List<Timetable>();
            }

            public void VoegOptredenToe(Timetable timetable)
            {
       
            }

            public bool VerwijderOptreden(int id)
            {
                return false;
            }
        }
    
}
