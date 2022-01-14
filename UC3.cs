using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageDay9
{
    class UC3
    {
        public void PartTimeEmpWage()
        {
            int PartTime = 1;
            int FullTime = 2;
            int EmpRatePerHr = 20;
            int EmpHr = 0;
            int EmpWage = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3);
            if (EmpCheck == PartTime)
                EmpHr = 4;
            else if (EmpCheck == FullTime)
                EmpHr = 8;
            //else
            //empHrs = 0;
            EmpWage = EmpHr * EmpRatePerHr;
            Console.WriteLine("Emp Wage: " + EmpWage);
            Console.ReadKey();
        }

    }
}
