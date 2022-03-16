using Core;

namespace UI
{
    //TODO: �ndra jsonfilen att antal fordon p� samma parkeringsplats inte ska finnas, den k�r p� storlek
    //TODO: trevligare UI, in och titta �ven i switchmenuvalues

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