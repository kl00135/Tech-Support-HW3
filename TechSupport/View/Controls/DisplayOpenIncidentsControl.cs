using TechSupport.Controller;

namespace TechSupport.View.Controls
{
    /// <summary>
    /// Displays all open incidents in a DB.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class DisplayOpenIncidentsControl : UserControl
    {
        private readonly IncidentController _controller;

        /// <summary>
        /// Initializes a new instance of the DisplayOpenIncidentsControl class.
        /// </summary>
        public DisplayOpenIncidentsControl()
        {
            InitializeComponent();
            _controller = Program.IncidentController;
        }

        /// <summary>
        /// Loads the open incidents.
        /// </summary>
        public void LoadOpenIncidents()
        {
            try
            {
                openIncidentsListView.Items.Clear();
                var incidents = _controller.GetOpenIncidents();



                foreach (var incident in incidents)
                {
                    ListViewItem item = new ListViewItem(incident.IncidentID.ToString());
                    item.SubItems.Add(incident.Title);
                    item.SubItems.Add(incident.CustomerName);
                    item.SubItems.Add(incident.ProductCode);
                    item.SubItems.Add(incident.TechnicianName);
                    item.SubItems.Add(incident.DateOpened.ToShortDateString());
                    openIncidentsListView.Items.Add(item);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error loading open incidents: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
