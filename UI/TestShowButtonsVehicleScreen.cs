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
        private object longStringWithCars = "Cars: ";
        private object longStringWithMCS = "Motorcycles: ";

        public TestShowButtonsVehicleScreen()
        {

            InitializeComponent();
            CreateVehicleButton();
        }

        /*Knapp som genereras, blir grön om ett fordon har parkerats. Vid ett tryck på knappen -
        / visas allt som är parkerat*/
        private void CreateVehicleButton()
        {
            Button VehicleButton = new Button();
            VehicleButton.Height = 200;
            VehicleButton.Width = 200;

            VehicleButton.Click += new EventHandler(CreateVehicleButton_Click);
            Controls.Add(VehicleButton);
        }

        private void CreateVehicleButton_Click(object? sender, EventArgs e)
        {
            //Presenterar alla nummerplåtar genom en sträng
            ShowVehiclesRichTextBox.Text = $"{longStringWithCars} \n {longStringWithMCS}";

            //Kan visa parkeringsnummer också
        }

        //skapar knapp
        private void TestShowButtonsVehicleScreen_Load(object sender, EventArgs e)
        {
            ParkingGarageLogic logic = new();
            int parkingSpotsInTheGarage = parkingGarageLimitations.GetOneIntValueFromJsonFile(3);

            //TODO låta användaren lösa detta problem
            //Antalet platser beroende på maximala antalet parkeringsplatser
            int rows = parkingSpotsInTheGarage / 10;
            int columns = parkingSpotsInTheGarage / 10;

            
            int counter = 0; //för att visa knapparna som "1" "2" "3"...osv
            int currentParkingSpot = 0;
            List<string> splitGetCarParkinglot = new();


            var carNumberPlateAndParkingSpot = "";
            var motorcycleNumberPlateAndParkingSpot = "";

            var previousEntryMC = "";
            var previousEntryCar = "";
       

            this.VehicleTableLayoutPanel.ColumnCount = columns;
            this.VehicleTableLayoutPanel.RowCount = rows;

            //Rensa standardvärden, är skumt utan dessa
            this.VehicleTableLayoutPanel.ColumnStyles.Clear();
            this.VehicleTableLayoutPanel.RowStyles.Clear();


            //Storleken på knapparna i pixlar i TableLayoutPanelen
            for (int i = 0; i < columns; i++)
            {
                this.VehicleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25));
            }
            for (int i = 0; i < rows; i++)
            {
                this.VehicleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25));
            }

            //Två loopar för att skriva ut vardera knapp, lodrätt och vågrätt
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < columns; j++)
                {
                    
                    //Få ut nummerplåten och parkeringsplatsen från databasen
                    carNumberPlateAndParkingSpot = logic.PresentVehicles(carNumberPlateAndParkingSpot, currentParkingSpot, "Car");
                    motorcycleNumberPlateAndParkingSpot = logic.PresentVehicles(motorcycleNumberPlateAndParkingSpot, currentParkingSpot, "Motorcycle");

                    if (carNumberPlateAndParkingSpot != "" && carNumberPlateAndParkingSpot != previousEntryCar)
                    {
                        //få regnummer
                      string[]  splitGetCarAndParkingSpot = carNumberPlateAndParkingSpot.Split('|');
                        longStringWithCars += $"\n{carNumberPlateAndParkingSpot}\n";

                        splitGetCarParkinglot.Add(splitGetCarAndParkingSpot[1]); //få parkeringsplats

                        previousEntryCar = carNumberPlateAndParkingSpot;


                    }

                    if (motorcycleNumberPlateAndParkingSpot != "" && motorcycleNumberPlateAndParkingSpot != previousEntryMC)
                    {
                        //få regnummer
                       string[] splitGetMotorcycleAndParkingSpot = motorcycleNumberPlateAndParkingSpot.Split('|');
                        longStringWithMCS += $"\n{motorcycleNumberPlateAndParkingSpot}\n";
                        splitGetCarParkinglot.Add(splitGetMotorcycleAndParkingSpot[1]); // få parkeringsplats
                        previousEntryMC = motorcycleNumberPlateAndParkingSpot;


                    }

                    currentParkingSpot += 2; //För att kunna ta ut både nummerplåten och parkeringsplatsen
                    counter++;

                    //En ny knapp vid varje ny position

                    var CreateVehicleButton = new Button();

                    //Lägger till siffror, som 1,2,3,4,5 osv till de genererade knapparna
                    CreateVehicleButton.Text = string.Format("{0}", counter);
                    //Namnger kontrollerna
                    CreateVehicleButton.Name = string.Format("{0}",counter);

                    //Lägger till knappen vid rad "x" och kolumn "y" i rutnätet.
                    this.VehicleTableLayoutPanel.Controls.Add(CreateVehicleButton, j, i);
                    CreateVehicleButton.Dock = DockStyle.Fill;


                    foreach (var items in splitGetCarParkinglot)
                    {

                      int compareParkingLot=  int.Parse(items);
                        if(compareParkingLot.Equals(counter)) { 
                            CreateVehicleButton.BackColor = Color.Green;
                            CreateVehicleButton.Click += new EventHandler(CreateVehicleButton_Click);
                            this.VehicleTableLayoutPanel.Controls.Add(CreateVehicleButton);
                      }
                     
                    }
               
                }
              


            }
        }

    




    }




                }

