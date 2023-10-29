using System.Diagnostics;
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
            FileManager.Load();

            // Subscribe the OnApplicationExit method to the ApplicationExit event
            Application.ApplicationExit += OnApplicationExit;
            AppDomain.CurrentDomain.ProcessExit += OnApplicationExit;

            Application.Run(new frm_Login());
        }

        // Handle the application exit event
        private static void OnApplicationExit(object sender, EventArgs e)
        {
            //MessageBox.Show("OnApplicationExit hit ");

            Debug.WriteLine("Application is exiting. Saving data...");

            //Save all the data to .txt files
            //FileManager.Save();

            Debug.WriteLine("Data saved successfully.");

            // Clear all data
            GlobalData.Clear(); 
        }

    }
}