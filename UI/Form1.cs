
using Core;
using GhostSheriffsDatabaseAccess;
using PragueParking_2._0;
namespace UI
{
    public partial class Form1 : Form
    {
        // ParkingGarageLimitations parkingGarageLimitations = new(); Intelsense föreslog static
        public Form1()
        {
            InitializeComponent();
        }

    
        private void UpdatePrice_Click(object sender, EventArgs e)
        {
            
        }

        private void PriceWindow_TextChanged(object sender, EventArgs e)
        {
            string prices = "";
            PriceWindow.Text = ParkingGarageLimitations.GetRentalPrices(prices);
        }
      
    }
}