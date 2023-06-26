using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_BasicProgrammingConstruct
{
    public class WhileLoopStetment
    {
        public void FlipCoinGame()
        {
            int playTime = 20;
            int ram = 0;
            int sham = 1;
            int head = 0, tail = 0;
            Random random = new Random();
            while (playTime > 0)
            {
                int tos = random.Next(2);
                if (tos == ram)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
                playTime--;
            }
            if (head > tail)
            {
                Console.WriteLine($" Ram's Pt: [{head}] > Sham's Pt: [{tail}] so, Ram is winner");
            }
            else if (tail > head)
            {
                Console.WriteLine($"Ram's Pt: [{head}] < Sham's Pt: [{tail}] so, Sham is winner");
            }
            else
            {
                Console.WriteLine($"Ram's Pt: [{head}] == Sham's Pt: [{tail}] so,Both Player point are same so, Play again");
            }
        }
        public void Reverse_World()
        {
            Console.WriteLine("Enter the String To Revers");
            string str = Console.ReadLine();
            int len = str.Length;
            string rev = "";
            while (len > 0)
            {
                rev += str[len - 1];
                len--;
            }
            Console.WriteLine("Reverse string is : " + rev);
        }
    }
}
