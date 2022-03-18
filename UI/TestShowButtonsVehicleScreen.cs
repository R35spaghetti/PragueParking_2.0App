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
        //TODO
        //1. gör tabellen och döp den, under programmets gång
        //        //2. gå igenom dina fordonsvärden
        //        //3. plocka ut alla parkeringsplatser o lägg i en array
        //        //4. jämför dessa parkeringsplatser med tabellen
        //        //5. om samma, byt ut
        ParkingGarageLimitations parkingGarageLimitations = new();

        public TestShowButtonsVehicleScreen()
        {
            InitializeComponent();
        }

        //skapar knapp
        private void TestShowButtonsVehicleScreen_Load(object sender, EventArgs e)
        {
            int parkingSpotsInTheGarage = parkingGarageLimitations.GetOneIntValueFromJsonFile(3);


            //Antalet platser beroende på maximala antalet parkeringsplatser
            var rows = parkingSpotsInTheGarage / 10;
            var columns = parkingSpotsInTheGarage / 10;
            


            int currentParkingSpot = 0;
            int counter = 0;



            this.VehicleTableLayoutPanel.ColumnCount = columns;
            this.VehicleTableLayoutPanel.RowCount = rows;


            //Rensa standardvärden, är skumt utan dessa
            this.VehicleTableLayoutPanel.ColumnStyles.Clear();
            this.VehicleTableLayoutPanel.RowStyles.Clear();


            //Storleken på knapparna i pixlar
            for (int i = 0; i < columns; i++)
            {
                this.VehicleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100));
            }
            for (int i = 0; i < rows; i++)
            {
                this.VehicleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100));
            }

            //Två loopar för att skriva ut vardera knapp, lodrätt och vågrätt
            for (int i = 0; i < rows; i++)
            {


                for (int j = 0; j < columns; j++)
                {
                   

                    //string[] numbers = mc.Split('|');
                    //int parkingSpotNumber = int.Parse(numbers[1]);
                    //currentParkingSpot += 2;
                    counter++;

                    //En ny knapp vid varje ny position
                    var VehicleInfoButton = new Button();

                    //Lägger till siffror, som 1,2,3,4,5 osv
                    VehicleInfoButton.Text = string.Format("{0}", counter);
                    //Namnger kontrollerna
                    VehicleInfoButton.Name = string.Format("{0}",counter);

                    //Lägger till knappen vid rad "x" och kolumn "y" i rutnätet.
                    this.VehicleTableLayoutPanel.Controls.Add(VehicleInfoButton, j, i);
                    VehicleInfoButton.Dock = DockStyle.Fill;

                    //Klicka på 12 för att visa text
                    if(VehicleInfoButton.Name == "12")
                    {
                        VehicleInfoButton.Click += new EventHandler(VehicleInfoButton_Click);
                        this.VehicleTableLayoutPanel.Controls.Add(VehicleInfoButton);
                    }


                }
                void VehicleInfoButton_Click(object sender, EventArgs e)
                {
                    ShowVehiclesRichTextBox.Text = "fasf | 12";
                }
            }
        }
        //Njaa
        private void ReplaceNumericButtonsWithNumberPlateAndParkingSpot(int parkingSpotsInTheGarage)
        {
        //    int[] onlyTheParkingSpot = 0;
            List<string> numberplatesWithParkingSpot = new();
            parkingSpotsInTheGarage = parkingGarageLimitations.GetOneIntValueFromJsonFile(3);




            ParkingGarageLogic logic = new();

            var carNumberPlateAndParkingSpot = "";
            var motorcycleNumberPlateAndParkingSpot = "";

            var previousEntryMC = "";
            var previousEntryCar = "";

            for (int i = 0; i < parkingSpotsInTheGarage; i++)
            {

                //Få ut nummerplåten och parkeringsplatsen från databasen
                carNumberPlateAndParkingSpot = logic.PresentVehicles(carNumberPlateAndParkingSpot, parkingSpotsInTheGarage, "Car");
                motorcycleNumberPlateAndParkingSpot = logic.PresentVehicles(motorcycleNumberPlateAndParkingSpot, parkingSpotsInTheGarage, "Motorcycle");

                if (carNumberPlateAndParkingSpot != "" && carNumberPlateAndParkingSpot != previousEntryCar)
                {

                    numberplatesWithParkingSpot.Add(carNumberPlateAndParkingSpot);
                     previousEntryCar = carNumberPlateAndParkingSpot;


                }

                if (motorcycleNumberPlateAndParkingSpot != "" && motorcycleNumberPlateAndParkingSpot != previousEntryMC)
                {
                    numberplatesWithParkingSpot.Add(motorcycleNumberPlateAndParkingSpot);
                    previousEntryMC = motorcycleNumberPlateAndParkingSpot;


                }
            }
        }



        //TODO ta endast ut nummerplåten här, använd siffran för att skippa en knapp

        ////Fyller knappen med nummerplåten från bil
        //if (mc != "" && mc != previousEntryMC)
        //{
        //    VehicleInfoButton.Text = string.Format(mc, counter);
        //    VehicleInfoButton.BackColor = Color.Green;
        //    previousEntryMC = mc;
        //    this.VehicleTableLayoutPanel.Controls.Add(VehicleInfoButton, j, i);
        //    VehicleInfoButton.Dock = DockStyle.Fill;

        //    if (parkingSpotNumber != counter)
        //    {
        //        VehicleInfoButton.Text = string.Format("{0}", counter);
        //        //Namnger kontrollerna
        //        VehicleInfoButton.Name = string.Format("{0}",counter);
        //        this.VehicleTableLayoutPanel.Controls.Add(VehicleInfoButton, j, i);
        //        VehicleInfoButton.Dock = DockStyle.Fill;

        //    }
        //    if (this.VehicleTableLayoutPanel.Name = parkingSpotNumber)
        //    {
        //        //ersätt värden här


        //      
        //    }
        //}







    }


                }

