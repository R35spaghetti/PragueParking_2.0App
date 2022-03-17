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


            if (VehicleTypeListBox.Text.Equals(""))
            { }

          else if (VehicleTypeListBox.Text.Equals(("Car")))
            {
                parkingGarageLogic.ParkingGarageOptions(1, NumberPlateTextBox.Text, ParkingSpotTextBox.Text);
            }

           else if(VehicleTypeListBox.Text.Equals(("Motorcycle")))
            {
                parkingGarageLogic.ParkingGarageOptions(2, NumberPlateTextBox.Text, ParkingSpotTextBox.Text);

            }
        }

        private void MoveVehicleButton_Click(object sender, EventArgs e)
        {
            if (NumberPlateTextBox.Text == "" || ParkingSpotTextBox.Text == "")
            { }
            else
            {
                parkingGarageLogic.ParkingGarageOptions(3, NumberPlateTextBox.Text, ParkingSpotTextBox.Text);
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
            InfoRichTextBox.Text = $"Current rental price is {price.ToString()}";

            parkingGarageLogic.ParkingGarageOptions(4, NumberPlateTextBox.Text, ParkingSpotTextBox.Text);
            
           
            
           
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