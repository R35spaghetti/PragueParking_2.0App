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
    public partial class ShowParkingLotOverviewScreen : Form
    {

  
        ParkingGarageLimitations parkingGarageLimitations = new();
        readonly HandleParkingGarage handleParkingGarage = new();
        private object longStringWithCars = "Cars: ";
        private object longStringWithMCS = "Motorcycles: ";

        public ShowParkingLotOverviewScreen()
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
            int numberForButton = 0; //för att visa knapparna som "1" "2" "3"...osv



            List<string> splitGetAffectedParkinglots = new();
            List<string> allVehicleTypesInCurrentParkingSpot = new();

            int parkingSpotsInTheGarage = parkingGarageLimitations.GetOneIntValueFromJsonFile(3);

            // splitGetAffectedParkinglots = GetAllAffectedParkingLots(splitGetAffectedParkinglots, parkingSpotsInTheGarage);
            //  splitGetAffectedParkinglots.Sort();

            //TODO låta användaren lösa detta problem
            //Antalet platser beroende på maximala antalet parkeringsplatser
            int rows = parkingSpotsInTheGarage / 10;
            int columns = parkingSpotsInTheGarage / 10;









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
                    (string, int, int) HoldVehicleTypeAndAmountOfVehicles = ("", 0, numberForButton);

                    /*Räkna antalet fordonstyper med hjälp av json-värdet, räkna sedan ut om parkeringsplatsen är full.
                     etc: car(4)+car(4)=plats(8) 8=full */
                    allVehicleTypesInCurrentParkingSpot = handleParkingGarage.CountEachVehicleTypeInSelectedParkingSpot(numberForButton);
                    usedParkingSpotSpace = handleParkingGarage.UsedSpaceInSelectParkingSpot(allVehicleTypesInCurrentParkingSpot);
                    HoldVehicleTypeAndAmountOfVehicles = handleParkingGarage.WhatKindOfVehiclesInSelectedParkingSpot(HoldVehicleTypeAndAmountOfVehicles);




                    //En ny knapp vid varje ny position
                    var CreateVehicleButton = new Button();
                    CreateVehicleInformationButton();

                    //Lägger till siffror, som 1,2,3,4,5 osv till de genererade knapparna
                    CreateVehicleButton.Text = string.Format("{0}", numberForButton);
                    //Namnger kontrollerna
                    CreateVehicleButton.Name = string.Format("{0}", numberForButton);

                    //Lägger till knappen vid rad "x" och kolumn "y" i rutnätet.
                    this.VehicleTableLayoutPanel.Controls.Add(CreateVehicleButton, j, i);
                    CreateVehicleButton.Dock = DockStyle.Fill;

                    //Rosa om full
                    if (usedParkingSpotSpace.Equals(currentParkingSpotSize))
                    {
                        CreateVehicleButton.BackColor = Color.DeepPink;
                        CreateVehicleButton.Click += new EventHandler(CreateVehicleInformationButton_Click);
                        this.VehicleTableLayoutPanel.Controls.Add(CreateVehicleButton);
                    }
                    //Om en fordonstyp
                    else if (HoldVehicleTypeAndAmountOfVehicles.Item2 == 1)
                    {
                        //Om bil måla gul
                        if (HoldVehicleTypeAndAmountOfVehicles.Item1 == parkingGarageLimitations.GetOneStringValueFromJsonFile(4))
                        {
                            CreateVehicleButton.BackColor = Color.Yellow;
                            CreateVehicleButton.Click += new EventHandler(CreateVehicleInformationButton_Click);
                            this.VehicleTableLayoutPanel.Controls.Add(CreateVehicleButton);
                        }

                        //Om motorcykel måla röd
                        else if (HoldVehicleTypeAndAmountOfVehicles.Item1 == parkingGarageLimitations.GetOneStringValueFromJsonFile(5))
                        {
                            CreateVehicleButton.BackColor = Color.Red;
                            CreateVehicleButton.Click += new EventHandler(CreateVehicleInformationButton_Click);
                            this.VehicleTableLayoutPanel.Controls.Add(CreateVehicleButton);
                        }
                    }

                    //För att rött och gult blir orange 8)
                    else if (HoldVehicleTypeAndAmountOfVehicles.Item2 >= 2)
                    {
                        CreateVehicleButton.BackColor = Color.Orange;
                        CreateVehicleButton.Click += new EventHandler(CreateVehicleInformationButton_Click);
                        this.VehicleTableLayoutPanel.Controls.Add(CreateVehicleButton);
                    }



                }



            }
        }
    }
}




                

