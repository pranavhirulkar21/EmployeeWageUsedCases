using System;

namespace UsedCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_PART_TIME = 0;
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;

            Random ran = new Random();

            int empCheck = ran.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Calculating Part-Time Wages : ");
                empHrs = 4;   
            }
            else if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Calculating Full-Time Wages : ");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is not working : ");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : "+empWage);
        }
    }
}
