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
                DatabaseConnection.MaakVerbinding();

                string query = "SELECT * FROM Genre";

                using (SqlCommand command = new SqlCommand(query, DatabaseConnection.connectionString))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Genre genre = new Genre(
                            Convert.ToInt32(reader["Id"]),
                            reader["Naam"].ToString()
                        );

                        genres.Add(genre);
                    }
                }
            }
            finally
            {
                DatabaseConnection.SluitVerbinding();
            }

            return genres;
        }

        public bool VoegGenreToeAanArtiest(int artiestId, int genreId)
        {
            try
            {
                DatabaseConnection.MaakVerbinding();

                string query = @"
                IF NOT EXISTS (
                    SELECT 1 
                    FROM ArtiestGenre 
                    WHERE ArtiestId = @ArtiestId 
                    AND GenreId = @GenreId
                )
                BEGIN
                    INSERT INTO ArtiestGenre (ArtiestId, GenreId)
                    VALUES (@ArtiestId, @GenreId)
                END";

                using (SqlCommand command = new SqlCommand(query, DatabaseConnection.connectionString))
                {
                    command.Parameters.AddWithValue("@ArtiestId", artiestId);
                    command.Parameters.AddWithValue("@GenreId", genreId);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            finally
            {
                DatabaseConnection.SluitVerbinding();
            }
        }
    }
}