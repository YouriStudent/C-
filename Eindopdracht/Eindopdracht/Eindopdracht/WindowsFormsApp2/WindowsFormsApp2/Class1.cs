using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Student
    {
        String nr;
        String name;
        int age;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nr">Nummer</param>
        /// <param name="name">Name</param>
        /// <param name="age">Age</param>
        public Student(String nr, String name, int age)
        {
            this.nr = nr;
            this.name = name;
            this.age = age;
        }
        public int Age { get; set; }
        public string getName()
        {
            return this.name;
        }

        public int getAge()
        {
            return this.age;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}\n", this.nr, this.name, this.age);
        }
        //public string Name { get; set; }
    }
}
