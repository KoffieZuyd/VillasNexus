using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Villas_Nexus.Models;

namespace Villas_Nexus.Models
{
    public class TimetableRepository : IDisposable
    {
        private DatabaseConnection databaseConnection;

        public TimetableRepository()
        {
            databaseConnection = new DatabaseConnection();
        }

        public List<Timetable> HaalAlleOptredensOp()
        {
            List<Timetable> timetableLijst = new List<Timetable>();

            using (SqlConnection connection = databaseConnection.MaakVerbinding() as SqlConnection)
            {
                connection.Open();

                string query = "SELECT * FROM timetable ORDER BY Dag, StartTijd";

                using (SqlCommand command = new SqlCommand(query, connection))
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

            return timetableLijst;
        }

        public void VoegOptredenToe(Timetable timetable)
        {
            using (SqlConnection connection = databaseConnection.MaakVerbinding() as SqlConnection)
            {
                connection.Open();

                string query = @"INSERT INTO timetable 
                                (Artiest, Dag, StartTijd, EindTijd, Podium, Plaats)
                                VALUES 
                                (@Artiest, @Dag, @StartTijd, @EindTijd, @Podium, @Plaats)";

                using (SqlCommand command = new SqlCommand(query, connection))
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
        }

        public bool VerwijderOptreden(int id)
        {
            using (SqlConnection connection = databaseConnection.MaakVerbinding() as SqlConnection)
            {
                connection.Open();

                string query = "DELETE FROM timetable WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public void Dispose()
        {
            databaseConnection?.Dispose();
        }
    }
}