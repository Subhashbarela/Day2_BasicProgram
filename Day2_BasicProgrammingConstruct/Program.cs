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
                Console.WriteLine("1: Selection Stetment \n2: Else If Ladder Statement \n3: Switch case Stetment \n4: for loop Stetment ");
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
                    case 2:
                        {
                            ElseIfLadderClass ladder=new ElseIfLadderClass();
                           // ladder.LargestNumber();
                            ladder.Eligible_For_Admission();
                            break;
                        } 
                    case 3:
                        {
                            SwitchCaseStetment switchCase =new SwitchCaseStetment();
                           // switchCase.WeekDay();
                            switchCase.Arithmatic_Operation();
                            break;
                        }
                    case 4:
                        {
                            ForLoopStetment forLoop = new ForLoopStetment();
                           // forLoop.Print_Table();
                           // forLoop.Sum_OfSquare();
                           // forLoop.Factorial_Number();
                            forLoop.Factorial_Taking_Range();
                           
                            break;
                        }
                    default:
                        Console.WriteLine("Please insert valid input");
                        break;
                }
                Console.WriteLine("\nDo you want to continue ..?");
                ans = Console.ReadLine();
            } while (ans == "yes" || ans == "y");
            Console.ReadLine();
        }   
    }
}
