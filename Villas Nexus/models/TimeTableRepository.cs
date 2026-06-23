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
            private DatabaseConnection databaseConnection;

            public TimetableRepository()
            {
                databaseConnection = new DatabaseConnection();
            }

            public List<Timetable> HaalAlleOptredensOp()
            {
                

            }

            public void VoegOptredenToe(Timetable timetable)
            {
       
            }

            public bool VerwijderOptreden(int id)
            {

            }
        }
    
}
