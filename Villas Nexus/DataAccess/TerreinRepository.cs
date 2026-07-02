using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Villas_Nexus.Models;

namespace Villas_Nexus.DataAcces
{
    public class TerreinRepository
    {
        public List<Zone> HaalAlleZonesOp()
        {
            List<Zone> zones = new List<Zone>();

            DBConnector.MaakVerbinding();

            string query = @"
                SELECT terreinid, terreinnaam
                FROM TERREIN";

            using (SqlCommand command = new SqlCommand(query, DBConnector.connectionString))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    zones.Add(new Zone(
                        Convert.ToInt32(reader["terreinid"]),
                        reader["terreinnaam"].ToString().Trim()
                    ));
                }
            }

            DBConnector.SluitVerbinding();

            return zones;


        }

        public void UpdateZone(int terreinId, int podiumId, int faciliteitId)
        {
            DBConnector.MaakVerbinding();

            string query = @"
                UPDATE TERREIN
                SET podium = @podium,
                    faciliteit = @faciliteit
                WHERE terreinid = @terreinid";

            using (SqlCommand command = new SqlCommand(query, DBConnector.connectionString))
            {
                command.Parameters.AddWithValue("@podium", podiumId);
                command.Parameters.AddWithValue("@faciliteit", faciliteitId);
                command.Parameters.AddWithValue("@terreinid", terreinId);

                command.ExecuteNonQuery();
            }

            DBConnector.SluitVerbinding();
        }

    }
}