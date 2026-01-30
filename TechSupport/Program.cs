using TechSupport.Controller;

namespace TechSupport.View
{

    internal static class Program
    {
        public static IncidentController IncidentController { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IncidentController = new IncidentController(AppConfig.ConnectionString);
            Application.Run(new LoginForm());
    }
    }
}