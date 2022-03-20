
using Core;
using Core.ParkingGarage;
using GhostSheriffsDatabaseAccess;
using PragueParking_2._0;
namespace UI
{
    public partial class IntroScreen : Form
    {



        //readonly ParkingGarageLimitations parkingGarageLimitations = new(); //Intelsense f�reslog static
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
        
    }
}