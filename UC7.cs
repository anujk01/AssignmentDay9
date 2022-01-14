using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageDay9
{
    class UC7
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        public const int EmpRatePerHr = 20;
        public const int NumWorkingDays = 2;
        public const int MaxHrInMonth = 10;
        public static int ComputeEmpWages()
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorking = 0;
            //Computation
            while (totalEmpHrs <= MaxHrInMonth && totalWorking < NumWorkingDays)
            {
                totalWorking++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case PartTime:
                        empHrs = 4;
                        break;
                    case FullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + totalWorking + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EmpRatePerHr;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
           ComputeEmpWages();
        }
    }
}