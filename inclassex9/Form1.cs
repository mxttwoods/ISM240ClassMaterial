using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inclassex9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            // Main program
            // Create a Car object for a used 2001 BMW with 70,000
            // miles, priced at $15,000, with 4 doors.
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "2001";
            myCar.Mileage = 70000;
            myCar.Price = 15000;
            myCar.Doors = 4;
            // Create a Truck object for a used 2002 Toyota
            // pickup with 40,000 miles, priced at $12,000,
            // with four wheel drive.
            Pickup myPickup = new Pickup();
            myPickup.Make = "Toyota";
            myPickup.Model = "2002";
            myPickup.Mileage = 40000;
            myPickup.Price = 12000;
            myPickup.Drive = "Four Wheel Drive";
            // Display data about the car.
            MessageBox.Show(myCar.Model + " " + myCar.Make + " with " +
            myCar.Mileage + " miles, priced at " +
            myCar.Price.ToString("c") + ", with " + myCar.Doors +
            " doors.");
            // Display data about the pickup truck.
            MessageBox.Show(myPickup.Model + " " + myPickup.Make +
            " with " + myPickup.Mileage + " miles, priced at " +
            myPickup.Price.ToString("c") + ", with " +
            myPickup.Drive);
        }
    }
}
