using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Villas_Nexus.Models;

namespace Villas_Nexus.DataAcces
{
    public class FaciliteitRepository
    {
        public List<Faciliteit> HaalAlleFaciliteitenOp()
        {
            List<Faciliteit> faciliteiten = new List<Faciliteit>();

            DBConnector.MaakVerbinding();

            string query = "SELECT faciliteitid, naam FROM FACILITEIT";

            using (SqlCommand command = new SqlCommand(query, DBConnector.connectionString))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    faciliteiten.Add(new Faciliteit(
                        Convert.ToInt32(reader["faciliteitid"]),
                        reader["naam"].ToString().Trim()
                    ));
                }
            }

            DBConnector.SluitVerbinding();

            return faciliteiten;
        }
    }
}