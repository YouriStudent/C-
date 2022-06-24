using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.opdracht_3._1
{
    internal class Class1
    {
        delegate double MathCalculation(float value1, float value2);


        public static class Calculator

        {

            public static double AddNumbers(float value1, float value2) => value2 + value2;


            public static double DivideNumbers(float value1, float value2) => value1 / value2;

        }
    }
}
