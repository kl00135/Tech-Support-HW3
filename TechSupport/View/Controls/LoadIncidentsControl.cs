using TechSupport.Controller;


namespace TechSupport.View.Controls
{
    /// <summary>
    /// Represents the control for loading and displaying all incidents.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class loadIncidentsControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// Initializes a new instance of the loadIncidentsControl.
        /// </summary>
        public loadIncidentsControl()
        {
            InitializeComponent();
            incidentController = new IncidentController();
        }

        /// <summary>
        /// Loads the incidents into the form when called.
        /// </summary>
        public void LoadIncidents()
        {
            incidentsDataGridView.DataSource = null;
            incidentsDataGridView.DataSource = incidentController.GetAllIncidents();
        }

    }


}
