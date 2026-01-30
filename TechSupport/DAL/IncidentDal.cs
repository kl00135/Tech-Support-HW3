using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Simulates data persistence for incidents.
    /// </summary>
    public class IncidentDal
    {
        private static readonly List<Incident> incidents = new();

        /// <summary>
        /// Returns all of the incidents.
        /// </summary>
        public static List<Incident> GetAll()
        {
            return incidents;
        }

        /// <summary>
        /// Adds a new incident to the data store.
        /// </summary>
        public static void AddIncident(Incident incident)
        {
            incidents.Add(incident);
        }
    }
}
