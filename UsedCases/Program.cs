﻿using System;

namespace UsedCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random ran = new Random();

            int empCheck = ran.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present!!!");
            }
            else
            {
                Console.WriteLine("Employee is Absent!!!");
            }
        }
    }
}
