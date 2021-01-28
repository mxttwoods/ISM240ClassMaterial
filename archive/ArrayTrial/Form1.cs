using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayTrial
{
    public partial class Form1 : Form
    {
        private object outputlistBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare an array 

            int[] intArray;
            intArray = new int[6];

            //store values in a array with a for loop
            for (int index=0; index< intArray.Length; index++)
            {
                intArray[index] = index * index; 
            }

            //display values in listbox 
            for (int index = 0; index < intArray.Length; index++)
            {
                listBox.Items.Add(intArray[index]);
            }

        }
    }
}
