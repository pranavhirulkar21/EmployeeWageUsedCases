using System;

namespace UsedCases
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;

            Random ran = new Random();

            int empCheck = ran.Next(0, 3);

            switch(empCheck)
            {
                case IS_PART_TIME:
                    Console.WriteLine("Calculating part-time wages : ");
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    Console.WriteLine("Calculating full-time wages : ");
                    empHrs = 8;
                    break;
                default:
                    Console.WriteLine("No working employee : ");
                    empHrs = 0;
                    break;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : "+empWage);
        }
    }
}
