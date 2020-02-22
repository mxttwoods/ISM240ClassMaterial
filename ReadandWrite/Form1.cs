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

namespace ReadandWrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //declare variables 

            String name;

            StreamReader studentFile;
            studentFile = File.OpenText("student_list.txt");
            for (int count = 0; count < 5; count++)
            {
                name = studentFile.ReadLine();
                //add to list box on form 
                studentListBox.Items.Add(name);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //declare variables 

            String name;

            StreamReader studentFile;
            studentFile = File.OpenText("student_list.txt");
            while (!studentFile.EndOfStream)
            {
                name = studentFile.ReadLine();
                //add to list box on form 
                studentListBox.Items.Add(name);
            }
            //close connection
            studentFile.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StreamWriter nameFile;
            nameFile = File.AppendText("student_list.txt");
            nameFile.WriteLine("Bob");
            //close connection
            nameFile.Close(); 
        }
    }
}
