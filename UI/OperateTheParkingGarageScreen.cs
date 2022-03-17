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

namespace UI
{

    public partial class OperateTheParkingGarageScreen : Form
    {
        readonly IntroScreen introScreen = new();
        readonly ParkingGarageLogic parkingGarageLogic = new();
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
            if (VehicleTypeListBox.SelectedItem.Equals(("Car")))
            {
                parkingGarageLogic.ParkingGarageOptions(1, NumberPlateTextBox.Text, ParkingSpotTextBox.Text);
            }

            if(VehicleTypeListBox.SelectedItem.Equals(("Motorcycle")))
            {
                parkingGarageLogic.ParkingGarageOptions(2, NumberPlateTextBox.Text, ParkingSpotTextBox.Text);

            }
        }

        private void MoveVehicleButton_Click(object sender, EventArgs e)
        {
            parkingGarageLogic.ParkingGarageOptions(3, NumberPlateTextBox.Text, ParkingSpotTextBox.Text);
        }

        private void RemoveVehicleButton_Click(object sender, EventArgs e)
        {
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