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
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<Student> studentList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            StreamReader dataImport = new StreamReader(@"C:\Users\gebruiker\Desktop\data.csv");

            
            while (!dataImport.EndOfStream)
            {
                String currentLine = dataImport.ReadLine();
                String[] currentArray = currentLine.Split(';');
                Student myStudent = new Student(currentArray[0], currentArray[1], int.Parse(currentArray[2]));
                studentList.Add(myStudent);
                label1.Text += currentArray[1];
            }
            
        }

        private void sortName_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < studentList.Count - 1; j++)
            {
                for (int i = 0; i < studentList.Count - 1; i++)
                {
                    int i2 = i + 1;
                    Student student1 = this.studentList[i];
                    Student student2 = this.studentList[i2];
                    String s1 = student1.getName().ToLower();
                    String s2 = student2.getName().ToLower();
                    if (s1[0] > s2[0])
                    {
                        studentList[i] = student2;
                        studentList[i2] = student1;
                    }
                }
            }
            label1.Text = "";
            foreach (Student student in this.studentList)
            {
                label1.Text += student;
            }
        }

        private void sortAge_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < studentList.Count - 1; j++)
            {
                for (int i = 0; i < studentList.Count - 1; i++)
                {
                    int i2 = i + 1;
                    Student student1 = this.studentList[i];
                    Student student2 = this.studentList[i2];
                    int s1 = student1.getAge();
                    int s2 = student2.getAge();
                    if (s1 > s2)
                    {
                        studentList[i] = student2;
                        studentList[i2] = student1;
                    }
                }
            }
            label1.Text = "";
            foreach (Student student in this.studentList)
            {
                label1.Text += student;
            }
        }

        // csv inlezen

        // Knoppen toevoegen

        // Sorteer algoritme


    }
}
