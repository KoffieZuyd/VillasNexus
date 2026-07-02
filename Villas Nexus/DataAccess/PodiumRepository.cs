using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Villas_Nexus.Models;

namespace Villas_Nexus.DataAcces
{
    public class PodiumRepository
    {
        public List<Podium> HaalAllePodiaOp()
        {
            List<Podium> podia = new List<Podium>();

            DBConnector.MaakVerbinding();

            string query = "SELECT podiumid, podiumnaam FROM PODIUM";

            using (SqlCommand command = new SqlCommand(query, DBConnector.connectionString))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    podia.Add(new Podium(
                        Convert.ToInt32(reader["podiumid"]),
                        reader["podiumnaam"].ToString().Trim()
                    ));
                }
            }

            DBConnector.SluitVerbinding();

            return podia;
        }
    }
}