using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageDay9
{
    class UC1
    {
        public void EmpAttendence()
        {
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == 0)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
