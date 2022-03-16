using Core;

namespace UI
{
    //TODO: ändra jsonfilen att antal fordon på samma parkeringsplats inte ska finnas, den kör på storlek
    //TODO: trevligare UI, in och titta även i switchmenuvalues

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ParkingGarageLogic logic = new ParkingGarageLogic();
            logic.CreateTheDB();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new IntroScreen());
        }
    }
}