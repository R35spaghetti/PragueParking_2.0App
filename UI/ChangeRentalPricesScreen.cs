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
    public partial class ChangeRentalPricesScreen : Form
    {
        readonly Core.ParkingGarageLimitations parkingGarageLimitations = new(); //bör vara i static eller inte? DENNA

        public ChangeRentalPricesScreen()
        {
            InitializeComponent();
        }

        private void SubmitNewRentalPrices_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(CarRentalPriceTextbox.Text))
            {
                parkingGarageLimitations.SwitchMenuValues(CarRentalPriceTextbox.Text, 1);   
            }

           if (!string.IsNullOrWhiteSpace(MCRentalPriceTextbox.Text))
            {
                parkingGarageLimitations.SwitchMenuValues(MCRentalPriceTextbox.Text, 2);
            }

        }
    }
}
