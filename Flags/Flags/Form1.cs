using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class Flags : Form
    {
        public Flags()
        {
            InitializeComponent();
        }

        private void Flags_Load(object sender, EventArgs e)
        {

        }

        private void name(object sender, EventArgs e)
        {
            // Display the answer
            countryLabel.Text = "Finland";
        }

        private void name1(object sender, EventArgs e)
        {
            // Display the answer
            countryLabel.Text = "France";
        }

        private void name3(object sender, EventArgs e)
        {
            // Display the answer
            countryLabel.Text = "Germany";
        }
    }
}
