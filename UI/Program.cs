using Core;

namespace UI
{
    
//TODO: Inte krascha n�r man skickar in data igen.
//TODO: Kunna se vad varje parkering inneh�ller, antingen vid klick eller som en hel lista om man misslyckas med f�reg�ende.
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