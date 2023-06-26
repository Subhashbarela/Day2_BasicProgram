using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_BasicProgrammingConstruct
{
    public class SelectionStetment
    {
        public void CheckEqualOrNot()
        {
            Console.WriteLine("Enter the num One");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num Two");
            int numTwo = int.Parse(Console.ReadLine());
            if (numOne == numTwo)
            {
                Console.WriteLine("Both number are equal");
            }
            else
            {
                Console.WriteLine("both number  are not equal");
            }
        }
    }
}
