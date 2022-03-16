
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

        //TODO: En knapp och kom åt endast en beroende på antalet parkeringsplatser
        private void ShowParkingLotButton_Click(object sender, EventArgs e)
        {
            IfParkingGarageSpotsMoreThanOnehundredScreen ifParkingGarageSpotsMoreThanOnehundredScreen = new();
            ifParkingGarageSpotsMoreThanOnehundredScreen.Show(this);
        }

        private void Ver2Button_Click(object sender, EventArgs e)
        {
            PresentTheParkingGarageScreen presentTheParkingGarageScreen = new();
            presentTheParkingGarageScreen.Show(this);
        }
    }
}