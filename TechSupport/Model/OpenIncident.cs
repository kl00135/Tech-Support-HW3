/// <summary>
/// Represents an open technical support incident from the DB
/// </summary>
namespace TechSupport.Model
{
    /// <summary>
    /// Represents an open incident.
    /// </summary>
    public class OpenIncident
    {
        /// <summary>
        /// Gets or sets the incident identifier.
        /// </summary>
        /// <value>
        /// The incident identifier.
        /// </value>
        public int IncidentID { get; set; }
        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        /// <value>
        /// The name of the customer.
        /// </value>
        public String CustomerName { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the product code.
        /// </summary>
        /// <value>
        /// The product code.
        /// </value>
        public String ProductCode { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the name of the technician.
        /// </summary>
        /// <value>
        /// The name of the technician.
        /// </value>
        public String TechnicianName { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the date opened.
        /// </summary>
        /// <value>
        /// The date opened.
        /// </value>
        public DateTime DateOpened { get; set; }
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; } = string.Empty;
    }
}
