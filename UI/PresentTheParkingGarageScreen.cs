using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using Core.ParkingGarage;

namespace UI
{
    public partial class PresentTheParkingGarageScreen : Form
    {
      readonly ParkingGarageLogic parkingGarageLogic = new();
        public PresentTheParkingGarageScreen()
        {
            InitializeComponent();
        }
        private void PresentTheParkingGarageScreen_Load(object sender, EventArgs e)
        {
            string previousEntryMC = "";
            string previousEntryCar = "";
            int currentParkingSpot = 0;
         
            ParkingGarageLimitations parkingGarageLimitations = new();
        int parkingSpotsInTheGarage =   parkingGarageLimitations.GetOneIntValueFromJsonFile(3);

            for (int i = 0; i < parkingSpotsInTheGarage; i++)
            {

                CarListBox.Text = parkingGarageLogic.PresentVehicles(CarListBox.Text, currentParkingSpot, "Car");
                MotorcycleListBox.Text = parkingGarageLogic.PresentVehicles(MotorcycleListBox.Text, currentParkingSpot, "Motorcycle");
                             

                currentParkingSpot += 2;

                if (MotorcycleListBox.Text != "" && MotorcycleListBox.Text != previousEntryMC)
                {
                   MotorcycleListBox.Items.Add(MotorcycleListBox.Text);
                    previousEntryMC = MotorcycleListBox.Text;
               
                }

                if (CarListBox.Text != "" && CarListBox.Text != previousEntryCar)
                {
                    CarListBox.Items.Add(CarListBox.Text);
                    previousEntryCar = CarListBox.Text;
                }
            }

            
            }

    
    }
}

     
    

