using Core;

namespace UI
{
    
//TODO: Inte krascha n�r man skickar in data igen.
//TODO: att anv�ndaren sj�lv kan best�ma x- och y-axeln
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