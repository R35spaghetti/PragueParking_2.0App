
using Core;
using GhostSheriffsDatabaseAccess;
using PragueParking_2._0;
namespace UI
{
    public partial class IntroScreen : Form
    {
        readonly ParkingGarageLimitations parkingGarageLimitations = new(); //Intelsense föreslog static
        public IntroScreen()
        {
            InitializeComponent();
        }

    
        private void UpdatePrice_Click(object sender, EventArgs e)
        {
            ChangeRentalPricesScreen rentalPricesScreen = new();
            rentalPricesScreen.Show(this);
        }

        private void PriceWindow_TextChanged(object sender, EventArgs e)
        {
            string prices = "";
            PriceWindow.Text = parkingGarageLimitations.GetRentalPrices(prices);
        }

        private void IntroScreen_Load(object sender, EventArgs e)
        {

        }
    }
}