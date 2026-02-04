using TechSupport.Controller;


namespace TechSupport.View.Controls
{
    /// <summary>
    /// Represents the control for searching incidents by customer ID.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class SearchIncidentControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// Initializes a new instance of the SearchIncidentControl.
        /// </summary>
        public SearchIncidentControl()
        {
            InitializeComponent();
            incidentController = Program.IncidentController;
        }

        /// <summary>
        /// Removes error message when text is changed in customerIdTextBox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CustomerIdTextBox_TextChanged(object sender, EventArgs e)
        {
            customerIdErrorLabel.Text = string.Empty;
        }

        /// <summary>
        /// Searches for incidents by customer ID.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(customerIdTextBox.Text, out int customerId))
            {
                customerIdErrorLabel.Text = "Customer ID must be a number.";
                customerIdErrorLabel.Visible = true;
                customerIdErrorLabel.BringToFront();
                customerIdErrorLabel.Refresh();
                return;
            }

            var results = incidentController.SearchByCustomerId(customerId);

            searchResultsDataGridView.DataSource = null;
            searchResultsDataGridView.DataSource = results;
        }

        /// <summary>
        /// Clears search box
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            customerIdTextBox.Text = string.Empty;
        }
    }
}
