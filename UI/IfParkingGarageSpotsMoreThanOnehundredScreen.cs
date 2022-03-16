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
    public partial class IfParkingGarageSpotsMoreThanOnehundredScreen : Form
    {
        ParkingGarageLogic parkingGarageLogic = new();

        public IfParkingGarageSpotsMoreThanOnehundredScreen()
        {
            InitializeComponent();
        }


        private void IfParkingGarageSpotsMoreThanOnehundredScreen_Load(object sender, EventArgs e)
        {

            string carNumberPlate = "";
            string motorcycleNumberPlate = "";
          //  string previousEntryMC = "";
          //  string previousEntryCar = "";
            int currentParkingSpotWithNumberPlate = 0;

            for (int i = 0; i < 10; i++)
            {
                List<object> test = new();

                carNumberPlate = parkingGarageLogic.PresentVehicles(carNumberPlate, currentParkingSpotWithNumberPlate, "Car");
                motorcycleNumberPlate = parkingGarageLogic.PresentVehicles(motorcycleNumberPlate, currentParkingSpotWithNumberPlate, "Motorcycle");
                test.Add(motorcycleNumberPlate);

                currentParkingSpotWithNumberPlate += 2; //jaha

                //dataGridView1 row = (dataGridView1)dataGridView1.Rows[0].Clone();
                //row.Cells[0].Value = carNumberPlate;
                //numberPlateDataGridViewTextBoxColumn = (DataGridViewTextBoxColumn)test[0];
                //parkingSpotDataGridViewTextBoxColumn = (DataGridViewTextBoxColumn)test[1];




            }
        }

        private (string text, string text2) EmptyTheTexts(string text, string text2)
        {
            text = "";
            text2 = "";
            return (text, text2);
        }

     
    }
}