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
        public int IncidentID { get; set; }
        public String CustomerName { get; set; } = string.Empty;
        public String ProductCode { get; set; } = string.Empty;
        public String TechnicianName { get; set; } = string.Empty;
        public DateTime DateOpened { get; set; }
        public string Title { get; set; } = string.Empty;
    }
}
