using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Represents the form for adding a new incident.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddIncidentForm : Form
    {
        private readonly IncidentController incidentController = Program.IncidentController;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddIncidentForm"/> class.
        /// </summary>
        public AddIncidentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears all field error messages.
        /// </summary>
        private void ClearErrors()
        {
            titleErrorLabel.Text = string.Empty;
            descriptionErrorLabel.Text = string.Empty;
            customerIdErrorLabel.Text = string.Empty;
        }

        /// <summary>
        /// Ensures error message is cleared when title text changes.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            titleErrorLabel.Text = string.Empty;
        }

        /// <summary>
        ///Ensures error message is cleared when description text changes.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            descriptionErrorLabel.Text = string.Empty;
        }

        /// <summary>
        /// Ensures error message is cleared when customer ID text changes.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CustomerIdTextBox_TextChanged(object sender, EventArgs e)
        {
            customerIdErrorLabel.Text = string.Empty;
        }

        /// <summary>
        /// Adds a new incident.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            ClearErrors();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                titleErrorLabel.Text = "Title is required.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                descriptionErrorLabel.Text = "Description is required.";
                isValid = false;
            }

            if (!int.TryParse(customerIdTextBox.Text, out int customerId))
            {
                customerIdErrorLabel.Text = "Customer ID must be an integer.";
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            Incident incident = new Incident
            {
                Title = titleTextBox.Text,
                Description = descriptionTextBox.Text,
                CustomerId = customerId
            };

            incidentController.AddIncident(incident);

            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Cancels adding an incident.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Handles the TextChanged event of any change in text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AnyField_TextChanged(object sender, EventArgs e)
        {
            ClearErrors();
        }


    }
}
