using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Eindopdracht
{
    public partial class Home : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gebruiker\Downloads\Test\Eindopdracht\Eindopdracht\Database2.mdf;Integrated Security=True";
        
        public Home()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();

            //Loading data
            string str = string.Empty;
            for (int i = 0; i < 100; i++)
            {
                str += i.ToString();//Init data, only for demo
                Thread.Sleep(1);
            }
            //Complete
            t.Abort();
            InitializeComponent();
        }
        void Splash()
        {
            //Open a splash screen form
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.Font = new Font("Time New Romans", 7);
            frm.AppName = "SuperApp";
            frm.ShowIcon = false;
            frm.ShowInTaskbar = false;
            Application.Run(frm);
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.Show();
        }

        private void NewEmployee_click(object sender, EventArgs e)
        {
            string name = employeeName.Text;
            decimal number = employeeNumber.Value;
            DateTime birthDate = dateTimeBirthDate.Value;
            DateTime employmentDate = dateTimeEmployment.Value;

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Employee (name, number, start_date, birthday) VALUES(@name, @number, @start_date, @birthday)";


                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@number", number);
                command.Parameters.AddWithValue("@start_date", employmentDate);
                command.Parameters.AddWithValue("@birthday", birthDate);

                connection.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    this.errorMSG.Text = "Failed to put data in the database";
                }


                connection.Close();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            this.Show();
        }
        private void Home_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }
        private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.database2DataSet.Employee);
            // Set current window to activate
            this.Activate();

            //  String myrow = "";
            //using (SqlConnection connection = new SqlConnection(this.connectionString))
            //using (SqlCommand command = new SqlCommand("select * from [Employee]", connection))
            //{
            //    connection.Open();
            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        // Check is the reader has any rows at all before starting to read.
            //        if (reader.HasRows)
            //        {
            //            // Read advances to the next row.
            //            while (reader.Read())
            //            {
            //                myrow += String.Format("{0}, {1}\n", reader.GetString(reader.GetOrdinal("name")), reader.GetString(reader.GetOrdinal("number")));
            //            }
            //        }
            //    }
            //}
            //this.employees.Text = myrow;
        }




        private void werknemer_toevoegen_Click(object sender, EventArgs e)
        {

        }

        // Context Menu
        private void ContextMenuAbout_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.Show();
        }

        private void ContextMenuOpen_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void ContextMenuClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void employeeName_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void werknemerToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Show();
        }
    }
}

//Reader CSV
// 
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.IO;
//namespace WindowsFormsApp2
//{
//    public partial class Form1 : Form
//    {
//        List<Student> studentList = new List<Student>();
//        public Form1()
//        {
//            InitializeComponent();
//            StreamReader dataImport = new StreamReader(@"C:\Users\gebruiker\Desktop\data.csv");


//            while (!dataImport.EndOfStream)
//            {
//                String currentLine = dataImport.ReadLine();
//                String[] currentArray = currentLine.Split(';');
//                Student myStudent = new Student(currentArray[0], currentArray[1], int.Parse(currentArray[2]));
//                studentList.Add(myStudent);
//                label1.Text += currentArray[1];
//            }

//        }

//        private void sortName_Click(object sender, EventArgs e)
//        {
//            for (int j = 0; j < studentList.Count - 1; j++)
//            {
//                for (int i = 0; i < studentList.Count - 1; i++)
//                {
//                    int i2 = i + 1;
//                    Student student1 = this.studentList[i];
//                    Student student2 = this.studentList[i2];
//                    String s1 = student1.getName().ToLower();
//                    String s2 = student2.getName().ToLower();
//                    if (s1[0] > s2[0])
//                    {
//                        studentList[i] = student2;
//                        studentList[i2] = student1;
//                    }
//                }
//            }
//            label1.Text = "";
//            foreach (Student student in this.studentList)
//            {
//                label1.Text += student;
//            }
//        }

//        private void sortAge_Click(object sender, EventArgs e)
//        {
//            for (int j = 0; j < studentList.Count - 1; j++)
//            {
//                for (int i = 0; i < studentList.Count - 1; i++)
//                {
//                    int i2 = i + 1;
//                    Student student1 = this.studentList[i];
//                    Student student2 = this.studentList[i2];
//                    int s1 = student1.getAge();
//                    int s2 = student2.getAge();
//                    if (s1 > s2)
//                    {
//                        studentList[i] = student2;
//                        studentList[i2] = student1;
//                    }
//                }
//            }
//            label1.Text = "";
//            foreach (Student student in this.studentList)
//            {
//                label1.Text += student;
//            }
//        }

//        // csv inlezen

//        // Knoppen toevoegen

//        // Sorteer algoritme


//    }
//}

