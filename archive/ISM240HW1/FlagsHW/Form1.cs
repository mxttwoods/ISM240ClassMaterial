using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagsHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void UsaPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "USA";
        }

        private void UkPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "UK";
        }

        private void CanadaPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Canada";
        }

        private void CountryLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
