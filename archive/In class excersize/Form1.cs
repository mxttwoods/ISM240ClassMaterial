using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_class_excersize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // create student object 

            Student std1 = new Student();

            // set properties 

            std1.LastName = "Woods";
            std1.FirstName = "Matthew";
                std1.StdId = "1234";

            //get values for message box 

            MessageBox.Show("FirstName: " + std1.FirstName);
            MessageBox.Show("LastName: " + std1.LastName);
            MessageBox.Show("StudentID: " + std1.StdId);


            //create student object using paramiterized constructor
            Student std2 = new Student("1001");
            MessageBox.Show("Student ID: "+ std2.StdId);

            //declare object array
            Student[] studentArray = new Student[2];

            //store student object
            studentArray[0] = std1;
            studentArray[1] = std2;

            //add student id's to listbox 
            for(int index=0; index<studentArray.Length; index++)
            {
                studentIdListBox.Items.Add(studentArray[index].StdId);
            }
        }
    }
}
