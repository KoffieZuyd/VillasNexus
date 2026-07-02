using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villas_Nexus.Models;

namespace Villas_Nexus.DataAcces
{
    public class VrijwilligerRepository
    {
        // De return type verandert hier van 'bool' naar 'string'
        public string ControleerLogincode(string logincode)
        {
            try
            {
                DBConnector.MaakVerbinding();

                // We halen nu de naam op in plaats van de count
                string query = "SELECT naam FROM STAFF WHERE logincode = @logincode";

                using (SqlCommand command = new SqlCommand(query, DBConnector.connectionString))
                {
                    command.Parameters.AddWithValue("@logincode", logincode);

                    // ExecuteScalar haalt de waarde van de eerste kolom (naam) op
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Geeft de naam van de vrijwilliger terug
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fout: {ex.Message}");
            }
            finally
            {
                DBConnector.SluitVerbinding();
            }

            return null; // Als de code niet klopt of er een fout is, geven we null terug
        }
    }
}