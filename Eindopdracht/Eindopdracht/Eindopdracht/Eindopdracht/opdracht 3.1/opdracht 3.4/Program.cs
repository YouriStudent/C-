using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> productLists = new LinkedList<string>();

            productLists.AddLast("Samsung S9");
            productLists.AddLast("Iphone");
            productLists.AddLast("TV");
            

            if (productLists.Contains("TV"))
            {
                Console.WriteLine("Found TV");
            }

            string search = "Iphone";
            foreach(string product in productLists)
            {
                if(product == search)
                {
                    Console.WriteLine("Found search");
                    break;
                }
            }
        }
    }
}
