using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht
{
    internal class Employee
    {
        private string name;
        private int employeeNr;
        private DateTime birthDate;
        private DateTime startEmployment;
        public Employee(string name, int employeeNr, DateTime birthDate, DateTime startEmployment)
        {
            this.name = name;
            this.employeeNr = employeeNr;
            this.birthDate = birthDate;
            this.startEmployment = startEmployment;
        }

        public int getDaysOff()
        {
            int freeDays = 20;
            int n = employeeNr;
            while (n >= 10)
                n /= 10;
            if (n == 1)
            {
                freeDays += 4;
            }

            if (getAge() > 55)
            {
                freeDays += 5;
            }

            if (getServiceYears() > 10)
            {
                freeDays += 3;
            }

            return freeDays;
        }

        public int getAge()
        {
            var year = DateTime.Now.Year;
            return year - birthDate.Year - 1;

        }

        public int getNr()
        {
            return employeeNr;
        }
        public int getServiceYears()
        {
            var year = DateTime.Now.Year;
            return year - startEmployment.Year - 1;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", this.employeeNr, this.name);
        }
    }

}
