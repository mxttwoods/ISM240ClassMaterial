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

        private void Close(object sender, MouseEventArgs e)
        {
            this.Close()
        }


        private void Focus(object sender, MouseEventArgs e)
        {
            celsiusTextBox.Focus();
        }

        private void Focus(object sender, EventArgs e)
        {
            celsiusTextBox.Focus();
        }
    }
}
