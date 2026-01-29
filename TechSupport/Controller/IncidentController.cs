using TechSupport.DAL;
using TechSupport.Model;



namespace TechSupport.Controller

{
    /// <summary>
    /// Handles business logic related to incidents.
    /// </summary>
    public class IncidentController

    {

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

    }

}

