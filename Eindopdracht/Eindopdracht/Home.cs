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
        private Company company;
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
            company.addEmployee(employeeName.Text, employeeNumber.Value, dateTimeBirthDate.Value, dateTimeEmployment.Value);
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
            company = new Company();
            this.employeeTableAdapter.Fill(this.database2DataSet.Employee);
            // Set current window to activate
            this.Activate();
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
            Application.Exit();
        }


        private void werknemerToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Show();
        }

        private void comboBoxEmployee_DropDown(object sender, EventArgs e)
        {
            comboBoxEmployee.Items.Clear();
            foreach (Employee employee in company.GetEmployees())
            {
                comboBoxEmployee.Items.Add(employee);
            }
        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedItem = comboBoxEmployee.Items[comboBoxEmployee.SelectedIndex].ToString();
            int employeeNr = int.Parse(selectedItem.Split(' ')[0]);
            Employee employee = company.getEmployeeByNr(employeeNr);
            listBox1.Items.Clear();
            listBox1.Items.Add(String.Format("{0} heeft {1} vakantiedagen", employee, employee.getDaysOff()));
        }

  

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            OldestEmployee.Text = company.getOldestEmployee().ToString();
            AVGServiceYears.Text = company.averageServiceYears().ToString();
            TotalFreeDays.Text = company.TotalFreeDays().ToString();
        }
    }
}

