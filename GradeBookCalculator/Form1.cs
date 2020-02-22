using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GradeBookCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        { try
            {

                //declare variables 
                int score;

                StreamReader inputFile;
                inputFile = File.OpenText("Exam_scores.txt");

                //read 

                while (!inputFile.EndOfStream)
                {
                    score = int.Parse(inputFile.ReadLine());

                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
