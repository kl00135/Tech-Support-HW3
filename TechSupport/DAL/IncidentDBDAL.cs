using Microsoft.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DBAccess
{
    /// <summary>
    /// Provides DB access for incident queries.
    /// </summary>
    public class IncidentDBDAL
    {
        private readonly string _connectionString;

        /// <summary>
        /// Initializes a new instance of the IncidentDBDAL.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        public IncidentDBDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Retrieves all open incidents from the DB. Ensures incidents that are closed are not included.
        /// </summary>
        public List<OpenIncident> GetOpenIncidents()
        {
            List<OpenIncident> incidents = new List<OpenIncident>();
            try
            {
                using SqlConnection connection = new SqlConnection(_connectionString);

                string sql = @"
                SELECT 
                    i.IncidentID,
                    c.Name AS CustomerName,
                    i.ProductCode,
                    t.Name AS TechnicianName,
                    i.DateOpened,
                    i.Title
                FROM Incidents i
                JOIN Customers c ON i.CustomerID = c.CustomerID
                LEFT JOIN Technicians t ON i.TechID = t.TechID
                WHERE i.DateClosed IS NULL
                ORDER BY i.DateOpened";

                using SqlCommand command = new SqlCommand(sql, connection);

                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    incidents.Add(new OpenIncident
                    {
                        IncidentID = reader.GetInt32(0),
                        CustomerName = reader.GetString(1),
                        ProductCode = reader.GetString(2),
                        TechnicianName = reader.IsDBNull(3) ? "Unassigned" : reader.GetString(3),
                        DateOpened = reader.GetDateTime(4),
                        Title = reader.GetString(5)
                    });
                }

            }

            catch (SqlException ex)
            {
                // Log exception (not implemented here)
                throw new ApplicationException("An error occurred while retrieving open incidents.", ex);
            }
            return incidents;
        }
    }
}
