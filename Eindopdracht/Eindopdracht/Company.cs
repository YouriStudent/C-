using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Eindopdracht
{
    internal class Company
    {
        private string name;
        private List<Employee> employees;
        readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gebruiker\Downloads\Test\Eindopdracht\Eindopdracht\Database2.mdf;Integrated Security=True";

        public Company()
        {
            employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            using (SqlCommand command = new SqlCommand("select name, number, start_date, birthday from [Employee]", connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Check is the reader has any rows at all before starting to read.
                    if (reader.HasRows)
                    {
                        // Read advances to the next row.
                        while (reader.Read())
                        {
                            Employee employee = new Employee(reader.GetString(0), int.Parse(reader.GetString(1)), reader.GetDateTime(2), reader.GetDateTime(3));
                            employees.Add(employee);
                        }
                    }
                }
            }
        }
        public Employee addEmployee(string name, decimal number, DateTime birthDate, DateTime employmentDate)
        {

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
                catch (SqlException)
                { }


                connection.Close();
            }
            Employee employee = new Employee(name, Convert.ToInt16(number), birthDate, employmentDate);
            employees.Add(employee);
            return employee;
        }
        public Employee getOldestEmployee()
        {
            Employee oldestEmployee = null;
            int employeeAge = 0;
            foreach (Employee employee in employees)
            {
                if (employee.getAge() < employeeAge)
                {
                    oldestEmployee = employee;
                }
            }
            return oldestEmployee;

        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public int TotalFreeDays()
        {
            int totalFreeDays = 0;
            foreach (Employee employee in employees)
            {
                totalFreeDays += employee.getDaysOff();
            }
            return totalFreeDays;
        }
        public int averageServiceYears()
        {
            int total = 0;

            foreach (Employee employee in GetEmployees())
            {
                total += employee.getServiceYears();
            }
            return total / GetEmployees().Count;
        }
        public Employee getEmployeeByNr(int number)
        {
            foreach (Employee employee in employees)
            {
                if (employee.getNr() == number)
                {
                    return employee;
                }
            }
            return null;
        }

    }
}
