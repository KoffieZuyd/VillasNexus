using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Villas_Nexus.Models;

namespace Villas_Nexus.DataAcces
{
    public class TimetableRepository
    {
        public List<Timetable> HaalAlleOptredensOp()
        {
            List<Timetable> timetableLijst = new List<Timetable>();

            try
            {
                DBConnector.MaakVerbinding();

                string query = "SELECT * FROM timetable ORDER BY Dag, StartTijd";

                using (SqlCommand command = new SqlCommand(query, DBConnector.connectionString))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Timetable timetable = new Timetable(
                            Convert.ToInt32(reader["Id"]),
                            reader["Artiest"].ToString(),
                            Convert.ToDateTime(reader["Dag"]),
                            (TimeSpan)reader["StartTijd"],
                            (TimeSpan)reader["EindTijd"],
                            reader["Podium"].ToString(),
                            reader["Plaats"].ToString()
                        );

                        timetableLijst.Add(timetable);
                    }
                }
            }
            finally
            {
                DBConnector.SluitVerbinding();
            }

            return timetableLijst;
        }

        public void VoegOptredenToe(Timetable timetable)
        {
            try
            {
                DBConnector.MaakVerbinding();

                string query = @"INSERT INTO timetable 
                                (Artiest, Dag, StartTijd, EindTijd, Podium, Plaats)
                                VALUES 
                                (@Artiest, @Dag, @StartTijd, @EindTijd, @Podium, @Plaats)";

                using (SqlCommand command = new SqlCommand(query, DBConnector.connection String))
                {
                    command.Parameters.AddWithValue("@Artiest", timetable.Artiest);
                    command.Parameters.AddWithValue("@Dag", timetable.Dag);
                    command.Parameters.AddWithValue("@StartTijd", timetable.StartTijd);
                    command.Parameters.AddWithValue("@EindTijd", timetable.EindTijd);
                    command.Parameters.AddWithValue("@Podium", timetable.Podium);
                    command.Parameters.AddWithValue("@Plaats", timetable.Plaats);

                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                DBConnector.SluitVerbinding();
            }
        }

        public bool VerwijderOptreden(int id)
        {
            try
            {
                DBConnector.MaakVerbinding();

                string query = "DELETE FROM timetable WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, DBConnector.connectionString))
                {
                    command.Parameters.AddWithValue("@Id", id);

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



