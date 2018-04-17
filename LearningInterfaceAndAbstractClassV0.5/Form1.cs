using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningInterfaceAndAbstractClassV0._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mars mars = new Mars();
            MessageBox.Show(mars.FuelNeeded());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Venus venus = new Venus();
            MessageBox.Show(venus.FuelNeeded());
        }

 private void button3_Click(object sender, EventArgs e)
        {
            /* PlanetMission planet = new PlanetMission();  //clicking this button will occur an error, because our PlaneMission declare types but value are not set. Anyway this object shoudnt be able to create
               MessageBox.Show(planet.FuelNeeded());
            */
        }
    }
    }
