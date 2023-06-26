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
    }
}
