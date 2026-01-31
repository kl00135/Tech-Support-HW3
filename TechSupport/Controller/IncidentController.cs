using TechSupport.DAL;
using TechSupport.DBAccess;
using TechSupport.Model;



namespace TechSupport.Controller

{
    /// <summary>
    /// Handles business logic related to incidents.
    /// </summary>
    public class IncidentController
    {
        private readonly IncidentDal _incidentDAL;
        private readonly IncidentDBDAL _incidentDBDAL;

        /// <summary>
        /// Initializes InicdentDal which is in memory, or IncidentDBDAL which connects to the database.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        public IncidentController(string connectionString)
        {
            _incidentDAL = new IncidentDal();
            _incidentDBDAL = new IncidentDBDAL(connectionString);
        }

        /// <summary>
        /// Retrieves all incidents.
        /// </summary>
        public List<Incident> GetAllIncidents()
        {
            return IncidentDal.GetAll();
        }


        /// <summary>
        /// Adds an incident.
        /// </summary>
        public void AddIncident(Incident incident)
        {
            IncidentDal.AddIncident(incident);
        }

        /// <summary>
        /// Searches the by customer identifier.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <returns>List of specified ID</returns>
        public List<Incident> SearchByCustomerId(int customerId)
        {
            return IncidentDal.GetAll()
                .Where(i => i.CustomerId == customerId)
                .ToList();
        }


        /// <summary>
        /// Gets the open incidents from DB.
        /// </summary>
        /// <returns></returns>
        public List<OpenIncident> GetOpenIncidents()
        {
            try
            {
                return _incidentDBDAL.GetOpenIncidents();
            }
            catch (Exception)
            {
                throw new ApplicationException("An error occurred while retrieving open incidents.");
            }

        }

    }

}

