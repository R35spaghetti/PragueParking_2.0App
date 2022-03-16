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
    //TODO Två versioner
    public partial class PresentTheParkingGarageScreen : Form
    {
        ParkingGarageLogic parkingGarageLogic = new();
        public PresentTheParkingGarageScreen()
        {
            InitializeComponent();
        }
        //if mer än 100 visa denna lista annars ett par bilder
        private void PresentTheParkingGarageScreen_Load(object sender, EventArgs e)
        {
            string previousEntryMC = "";
            string previousEntryCar = "";
            int currentParkingSpot = 0; 
            //kraschar beroende på antalet parkeringsplatser
            for (int i = 0; i < 100; i++)
            {

               CarListBox.Text = parkingGarageLogic.PresentVehicles(CarListBox.Text, currentParkingSpot, "Car");


           
                MotorcycleListBox.Text = parkingGarageLogic.PresentVehicles(MotorcycleListBox.Text, currentParkingSpot, "Motorcycle");
                currentParkingSpot += 2;
                if (MotorcycleListBox.Text != "" && MotorcycleListBox.Text != previousEntryMC)
                {
                    MotorcycleListBox.Items.Add(MotorcycleListBox.Text);
                    MotorcycleListBox.BackColor = Color.Green;
                    previousEntryMC = MotorcycleListBox.Text;

                    switch (i)
                    {
                        case 0:
                            SecondVehicleListBox.Items.Add(MotorcycleListBox.Text);
                            break;
                    }
                }
                if (CarListBox.Text != "" && CarListBox.Text != previousEntryCar)
                {
                    CarListBox.Items.Add(CarListBox.Text);
                    CarListBox.BackColor = Color.Red;
                    previousEntryCar = CarListBox.Text;
                }
            }

            
            }
        
    }
}

     
    

