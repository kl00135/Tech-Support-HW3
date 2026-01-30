using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Represents the main form of the application.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        private readonly IncidentController incidentController = Program.IncidentController;

        /// <summary>
        /// Initializes a new instance of the MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshIncidentGrid();
        }

        /// <summary>
        /// Initializes MainForm with logged-in username.
        /// </summary>
        public MainForm(string username)
        {
            InitializeComponent();
            usernameLabel.Text = $"Welcome, {username}";
        }

        /// <summary>
        /// Logs out the current user and returns to LoginForm.
        /// </summary>
        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();

            this.Hide();
            loginForm.Show();
        }

        /// <summary>
        /// Refreshes the incident DataGridView.
        /// </summary>
        private void RefreshIncidentGrid()
        {
            incidentDataGridView.DataSource = null;
            incidentDataGridView.DataSource = incidentController.GetAllIncidents();
        }

        /// <summary>
        /// Opens the Add Incident window.
        /// </summary>
        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            using var addIncidentForm = new AddIncidentForm();
            if (addIncidentForm.ShowDialog() == DialogResult.OK)
            {
                RefreshIncidentGrid();
            }
        }

        /// <summary>
        /// Opens the Search Incident dialog.
        /// </summary>
        private void SearchIncidentButton_Click(object sender, EventArgs e)
        {
            using var searchForm = new SearchIncidentForm();
            searchForm.ShowDialog();
        }

    }
}
