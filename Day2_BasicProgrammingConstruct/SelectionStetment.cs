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
        public void CheckEvenOrOdd()
        {
            Console.WriteLine("Enter the number to check even or odd");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even number");
            }
            else
            {
                Console.WriteLine($"{num} is odd number");
            }
        }
        public void VotingSystem()
        {
            Console.WriteLine("Enter the age to check eligible for vote or not");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Candidate is Eligible for vote");
            }
            else
            {
                Console.WriteLine("Candidate is  not Eligible for vote");
            }
        }
    }
}
