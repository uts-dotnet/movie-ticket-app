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

        // Handle the application exit event
        private static void OnApplicationExit(object sender, EventArgs e)
        {
            //Save all the data to .txt files
            GlobalData.SaveData();

            // Clear all data
            GlobalData.Clear(); 
        }
    }
}