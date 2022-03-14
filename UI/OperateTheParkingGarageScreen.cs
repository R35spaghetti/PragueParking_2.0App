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

    public partial class OperateTheParkingGarageScreen : Form
    {
       readonly IntroScreen introScreen = new();

        public OperateTheParkingGarageScreen()
        {
            InitializeComponent();
        }


        private void OperateTheParkingGarageScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            introScreen.Show();
        }
    }
}
