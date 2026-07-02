using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Villas_Nexus.Models;

namespace Villas_Nexus.DataAcces
{
    public class GenreRepository
    {
        public List<Genre> HaalAlleGenresOp()
        {
            List<Genre> genres = new List<Genre>();

            try
            {
                DBConnector.MaakVerbinding();

                string query = "SELECT * FROM Genre";

                using (SqlCommand command = new SqlCommand(query, DBConnector.connectionString))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Genre genre = new Genre(
                            Convert.ToInt32(reader["genreid"]),
                            reader["Naam"].ToString().Trim()
                        );

                        genres.Add(genre);
                    }
                }
            }
            finally
            {
                DBConnector.SluitVerbinding();
            }

            return genres;
        }

        public bool VoegGenreToeAanArtiest(int artiestId, int genreId)
        {
            try
            {
                DBConnector.MaakVerbinding();

                string query = @"
                IF NOT EXISTS (
                    SELECT 1 
                    FROM ARTIESTGENRE 
                    WHERE ArtiestId = @ArtiestId 
                    AND GenreId = @GenreId
                )
                BEGIN
                    INSERT INTO ARTIESTGENRE (ArtiestId, GenreId)
                    VALUES (@ArtiestId, @GenreId)
                END";

                using (SqlCommand command = new SqlCommand(query, DBConnector.connectionString))
                {
                    command.Parameters.AddWithValue("@ArtiestId", artiestId);
                    command.Parameters.AddWithValue("@GenreId", genreId);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            finally
            {
                DBConnector.SluitVerbinding();
            }
        }
    }
}