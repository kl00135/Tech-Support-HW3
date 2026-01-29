namespace TechSupport.View
{
    /// <summary>
    /// Represents the main dashboard form of the Tech Support application.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainDashboard : Form
    {
        /// <summary>
        /// Initializes a new instance of the MainDashboard".
        /// </summary>
        public MainDashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the mainTabControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab == loadIncidentTabPage)
            {
                loadIncidentsControl1.LoadIncidents();
            }
        }

        /// <summary>
        /// Logs out the current user.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }

}
