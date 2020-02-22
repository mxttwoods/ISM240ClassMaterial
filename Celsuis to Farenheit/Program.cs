using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Celsius_to_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CalculateButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // declare variables
                double celsius, fahrenheit;
                // get the temperature in Celsius
                celsius = double.Parse(celsiusTextBox.Text);
                // calculate and store temperature in Fahrenheit
                fahrenheit = 1.8 * celsius + 32.0;
                // display the value in Fahrenheit
                fahrenheitLabel.Text = fahrenheit.ToString();
            }
            catch
            {
                // display an error message
                MessageBox.Show("Invalid Input");
            }

        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // clear the input and output controls
            celsiusTextBox.Text = "";
            fahrenheitLabel.Text = "";
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}