using Core;

namespace UI
{
    
//TODO: Inte krascha när man skickar in data igen.
//TODO: att användaren själv kan bestäma x- och y-axeln
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
            Application.Run(new IntroScreen());
        }
    }
}