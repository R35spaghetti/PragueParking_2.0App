using Core;
using Core.ParkingGarage;
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
        readonly HandleParkingGarage handleParkingGarage = new();
        private object longStringWithCars = "Cars: ";
        private object longStringWithMCS = "Motorcycles: ";

        public TestShowButtonsVehicleScreen()
        {
           // CreateVehicleInformationButton();
            InitializeComponent();

        }

        /*Knapp som genereras, blir grön om ett fordon har parkerats. Vid ett tryck på knappen -
        / visas allt som är parkerat - redundant?*/
        private void CreateVehicleInformationButton()
        {
            Button VehicleButton = new Button();
            VehicleButton.Height = 200;
            VehicleButton.Width = 200;



            VehicleButton.Click += new EventHandler(CreateVehicleInformationButton_Click);
            Controls.Add(VehicleButton);

        }

        private void CreateVehicleInformationButton_Click(object? sender, EventArgs e)
        {


            //Presenterar alla nummerplåtar och parkeringsplatsen genom en sträng
            ShowVehiclesRichTextBox.Text = $"{longStringWithCars} \n {longStringWithMCS}";

        }

        //skapar knapp
        private void TestShowButtonsVehicleScreen_Load(object sender, EventArgs e)
        {
            int currentParkingSpotSize = parkingGarageLimitations.GetOneIntValueFromJsonFile(8);
            int usedParkingSpotSpace = 0;

            List<string> splitGetAffectedParkinglots = new();
            List<string> allVehicleTypesInCurrentParkingSpot = new();

            int parkingSpotsInTheGarage = parkingGarageLimitations.GetOneIntValueFromJsonFile(3);

           // splitGetAffectedParkinglots = GetAllAffectedParkingLots(splitGetAffectedParkinglots, parkingSpotsInTheGarage);
            splitGetAffectedParkinglots.Sort();

            //TODO låta användaren lösa detta problem
            //Antalet platser beroende på maximala antalet parkeringsplatser
            int rows = parkingSpotsInTheGarage / 10;
            int columns = parkingSpotsInTheGarage / 10;

            
            int numberForButton = 0; //för att visa knapparna som "1" "2" "3"...osv







            this.VehicleTableLayoutPanel.ColumnCount = columns;
            this.VehicleTableLayoutPanel.RowCount = rows;

            //Rensa standardvärden, är skumt utan dessa
            this.VehicleTableLayoutPanel.ColumnStyles.Clear();
            this.VehicleTableLayoutPanel.RowStyles.Clear();



            //Storleken på knapparna i % i TableLayoutPanelen
            for (int i = 0; i < columns; i++)
            {
                this.VehicleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50));
            }
            for (int i = 0; i < rows; i++)
            {
                this.VehicleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50));
            }

            //Två loopar för att skriva ut vardera knapp, lodrätt och vågrätt
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < columns; j++)
                {




                    numberForButton++;
                    allVehicleTypesInCurrentParkingSpot = handleParkingGarage.CountEachVehicleTypeInSelectedParkingSpot(numberForButton);

                    usedParkingSpotSpace = handleParkingGarage.UsedSpaceInSelectParkingSpot(allVehicleTypesInCurrentParkingSpot);

                    //En ny knapp vid varje ny position
                    var CreateVehicleButton = new Button();
                    CreateVehicleInformationButton();

                    //Lägger till siffror, som 1,2,3,4,5 osv till de genererade knapparna
                    CreateVehicleButton.Text = string.Format("{0}", numberForButton);
                    //Namnger kontrollerna
                    CreateVehicleButton.Name = string.Format("{0}",numberForButton);

                    //Lägger till knappen vid rad "x" och kolumn "y" i rutnätet.
                    this.VehicleTableLayoutPanel.Controls.Add(CreateVehicleButton, j, i);
                    CreateVehicleButton.Dock = DockStyle.Fill;

                    //Målas gul om det är fullt
                    if (usedParkingSpotSpace.Equals(currentParkingSpotSize))
                    {
                        CreateVehicleButton.BackColor = Color.Yellow;
                        CreateVehicleButton.Click += new EventHandler(CreateVehicleInformationButton_Click);
                        this.VehicleTableLayoutPanel.Controls.Add(CreateVehicleButton);
                    }

                    //Jämför fordonets parkeringsplats med skaparen av knappar-räknaren
                    foreach (var items in splitGetAffectedParkinglots)
                    {

                      int compareParkingLot=  int.Parse(items);
                        if(compareParkingLot.Equals(numberForButton)) { 
                            CreateVehicleButton.BackColor = Color.Green;
                            CreateVehicleButton.Click += new EventHandler(CreateVehicleInformationButton_Click);
                            this.VehicleTableLayoutPanel.Controls.Add(CreateVehicleButton);
                      }
                     
                    }
               
                }
              


            }
        }
        //TODO säkert att denna inte behövs
        //Hämta alla parkeringsplatser med minst ett fordon i
        private List<string> GetAllAffectedParkingLots(List<string> splitGetAffectedParkinglots, int parkingSpotsInTheGarage)
        {
            ParkingGarageLogic logic = new();

            int currentParkingSpot = 0;

            var carNumberPlateAndParkingSpot = "";
            var motorcycleNumberPlateAndParkingSpot = "";
            var timeStamp = DateTime.Now;
            var previousEntryMC = "";
            var previousEntryCar = "";



            for (int i = 0; i < parkingSpotsInTheGarage; i++)
            {
                //Få ut nummerplåten och parkeringsplatsen från databasen
                carNumberPlateAndParkingSpot = logic.PresentVehicles(carNumberPlateAndParkingSpot, currentParkingSpot, "Car", timeStamp);
                motorcycleNumberPlateAndParkingSpot = logic.PresentVehicles(motorcycleNumberPlateAndParkingSpot, currentParkingSpot, "Motorcycle", timeStamp);

                currentParkingSpot += 3; //För få ut fordonet och dess värden


                if (carNumberPlateAndParkingSpot != "" && carNumberPlateAndParkingSpot != previousEntryCar)
                {
                    //få regnummer
                    string[] splitGetCarAndParkingSpot = carNumberPlateAndParkingSpot.Split('|');
                    longStringWithCars += $"\n{carNumberPlateAndParkingSpot}\n";

                    splitGetAffectedParkinglots.Add(splitGetCarAndParkingSpot[1]); //få parkeringsplats

                    previousEntryCar = carNumberPlateAndParkingSpot;


                }

                if (motorcycleNumberPlateAndParkingSpot != "" && motorcycleNumberPlateAndParkingSpot != previousEntryMC)
                {
                    //få regnummer
                    string[] splitGetMotorcycleAndParkingSpot = motorcycleNumberPlateAndParkingSpot.Split('|');
                    longStringWithMCS += $"\n{motorcycleNumberPlateAndParkingSpot}\n";
                    splitGetAffectedParkinglots.Add(splitGetMotorcycleAndParkingSpot[1]); // få parkeringsplats
                    previousEntryMC = motorcycleNumberPlateAndParkingSpot;


                }

            }
            return splitGetAffectedParkinglots;
        }
    }




                }

