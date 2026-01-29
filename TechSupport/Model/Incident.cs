namespace TechSupport.Model
{
    /// <summary>
    /// Represents a tech support incident.
    /// </summary>
    public class Incident
    {
        /// <summary>
        /// Gets or sets the title of the incident.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the incident's description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the customer ID associated with the incident.
        /// </summary>
        public int CustomerId { get; set; }
    }
}
