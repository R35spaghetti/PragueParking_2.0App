
using Core;
using Core.ParkingGarage;
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

   

        private void LimitationValuesWindow_Load(object sender, EventArgs e)
        {
            ParkingGarageLimitations parkingGarageLimitations = new();

            string presentLimitations = "";
            

         LimitationValuesWindow.Text = parkingGarageLimitations.GetJsonValuesToPresent(presentLimitations);

     
           
        }


        private void ParkingGarageLimitationValuesButton_Click(object sender, EventArgs e)
        {
            ChangeParkingLimitationsScreen changeParkingSpacesScreen = new();
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
            TestDataLogic testData = new();
            testData.EnsureCreatedDB(); //Om användaren bara vill ha en tom databas

                ShowParkingLotOverviewScreen ShowButtonsVehicleScreen = new();
                ShowButtonsVehicleScreen.Show(this);
            
        
        


        }

        private void IntroScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();

      
        }

        private void TestDataButton_Click(object sender, EventArgs e)
        {
            
        
          
                TestDataLogic ImplementTestData = new();
                ImplementTestData.CreateTheDB();
                TestDataButton.Text = "DONE!";
                TestDataButton.BackColor = Color.Green;
            }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You only need to press the 'Get test data' button once (while the database is empty), several more clicks is only for you own amusement. \n" +
                $"DISCLAIMER: This particular software is NOT suited for all forms of parking garages! By using this software you agree to adapt to the upcoming problems.\n" +
                $"Any action perfomed within this software creates a FREE database on your computer.");
        }
    }
}