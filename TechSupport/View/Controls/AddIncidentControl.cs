using TechSupport.Controller;
using TechSupport.Model;


namespace TechSupport.View.Controls
{
    /// <summary>
    /// Represents the control for adding a new incident.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class addIncidentControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// Initializes a new instance of the addIncidentControl.
        /// </summary>
        public addIncidentControl()
        {
            InitializeComponent();
            incidentController = Program.IncidentController;
        }
        /// <summary>
        /// Handles the Load event of the addIncidentControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>

        /// <summary>
        /// Handles the TextChanged event of the titleTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            titleErrorLabel.Text = string.Empty;
        }

        /// <summary>
        /// Handles the TextChanged event of the descriptionTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            descriptionErrorLabel.Text = string.Empty;
        }

        /// <summary>
        /// Handles the TextChanged event of the customerIdTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CustomerIdTextBox_TextChanged(object sender, EventArgs e)
        {
            customerIdErrorLabel.Text = string.Empty;
        }

        /// <summary>
        /// Clears the form.
        /// </summary>
        private void ClearForm()
        {
            titleTextBox.Clear();
            descriptionTextBox.Clear();
            customerIdTextBox.Clear();

            titleErrorLabel.Text = string.Empty;
            descriptionErrorLabel.Text = string.Empty;
            customerIdErrorLabel.Text = string.Empty;
        }


        /// <summary>
        /// Adds an incident to the form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
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
                customerIdErrorLabel.Text = "Customer ID must be a number.";
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            Incident incident = new Incident
            {
                Title = titleTextBox.Text.Trim(),
                Description = descriptionTextBox.Text.Trim(),
                CustomerId = customerId
            };

            incidentController.AddIncident(incident);

            ClearForm();

            MessageBox.Show("Incident added successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Resets the text fields.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
