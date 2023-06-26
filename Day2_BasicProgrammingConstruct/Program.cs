using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_BasicProgrammingConstruct
{
    public class Program
    {
        static void Main(string[] args)
        {
            string ans = "";
            do
            {
                Console.WriteLine("1: Selection Stetment ");
                Console.WriteLine("Enter the choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            SelectionStetment selection = new SelectionStetment();
                           // selection.CheckEqualOrNot();
                          // selection.CheckEvenOrOdd();
                           selection.VotingSystem();
                            break;
                        }
                    default:
                        Console.WriteLine("Please insert valid input");
                        break;
                }
                Console.WriteLine("Do you want to continue ..?");
                ans = Console.ReadLine();
            } while (ans == "yes" || ans == "y");
            Console.ReadLine();
        }   
    }
}
