using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Villas_Nexus.Models;


namespace Villas_Nexus.Models
{
    public class DatabaseConnection
    {
        private string connectionString = "server=localhost;user=root;password=;database=vallis_nexus;";

        public DatabaseConnection MaakVerbinding()
        {
            return new DatabaseConnection();
        }
    }
    
}
