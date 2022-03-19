
using Core;
using GhostSheriffsDatabaseAccess;
using PragueParking_2._0;
namespace UI
{
    public partial class IntroScreen : Form
    {



        //readonly ParkingGarageLimitations parkingGarageLimitations = new(); //Intelsense föreslog static
        public IntroScreen()
        {
            InitializeComponent();
        }

    
        private void UpdatePrice_Click(object sender, EventArgs e)
        {
            ChangeRentalPricesScreen rentalPricesScreen = new();

            this.Hide(); //hide previous window
         rentalPricesScreen.Show(this);
        }

        private void LimitationValuesWindow_Load(object sender, EventArgs e)
        {
            ParkingGarageLimitations parkingGarageLimitations = new();

            string presentLimitations = "";
            

         LimitationValuesWindow.Text = parkingGarageLimitations.GetJsonValuesToPresent(presentLimitations);

     
           
        }


        private void ParkingGarageLimitationValuesButton_Click(object sender, EventArgs e)
        {
            ChangeParkingSpacesScreen changeParkingSpacesScreen = new();
            this.Hide();
            changeParkingSpacesScreen.Show(this);
        }

        private void GarageOperationsButton_Click(object sender, EventArgs e)
        {
            OperateTheParkingGarageScreen operateTheParkingGarageScreen = new();
            this.Hide();
            operateTheParkingGarageScreen.Show(this);
        }

        private void ParkedVehiclesButton_Click(object sender, EventArgs e)
        {
            TestShowButtonsVehicleScreen testShowButtonsVehicleScreen = new TestShowButtonsVehicleScreen();
            testShowButtonsVehicleScreen.Show(this);



        }

        private void IntroScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();

      
        }

        private void TestDataButton_Click(object sender, EventArgs e)
        {
            ParkingGarageLogic logic = new ParkingGarageLogic();
            logic.CreateTheDB();
        }
    }
}