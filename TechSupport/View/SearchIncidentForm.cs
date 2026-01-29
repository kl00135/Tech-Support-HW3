using TechSupport.Controller;


namespace TechSupport.View
{
    /// <summary>
    /// Represents the form for searching incidents by customer ID.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SearchIncidentForm : Form
    {
        private readonly IncidentController incidentController = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIncidentForm"/> class.
        /// </summary>
        public SearchIncidentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ensures error message disappears when text is changed in customerIdTextBox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CustomerIdTextBox_TextChanged(object sender, EventArgs e)
        {
            customerIdErrorLabel.Text = string.Empty;
        }

        /// <summary>
        /// Searches incidents by customer ID.
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            customerIdErrorLabel.Text = string.Empty;
            searchResultsDataGridView.DataSource = null;

            if (!int.TryParse(customerIdTextBox.Text, out int customerId))
            {
                customerIdErrorLabel.Text = "Customer ID must be an integer.";
                return;
            }

            var results = incidentController
                .GetAllIncidents()
                .Where(i => i.CustomerId == customerId)
                .ToList();

            searchResultsDataGridView.DataSource = results;
        }

        /// <summary>
        /// Closes the search dialog.
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
