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
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }


        private void LoadingScreen_Shown(object sender, EventArgs e)
        {
            PresentTheParkingGarageScreen presentTheParkingGarageScreen = new();
            presentTheParkingGarageScreen.Show(this);
            this.Hide();
        }

      
    }
}
