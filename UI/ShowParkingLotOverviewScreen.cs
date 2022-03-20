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

       readonly ParkingGarageLimitations parkingGarageLimitations = new();
        readonly HandleParkingGarage handleParkingGarage = new();
        readonly ParkingGarageLogic logic = new();
    

        public ShowParkingLotOverviewScreen()
        {
            InitializeComponent();

        }

        //Den skapade knappen ska kunna visa parkeringsplatsens innehåll
        private void CreateParkingLotInformationButton_Click(object sender, EventArgs e)
        {
            if (sender is Button vehicleButton)
            {

                //Visar knappens textinnehåll
                int buttonNameAsNumber = int.Parse(vehicleButton.Name);
                string textForClickableButton = logic.ShowParkingLotInformation(buttonNameAsNumber);
                MessageBox.Show(textForClickableButton);
            }

        }

        private void ShowButtonsVehicleScreen_Load(object sender, EventArgs e)
        {

            int currentParkingSpotSize = parkingGarageLimitations.GetOneIntValueFromJsonFile(8);
            int usedParkingSpotSpace = 0;
            int numberForButton = 0; 

            List<string> allVehicleTypesInCurrentParkingSpot = new();

            int parkingSpotsInTheGarage = parkingGarageLimitations.GetOneIntValueFromJsonFile(3);

        

            //TODO låta användaren lösa detta problem
            //Antalet platser beroende på maximala antalet parkeringsplatser
            int rows = parkingSpotsInTheGarage / 10;
            int columns = parkingSpotsInTheGarage / 10;









            this.VehicleTableLayoutPanel.ColumnCount = columns;
            this.VehicleTableLayoutPanel.RowCount = rows;

            //Rensa standardvärden, är skumt utan dessa
            this.VehicleTableLayoutPanel.ColumnStyles.Clear();
            this.VehicleTableLayoutPanel.RowStyles.Clear();



            //Storleken på knapparna i %, i TableLayoutPanelen
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




                    numberForButton++; //för att visa knapparna som "1" "2" "3"...osv

                    (string, int, int) HoldVehicleTypeAndAmountOfVehicles = ("", 0, numberForButton);

                    /*Räkna antalet fordonstyper med hjälp av json-värdet, räkna sedan ut om parkeringsplatsen är full.
                     etc: car(4)+car(4)=plats(8) 8=full parkering*/
                    allVehicleTypesInCurrentParkingSpot = handleParkingGarage.CountEachVehicleTypeInSelectedParkingSpot(numberForButton);
                    usedParkingSpotSpace = handleParkingGarage.UsedSpaceInSelectedParkingSpot(allVehicleTypesInCurrentParkingSpot);
                    HoldVehicleTypeAndAmountOfVehicles = handleParkingGarage.WhatKindOfVehiclesInSelectedParkingSpot(HoldVehicleTypeAndAmountOfVehicles);




                    //En ny knapp vid varje ny position
                    var CreateParkingLotInformationButton = new Button
                    {

                        //Lägger till siffror, som 1,2,3,4,5 osv till de genererade knapparna
                        Text = string.Format("{0}", numberForButton),

                        //Namnger knapparna, för att senare kunna lägga till popup-text innehåll
                        Name = string.Format("{0}", numberForButton)
                    };


                    //Lägger till knappen vid rad "x" och kolumn "y" i rutnätet.
                    this.VehicleTableLayoutPanel.Controls.Add(CreateParkingLotInformationButton, j, i);
                    CreateParkingLotInformationButton.Dock = DockStyle.Fill;

                    //Rosa knapp om full parkering
                    if (usedParkingSpotSpace.Equals(currentParkingSpotSize))
                    {
                        CreateParkingLotInformationButton.BackColor = Color.DeepPink;
                        CreateParkingLotInformationButton.Click += new EventHandler(CreateParkingLotInformationButton_Click);
                        this.VehicleTableLayoutPanel.Controls.Add(CreateParkingLotInformationButton);
                    }
                    //Om endast en fordonstyp på parkeringen
                    else if (HoldVehicleTypeAndAmountOfVehicles.Item2 == 1)
                    {
                        //Om bil måla knappen gul
                        if (HoldVehicleTypeAndAmountOfVehicles.Item1 == parkingGarageLimitations.GetOneStringValueFromJsonFile(4))
                        {
                            CreateParkingLotInformationButton.BackColor = Color.Yellow;

                            CreateParkingLotInformationButton.Click += new EventHandler(CreateParkingLotInformationButton_Click);
                            this.VehicleTableLayoutPanel.Controls.Add(CreateParkingLotInformationButton);
                        }

                        //Om motorcykel måla knappen röd
                        else if (HoldVehicleTypeAndAmountOfVehicles.Item1 == parkingGarageLimitations.GetOneStringValueFromJsonFile(5))
                        {
                            CreateParkingLotInformationButton.BackColor = Color.Red;
                            CreateParkingLotInformationButton.Click += new EventHandler(CreateParkingLotInformationButton_Click);
                            this.VehicleTableLayoutPanel.Controls.Add(CreateParkingLotInformationButton);
                        }
                    }


                    //För att rött och gult blir orange 8)
                    else if (HoldVehicleTypeAndAmountOfVehicles.Item2 >= 2)
                    {
                        CreateParkingLotInformationButton.BackColor = Color.Orange;
                        CreateParkingLotInformationButton.Click += new EventHandler(CreateParkingLotInformationButton_Click);
                        this.VehicleTableLayoutPanel.Controls.Add(CreateParkingLotInformationButton);
                    }


                }



            }
        }


        private void InfoButton_Click(object sender, EventArgs e)
        {
            InfoParkingLotColoursScreen infoParkingLot = new();
            infoParkingLot.Show(this);
        }
    }
}




                

