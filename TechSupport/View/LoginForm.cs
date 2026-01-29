using TechSupport.View;

namespace TechSupport
{
    /// <summary>
    /// Represents the login form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the a LoginForm.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears the error message.
        /// </summary>
        private void ClearErrorMessage()
        {
            errorMessageLabel.Text = string.Empty;
        }

        /// <summary>
        /// Handles the TextChanged event of the passwordTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearErrorMessage();
        }


        /// <summary>
        /// Handles the TextChanged event of the usernameTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearErrorMessage();
        }


        /// <summary>
        /// Handles login button click and validates credentials.
        /// </summary>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (username == "jane" && password == "test1234")
            {
                MainDashboard form = new MainDashboard();
                form.FormClosed += (s, args) => this.Close();
                form.Show();
                this.Hide();
            }
            else
            {
                errorMessageLabel.Text = "Invalid username/password";
            }

        }
    }
}
