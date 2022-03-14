﻿using System;
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
            parkingGarageLogic.ParkingGarageOptions(1, NumberPlateTextBox.Text,ParkingSpotTextBox.Text);
        }

     
    }
}
