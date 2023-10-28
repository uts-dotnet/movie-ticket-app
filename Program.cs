using MovieTicketApp.src.Managers;

namespace MovieTicketApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Load data from files when the application starts
            GlobalData.LoadData();

            Application.Run(new frm_Login());
        }
    }
}