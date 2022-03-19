using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ChangeParkingLimitationsScreen : Form
    {
        readonly Core.ParkingGarageLimitations parkingGarageLimitations = new();
        readonly IntroScreen introScreen = new();


        public ChangeParkingLimitationsScreen()
        {
            InitializeComponent();
        }

        private void SubmitParkingSpotLimitationValuesButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(CarRentalPriceTextbox.Text))
            {
                parkingGarageLimitations.SwitchMenuValues(CarRentalPriceTextbox.Text, 1);
            }


            if (!string.IsNullOrWhiteSpace(MCRentalPriceTextbox.Text))
            {
                parkingGarageLimitations.SwitchMenuValues(MCRentalPriceTextbox.Text, 2);
            }

            if (!string.IsNullOrWhiteSpace(ParkingSpotTextBox.Text))
            {
                parkingGarageLimitations.SwitchMenuValues(ParkingSpotTextBox.Text, 3);
            }

            if (!string.IsNullOrWhiteSpace(CarSizeTextBox.Text))
            {
                parkingGarageLimitations.SwitchMenuValues(CarSizeTextBox.Text, 6);
            }

            if (!string.IsNullOrWhiteSpace(MCSizeTextBox.Text))
            {
                parkingGarageLimitations.SwitchMenuValues(MCSizeTextBox.Text, 7);
            }

            if (!string.IsNullOrWhiteSpace(ParkingSpotSizeTextBox.Text))
            {
                parkingGarageLimitations.SwitchMenuValues(ParkingSpotSizeTextBox.Text, 8);
            }


            this.Hide();
            introScreen.Show();
        }

        private void ChangeParkingSpacesScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            introScreen.Show();
        }

      
    }
}
