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

    public partial class OperateTheParkingGarageScreen : Form
    {
        readonly IntroScreen introScreen = new();
        readonly ParkingGarageLogic parkingGarageLogic = new();
        readonly HandleParkingGarage handleParkingGarage = new();
        readonly ParkingGarageLimitations jsonValues = new();
        public OperateTheParkingGarageScreen()
        {
            InitializeComponent();
        }


        private void OperateTheParkingGarageScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            introScreen.Show();
        }

        private void AddVehicleToDbButton_Click(object sender, EventArgs e)
        {

        
            int parkingSpot = int.Parse(ParkingSpotTextBox.Text);
            int currentParkingSpotSize = jsonValues.GetOneIntValueFromJsonFile(8);
            int amountOfParkingSpots = jsonValues.GetOneIntValueFromJsonFile(3);
            int currentSizeAmountForCar = jsonValues.GetOneIntValueFromJsonFile(6);
            int currentSizeAmountForMC = jsonValues.GetOneIntValueFromJsonFile(7);

            int spaceLeftInParkingSpot = 0;
            int usedParkingSpotSpace = 0;
            bool vehicleAlreadyExist = false;
            List<string> allVehicleTypesInCurrentParkingSpot = new List<string>();

            //Check how much space is left in the parking spot
            allVehicleTypesInCurrentParkingSpot = handleParkingGarage.CountEachVehicleTypeInSelectedParkingSpot(parkingSpot);
            usedParkingSpotSpace = handleParkingGarage.UsedSpaceInSelectedParkingSpot(allVehicleTypesInCurrentParkingSpot);


            vehicleAlreadyExist = handleParkingGarage.SearchVehicle(NumberPlateTextBox.Text);

            if (vehicleAlreadyExist)
            {
                InfoRichTextBox.Text = "That number plate already exists in the parking lot!";
            }
            if (NumberPlateTextBox.Text == "" || ParkingSpotTextBox.Text == "" || VehicleTypeListBox.Text =="")
            {
                InfoRichTextBox.Text = "Invalid value at Number Plate field, choice of vehicle or Parking spot field";
            }
            
            if (usedParkingSpotSpace == currentParkingSpotSize)
            {
                InfoRichTextBox.Text = $"The selected parking spot is full!";
            }

            if (parkingSpot > amountOfParkingSpots)
            {
                InfoRichTextBox.Text = $"Incorrect value! Current max value of parking spots are {amountOfParkingSpots}";
            }

            else if (VehicleTypeListBox.Text.Equals(("Car")) && vehicleAlreadyExist==false)
            {
                
                    //Check how much space is left in the parking spot, again
                    allVehicleTypesInCurrentParkingSpot = handleParkingGarage.CountEachVehicleTypeInSelectedParkingSpot(parkingSpot);
                    usedParkingSpotSpace = handleParkingGarage.UsedSpaceInSelectedParkingSpot(allVehicleTypesInCurrentParkingSpot);

                //Den räknar inte minus först?
                    spaceLeftInParkingSpot = currentParkingSpotSize - usedParkingSpotSpace - currentSizeAmountForCar;

                    parkingGarageLogic.ParkingGarageOptions(1, NumberPlateTextBox.Text, ParkingSpotTextBox.Text);
                    InfoRichTextBox.Text = $"Car {NumberPlateTextBox.Text} was parked at parking spot: {ParkingSpotTextBox.Text}, space left: {spaceLeftInParkingSpot}";
                
            }

           else if(VehicleTypeListBox.Text.Equals(("Motorcycle")) && vehicleAlreadyExist == false)
            {
                //Check how much space is left in the parking spot, again
                allVehicleTypesInCurrentParkingSpot = handleParkingGarage.CountEachVehicleTypeInSelectedParkingSpot(parkingSpot);
                usedParkingSpotSpace = handleParkingGarage.UsedSpaceInSelectedParkingSpot(allVehicleTypesInCurrentParkingSpot);

                spaceLeftInParkingSpot = currentParkingSpotSize - usedParkingSpotSpace - currentSizeAmountForMC;

               

                parkingGarageLogic.ParkingGarageOptions(2, NumberPlateTextBox.Text, ParkingSpotTextBox.Text);
                InfoRichTextBox.Text = $"Motorcycle {NumberPlateTextBox.Text} was parked at parking spot: {ParkingSpotTextBox.Text},  space left: {spaceLeftInParkingSpot}";

            }

        
        }

        private void MoveVehicleButton_Click(object sender, EventArgs e)
        {
            int parkingSpot = int.Parse(ParkingSpotTextBox.Text);
            int currentParkingSpotSize = jsonValues.GetOneIntValueFromJsonFile(8);
            int amountOfParkingSpots = jsonValues.GetOneIntValueFromJsonFile(3);
            int spaceLeftInParkingSpot = 0;
            int usedParkingSpotSpace = 0;
            List<string> allVehicleTypesInCurrentParkingSpot = new List<string>();

             allVehicleTypesInCurrentParkingSpot = handleParkingGarage.CountEachVehicleTypeInSelectedParkingSpot(parkingSpot);
            usedParkingSpotSpace = handleParkingGarage.UsedSpaceInSelectedParkingSpot(allVehicleTypesInCurrentParkingSpot);


            if (NumberPlateTextBox.Text == "" || ParkingSpotTextBox.Text == "")
            { 
                InfoRichTextBox.Text = "Invalid value at Number Plate field or Parking spot field";
            }

            //TODO säger inget om man försöker parkera med samma fordon, men resultatet blir detsamma
            else if(usedParkingSpotSpace == currentParkingSpotSize)
            {
                InfoRichTextBox.Text = $"The selected parking spot is full!";
            }
            else if(parkingSpot > amountOfParkingSpots)
            {
                InfoRichTextBox.Text = $"Incorrect value! Current max value of parking spots are {amountOfParkingSpots}";
            }
           
            else
            {
                try
                { 
                parkingGarageLogic.ParkingGarageOptions(3, NumberPlateTextBox.Text, ParkingSpotTextBox.Text);

                    //Check how much space is left in the parking spot, again
                 allVehicleTypesInCurrentParkingSpot = handleParkingGarage.CountEachVehicleTypeInSelectedParkingSpot(parkingSpot);
                usedParkingSpotSpace = handleParkingGarage.UsedSpaceInSelectedParkingSpot(allVehicleTypesInCurrentParkingSpot);

                spaceLeftInParkingSpot = currentParkingSpotSize - usedParkingSpotSpace;

                InfoRichTextBox.Text = $"Parked {NumberPlateTextBox.Text} at parking spot {ParkingSpotTextBox.Text}\n" +
                $"space left: {spaceLeftInParkingSpot}";
                }

                //Vid felaktig inmatning av nummerplåt som inte existerar
                catch (ArgumentOutOfRangeException)
                {
                    InfoRichTextBox.Text = $"This number plate doesn't exist!";
                }
            }
        }

        private void RemoveVehicleButton_Click(object sender, EventArgs e)
        {
            TimeSpan checkoutPrice = new();
            double price = 0;
            string currentVehicleType = "";

            checkoutPrice = handleParkingGarage.AmountOfTime(NumberPlateTextBox.Text);
            currentVehicleType = handleParkingGarage.GetNumberPlateVehicleType(NumberPlateTextBox.Text);

            price = handleParkingGarage.HandlePrice(checkoutPrice, currentVehicleType);

            if (price > 0)
            {
                InfoRichTextBox.Text = $"Current rental price for {NumberPlateTextBox.Text} is {price.ToString()}";
            }
            else
            {
                InfoRichTextBox.Text = $"Parking was free!";
            }

            if (NumberPlateTextBox.Text == null)
            {
                InfoRichTextBox.Text = $"The vehicle was already removed or it doesn't exist!";
            }
            else
            {

                parkingGarageLogic.ParkingGarageOptions(4, NumberPlateTextBox.Text, ParkingSpotTextBox.Text);
            }
           
            
           
        }

    

        private void OperateTheParkingGarageScreen_Load(object sender, EventArgs e)
        {
            ParkingGarageLimitations parkingGarageLimitations = new();

            AddVehicleToDbButton.Enabled = false;
            MoveVehicleButton.Enabled = false;
            RemoveVehicleButton.Enabled = false;
            NumberPlateTextBox.Enabled = false;
            ParkingSpotTextBox.Enabled = false;
            VehicleTypeListBox.Enabled = false;


            for (int i = 4; i <= 5; i++)
            {
                VehicleTypeListBox.Text = parkingGarageLimitations.GetOneStringValueFromJsonFile(i);
                VehicleTypeListBox.Items.Add(VehicleTypeListBox.Text);
            }
            VehicleTypeListBox.Text = ""; //Annars blir det motorcykel

        }

        private void ParkVehicleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AddVehicleToDbButton.Enabled = true;
            MoveVehicleButton.Enabled = false;
            RemoveVehicleButton.Enabled = false;
            NumberPlateTextBox.Enabled = true;
            ParkingSpotTextBox.Enabled = true;
            VehicleTypeListBox.Enabled = true;

        }

        private void MoveVehicleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AddVehicleToDbButton.Enabled = false;
            MoveVehicleButton.Enabled = true;
            RemoveVehicleButton.Enabled = false;
            NumberPlateTextBox.Enabled = true;
            ParkingSpotTextBox.Enabled = true;
            VehicleTypeListBox.Enabled = false;


        }

        private void RemoveVehicleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AddVehicleToDbButton.Enabled = false;
            MoveVehicleButton.Enabled = false;
            RemoveVehicleButton.Enabled = true;
            NumberPlateTextBox.Enabled = true;
            ParkingSpotTextBox.Enabled = false;
            VehicleTypeListBox.Enabled = false;


        }
    }
}