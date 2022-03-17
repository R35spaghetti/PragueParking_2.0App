
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

        private void PriceWindow_Load(object sender, EventArgs e)
        {
            ParkingGarageLimitations parkingGarageLimitations = new();
            string prices = "";
         PriceWindow.Text = parkingGarageLimitations.GetRentalPrices(prices);

     
           
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
            LoadingScreen loadingScreen = new();
            loadingScreen.Show(this);
           
     
            
        }


    }
}