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
        public void Eligible_For_Admission()
        {
            Console.WriteLine("Insert the marks of Math ");
            int math = int.Parse(Console.ReadLine());           //>=65
            Console.WriteLine("Insert the marks of Physics ");
            int phy = int.Parse(Console.ReadLine());            //>=55
            Console.WriteLine("Insert the marks of Chemistry");
            int chem = int.Parse(Console.ReadLine());          //>=50

            if ((math + phy + chem) >= 180)
            {
                Console.WriteLine($" total marks is : {(math + phy + chem)} so, Student is eligible for admission");
            }
            else if ((math + chem) >= 140)
            {
                Console.WriteLine($"total marks is : {(math + chem)} so, Student is eligible for admission");
            }
            else if ((math + phy >= 140))
            {
                Console.WriteLine($"total marks is : {(math + phy)} so, Student is eligible for admission");
            }
            else
            {
                Console.WriteLine($"total marks is : {(math + phy + chem)} so, Student is not eligible for admission");
            }
        }
    }
}
