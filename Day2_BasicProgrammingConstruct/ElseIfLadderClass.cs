using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_BasicProgrammingConstruct
{
    public class ElseIfLadderClass
    {
        public void LargestNumber()
        {
            Console.WriteLine("Enter the num One");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num Two");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num three");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("A is greter number");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("B is greter number");
            }
            else
            {
                Console.WriteLine("c is greter number");
            }
        }
    }
}
