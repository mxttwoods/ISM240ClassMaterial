using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingScale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AButton_Click(object sender, EventArgs e)
        {

            // Display the answer
            label.Text = "93-100%";
        }

        private void AminusButton_Click(object sender, EventArgs e)
        {
            // Display the answer
            label.Text = "90-92%";
        }

        private void Bplusbutton_Click(object sender, EventArgs e)
        {
            // Display the answer
            label.Text = "87 – 89%";
        }

        private void BButton_Click(object sender, EventArgs e)
        {
            // Display the answer
            label.Text = "83 – 86%";
        }

        private void BminusButton_Click(object sender, EventArgs e)
        {
            // Display the answer
            label.Text = "80 – 82%";
        }

        private void CplusButton_Click(object sender, EventArgs e)
        {
            // Display the answer
            label.Text = "77 – 79%";
        }

        private void Cbutton_Click(object sender, EventArgs e)
        {
            // Display the answer
            label.Text = "73 – 76%";
        }

        private void CminusButton_Click(object sender, EventArgs e)
        {
            // Display the answer
            label.Text = "70 – 72%";
        }

        private void FButton_Click(object sender, EventArgs e)
        {
            // Display the answer
            label.Text = "< 70%";
        }
    }
}
