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
        TestDataLogic testData = new();

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
            testData.EnsureCreatedDB(); //Om användaren bara vill ha en tom databas
            int parkingSpot = int.Parse(ParkingSpotTextBox.Text);
            int currentParkingSpotSize = jsonValues.GetOneIntValueFromJsonFile(8);
            int amountOfParkingSpots = jsonValues.GetOneIntValueFromJsonFile(3);
            int currentSizeAmountForCar = jsonValues.GetOneIntValueFromJsonFile(6);
            int currentSizeAmountForMC = jsonValues.GetOneIntValueFromJsonFile(7);
            List<string> allVehicleTypesInCurrentParkingSpot = new();

            //Check how much space is left in the parking spot
            allVehicleTypesInCurrentParkingSpot = handleParkingGarage.CountEachVehicleTypeInSelectedParkingSpot(parkingSpot);
            int usedParkingSpotSpace = handleParkingGarage.UsedSpaceInSelectedParkingSpot(allVehicleTypesInCurrentParkingSpot);

            bool parkingLotIsFull = false;
            bool vehicleAlreadyExist = handleParkingGarage.SearchVehicle(NumberPlateTextBox.Text);
            bool numberPlateFormatAllowed = handleParkingGarage.CheckIfNumberPlateIsCorrect(NumberPlateTextBox.Text);

            if(numberPlateFormatAllowed == false)
            {
                InfoRichTextBox.Text = "Number plate has incorrect format use only: letters, numbers, '.' and '-'";

            }

            else if (vehicleAlreadyExist)
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
                parkingLotIsFull = true;
            }


            int spaceLeftInParkingSpot;

            if (parkingSpot > amountOfParkingSpots)
            {
                InfoRichTextBox.Text = $"Incorrect value! Current max value of parking spots are {amountOfParkingSpots}";
            }

            else if (VehicleTypeListBox.Text.Equals(("Car")) && vehicleAlreadyExist == false && numberPlateFormatAllowed == true && parkingLotIsFull == false)
            {

                //Check how much space is left in the parking spot, again
                allVehicleTypesInCurrentParkingSpot = handleParkingGarage.CountEachVehicleTypeInSelectedParkingSpot(parkingSpot);
                usedParkingSpotSpace = handleParkingGarage.UsedSpaceInSelectedParkingSpot(allVehicleTypesInCurrentParkingSpot);

                //Den räknar inte minus först?
                spaceLeftInParkingSpot = currentParkingSpotSize - usedParkingSpotSpace - currentSizeAmountForCar;

                parkingGarageLogic.ParkingGarageOptions(1, NumberPlateTextBox.Text, ParkingSpotTextBox.Text);
                InfoRichTextBox.Text = $"Car {NumberPlateTextBox.Text} was parked at parking spot: {ParkingSpotTextBox.Text}, space left: {spaceLeftInParkingSpot}";

            }

            else if (VehicleTypeListBox.Text.Equals(("Motorcycle")) && vehicleAlreadyExist == false && numberPlateFormatAllowed == true && parkingLotIsFull == false)
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
            testData.EnsureCreatedDB(); //Om användaren bara vill ha en tom databas
            int parkingSpot = int.Parse(ParkingSpotTextBox.Text);
            int currentParkingSpotSize = jsonValues.GetOneIntValueFromJsonFile(8);
            int amountOfParkingSpots = jsonValues.GetOneIntValueFromJsonFile(3);
            List<string> allVehicleTypesInCurrentParkingSpot = new();

             allVehicleTypesInCurrentParkingSpot = handleParkingGarage.CountEachVehicleTypeInSelectedParkingSpot(parkingSpot);
            int usedParkingSpotSpace = handleParkingGarage.UsedSpaceInSelectedParkingSpot(allVehicleTypesInCurrentParkingSpot);


            if (NumberPlateTextBox.Text == "" || ParkingSpotTextBox.Text == "")
            { 
                InfoRichTextBox.Text = "Invalid value at Number Plate field or Parking spot field";
            }

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

                    int spaceLeftInParkingSpot = currentParkingSpotSize - usedParkingSpotSpace;

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
            testData.EnsureCreatedDB(); //Om användaren bara vill ha en tom databas
            TimeSpan checkoutPrice = new();
            checkoutPrice = handleParkingGarage.AmountOfTime(NumberPlateTextBox.Text);
            string currentVehicleType = handleParkingGarage.GetNumberPlateVehicleType(NumberPlateTextBox.Text);
            double price = handleParkingGarage.HandlePrice(checkoutPrice, currentVehicleType);
            bool vehicleAlreadyExist = handleParkingGarage.SearchVehicle(NumberPlateTextBox.Text);

            if (price > 0)
            {
                InfoRichTextBox.Text = $"Current rental price for {NumberPlateTextBox.Text} is {price}";
            }
            if(!vehicleAlreadyExist)
            {
                InfoRichTextBox.Text = $"Vehicle doesn't exist!";
            }
            else if (price < 0)
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