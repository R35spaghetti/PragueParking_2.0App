
using Core;
using GhostSheriffsDatabaseAccess;
using PragueParking_2._0;
namespace UI
{
    public partial class IntroScreen : Form
    {
        readonly ParkingGarageLimitations parkingGarageLimitations = new(); //Intelsense f�reslog static
        public IntroScreen()
        {
            InitializeComponent();
        }

    
        private void UpdatePrice_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide previous window
            ChangeRentalPricesScreen rentalPricesScreen = new();
            rentalPricesScreen.Show(this);
        }

        private void PriceWindow_TextChanged(object sender, EventArgs e)
        {
            string prices = "";
            PriceWindow.Text = parkingGarageLimitations.GetRentalPrices(prices);
        }


        private void ParkingGarageLimitationValuesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeParkingSpacesScreen changeParkingSpacesScreen = new();
            changeParkingSpacesScreen.Show(this);
        }

        private void GarageOperationsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperateTheParkingGarageScreen operateTheParkingGarageScreen = new();
            operateTheParkingGarageScreen.Show(this);
        }
    }
}