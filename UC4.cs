using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageDay9
{
    class UC4
    {
        //const
        public const int PartTime = 1;
        //public readonly int Test=12;
        public const int FullTime = 2;
        public const int EmpRatePerHr = 20;
        public void UsingSwitchCase()
        {
            //Constants
            //variables
            int EmpHr = 0;
            int EmpWage = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3);
            switch (EmpCheck)
            {
                case PartTime:
                    EmpHr = 4;
                    break;
                case FullTime:
                    EmpHr = 8;
                    break;
                default:
                    EmpHr = 0;
                    break;
            }
            EmpWage = EmpHr * EmpRatePerHr;
            Console.WriteLine("Emp Wage: " + EmpWage);
        }
    }
}
