using Core;
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
    public partial class TestShowButtonsVehicleScreen : Form
    {



        public TestShowButtonsVehicleScreen()
        {
            InitializeComponent();
        }

        //skapar knapp
        private void TestShowButtonsVehicleScreen_Load(object sender, EventArgs e)
        {
            ParkingGarageLimitations parkingGarageLimitations = new();
            int parkingSpotsInTheGarage = parkingGarageLimitations.GetOneIntValueFromJsonFile(3);
            ParkingGarageLogic logic = new();


            //Antalet platser beroende på maximala antalet parkeringsplatser
            var rows = parkingSpotsInTheGarage / 10;
            var columns = parkingSpotsInTheGarage/ 10;
            var car = "";
            var mc = "";
            var previousEntryMC = "";
            var previousEntryCar = "";
            int currentParkingSpot = 0;
            int counter = 0;



            this.VehicleTableLayoutPanel.ColumnCount = columns;
            this.VehicleTableLayoutPanel.RowCount = rows;


            //Annars ser det skumt ut
            this.VehicleTableLayoutPanel.ColumnStyles.Clear();
            this.VehicleTableLayoutPanel.RowStyles.Clear();


            //Storleken på knapparna i pixlar
            for (int i = 0; i < columns; i++)
            {
                this.VehicleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute,100));
            }
            for (int i = 0; i < rows; i++)
            {
                this.VehicleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute,100));
            }

            //Två loopar för att skriva ut vardera knapp, lodrätt och vågrätt
            for (int i = 0; i < rows; i++)
            {


                for (int j = 0; j < columns; j++)
                {
                    //Få ut nummerplåten och  från databasen
                    car = logic.PresentVehicles(car, currentParkingSpot, "Car");
                    mc = logic.PresentVehicles(mc, currentParkingSpot, "Motorcycle");
                    currentParkingSpot+=2;
                    counter++;

                    //En ny knapp vid varje ny position
                    var VehicleInfoButton = new Button();


                    //TODO ta endast ut nummerplåten här, använd siffran för att skippa en knapp

                    //Fyller knappen med nummerplåten från bil
                    if (mc != "" && mc != previousEntryMC)
                    {
                        VehicleInfoButton.Text = string.Format(mc);
                        previousEntryMC = mc;
                        this.VehicleTableLayoutPanel.Controls.Add(VehicleInfoButton);
                        VehicleInfoButton.Dock = DockStyle.Fill;



                    }

                    //Fyller knappen med nummerplåten från motorcykel
                    if (car != "" && car != previousEntryCar)
                    {
                        VehicleInfoButton.Text = string.Format(car);
                        previousEntryCar = car;
                        this.VehicleTableLayoutPanel.Controls.Add(VehicleInfoButton);
                        VehicleInfoButton.Dock = DockStyle.Fill;

                    }
                    //Lägger till knappen vid rad "x" och kolumn "y" i kolumnen.
                    //Lägger till resten av knapparna 1, 2, 3, 4 osv
                    //else
                    //{
                    //    //Namnger enligt räknaren

                    //    VehicleInfoButton.Text = string.Format("{0}", counter);
                    //    this.VehicleTableLayoutPanel.Controls.Add(VehicleInfoButton, j, i);
                    //    VehicleInfoButton.Dock = DockStyle.Fill;

                    //}




                }
            }
        }

    
    }
}
