using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageDay9
{
    class UC5
    {
        //Constants
        public const int PartTime = 1;
        public const int FullTime = 2;
        public const int EmpRatePerHr = 20;
        public const int NumWorkingDays = 2;
        public void CalculateMonthWages()
        {

            //variables
            int EmpHr = 0;
            int EmpWage = 0;
            int TotalEmpWage = 0;
            for (int day = 0; day < NumWorkingDays; day++)
            {

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
                TotalEmpWage += EmpWage;
                Console.WriteLine("EmpWage: " + EmpWage);
            }
            Console.WriteLine("TotalEmpWage: " + TotalEmpWage);
        }
    }
}
