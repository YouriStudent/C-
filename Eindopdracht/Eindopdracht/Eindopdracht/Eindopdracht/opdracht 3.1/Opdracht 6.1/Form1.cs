using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Opdracht_6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string query = @"   SELECT EmployeeID, LastName, FirstName, Title 
                                FROM Employees
                                ORDER BY LastName";
            string connectionSTR = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DataSet result = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionSTR);
            adapter.Fill(result);
            label1.Text = String.Empty;
            foreach(DataRow row in result.Tables[0].Rows)
            {
                label1.Text += String.Format("{0} {1}\n", row["FirstName"], row["LastName"]);
            }
        }
    }
}
