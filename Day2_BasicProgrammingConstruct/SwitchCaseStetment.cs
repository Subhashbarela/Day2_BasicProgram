using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_BasicProgrammingConstruct
{
    public class SwitchCaseStetment
    {
        public void WeekDay()
        {
            Console.WriteLine("insert the number to find Day of week");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is Sunday");
                    break;
                case 2:
                    Console.WriteLine("Today is Monday");
                    break;
                case 3:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Today is Thursday");
                    break;
                case 6:
                    Console.WriteLine("Today is Friday");
                    break;
                case 7:
                    Console.WriteLine("Today is Saturday");
                    break;
                default:
                    Console.WriteLine("Please insert valid number");
                    break;
            }
        }
        public void Arithmatic_Operation()
        {
            Console.WriteLine("Enter the num one");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num two");
            int numTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("1: Addition \n2: Substraction \n3: Multiplication \n4 Division");
            Console.WriteLine("insert the choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        int result = numOne + numTwo;
                        Console.WriteLine("Addition of two nmber is: " + result);
                        break;
                    }
                case 2:
                    {
                        int result = numOne - numTwo;
                        Console.WriteLine("Substraction of two nmber is: " + result);
                        break;
                    }
                case 3:
                    {
                        int result = numOne * numTwo;
                        Console.WriteLine("Multiplication of two nmber is: " + result);
                        break;
                    }
                case 4:
                    {
                        int result = numOne / numTwo;
                        Console.WriteLine("Division of two nmber is: " + result);
                        break;
                    }
                default:
                    Console.WriteLine("Enter valid input");
                    break;
            }
        }
    }
}
