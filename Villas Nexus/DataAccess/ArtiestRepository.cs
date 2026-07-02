using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Villas_Nexus.Models;

namespace Villas_Nexus.DataAcces
{
    public class ArtiestRepository
    {
        public List<Artiest> HaalAlleArtiestenOp()
        {
            List<Artiest> artiesten = new List<Artiest>();

            try
            {
                DBConnector.MaakVerbinding();

                string query = "SELECT * FROM Artiest";

                using (SqlCommand command = new SqlCommand(query, DBConnector.connectionString))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Artiest artiest = new Artiest(
                            Convert.ToInt32(reader["Id"]),
                            reader["Naam"].ToString(),
                            reader["Beschrijving"].ToString(),
                            new List<Genre>()
                        );

                        artiesten.Add(artiest);
                    }
                }
            }
            finally
            {
                DBConnector.SluitVerbinding();
            }

            return artiesten;
        }
    }
}