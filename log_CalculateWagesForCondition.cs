using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationalProblem
{
    internal class CalculateWagesForCondition
    {
        public static void WagesTillConditionIsReached()
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int Employee_Rate_per_Hour = 20;
            int Total_Number_of_Days = 20;
            int Total_Number_of_Hours = 100;
            int Emp_Wage = 0;
            int Emp_Hrs = 0;

            Random random = new Random();

            int Emp_Check = random.Next();

            if (Emp_Check == IS_FULL_TIME)
            {
                Emp_Hrs = 8;
                Console.WriteLine("Employee is Present");

            }
            else if (Emp_Check == IS_PART_TIME)
            {
                Emp_Hrs = 4;
                Console.WriteLine("Employee is Present for Part Time");
            }
            else
            {
                Emp_Hrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            Emp_Wage = Emp_Hrs * Employee_Rate_per_Hour * Total_Number_of_Days;

            Console.WriteLine("Employee Monthly wage is : " + Emp_Wage + " Rupees");

        }
    }
}
