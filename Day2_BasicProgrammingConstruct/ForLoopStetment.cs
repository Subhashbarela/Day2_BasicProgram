﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_BasicProgrammingConstruct
{
    public class ForLoopStetment
    {
        public void Print_Table()
        {
            Console.WriteLine("Insert the number to find the table");
            int num = int.Parse(Console.ReadLine());
            int table = 0;
            for (int i = 2; i <= num; i++)
            {
                Console.Write($"Table of {i} is : ");
                for (int j = 1; j <= 10; j++)
                {
                    table = i * j;
                    Console.Write(table + " ");
                }
                Console.WriteLine();

            }
        }
    }
}