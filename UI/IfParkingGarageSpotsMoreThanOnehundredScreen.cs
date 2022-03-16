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
            string text = "";
            string text2 = "";
            string previousEntryMC = "";
            string previousEntryCar = "";
            int currentParkingSpot = 0;

            for (int i = 0; i < 10; i++)
            {
                text = parkingGarageLogic.PresentVehicles(text, currentParkingSpot, "Car");
                text2 = parkingGarageLogic.PresentVehicles(text2, currentParkingSpot, "Motorcycle");

                currentParkingSpot += 2;

                if (text != "" && text != previousEntryCar)
                {
                    previousEntryCar = text;

                }
          

                if (text2 != "" && text2 != previousEntryMC)
                {
                    previousEntryMC = text2;
                }


                if (text == "")
                {
                    text = text2;
                    text2 = String.Empty;
                }



                {
                    switch (i)
                    {
                        case 0:
                            textBox1.Text = text;
                            textBox2.Text = text2;
                           



                            (text,text2) = EmptyTheTexts(text, text2);
                           
                            break;

                        case 1:
                            textBox3.Text = text;
                            textBox4.Text = text2;
                            

                            (text, text2) = EmptyTheTexts(text, text2);
                            break;

                        case 2:
                            textBox5.Text = text;
                            textBox6.Text = text2;

                            (text, text2) = EmptyTheTexts(text, text2);
                            break;

                        case 3:
                            textBox7.Text = text;
                            textBox8.Text = text2;

                            (text, text2) = EmptyTheTexts(text, text2);
                           
                            break;

                        case 4:
                            textBox9.Text = text;
                            textBox10.Text = text2;
                            (text, text2) = EmptyTheTexts(text, text2);

                            break;
                            //todo


                    }

                }

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