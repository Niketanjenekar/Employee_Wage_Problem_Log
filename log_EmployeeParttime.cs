﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log_EmployeeWageProblem
{
    internal class log_EmployeeParttime
    {
        public void Employeeparttime()
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int Emp_Hrs = 0;
            int Emp_Wage = 0;

            Random random = new Random();

            int EmpCheck = random.Next(3);

            if (EmpCheck == IS_FULL_TIME)
            {
                Emp_Hrs = 8;
                Console.WriteLine("Employee is Present");

            }
            else if (EmpCheck == IS_PART_TIME)
            {
                Emp_Hrs = 4;
            }
            else
            {
                Emp_Hrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            Emp_Wage = Emp_Hrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("Employee Daily wage is : " + Emp_Wage);
        }
    }
}
