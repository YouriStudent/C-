using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to convert to uppercase: ");
            String convert_str = Console.ReadLine();
            String uppercase_str = convert_str.ToUpper();
            Console.WriteLine(String.Format("Converted: {0}", uppercase_str));
            String test_str = Console.ReadLine();
            Console.WriteLine(test_str);
        }

    }
}
