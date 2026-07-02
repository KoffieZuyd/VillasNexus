using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Villas_Nexus.Models;


namespace Villas_Nexus.Models
{
    public class DBConnector
    {
        public static SqlConnection connectionString { get; private set; }

        public static void MaakVerbinding()
        {
            connectionString = new SqlConnection("Server = 20.86.62.20,1433; Database = Vallis_Nexus_DB; Uid = VallisNexus-Main; Pwd = VNMain2026");
            connectionString.Open();
        }

        public static void SluitVerbinding()
        {
            connectionString.Close();
        }
    }
    
}
