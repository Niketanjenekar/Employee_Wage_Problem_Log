using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log_EmployeeWageProblem
{
    internal class EmpWageforMultipleCompanies_UseCase8
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        

        public static int EmployeeWageUC8(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int Emp_Hrs = 0;
            int Emp_Wage = 0;

            Random random = new Random();

            int Emp_check = random.Next(3);

            switch (Emp_check)
            {
                case IS_FULL_TIME:
                    Emp_Hrs = 8;
                    Console.WriteLine("The Employee is Present");
                    break;
                case IS_PART_TIME:
                    Emp_Hrs = 4;
                    Console.WriteLine("The Employee is Present for Part Time");
                    break;
                default:
                    Emp_Hrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;


            }
            Emp_Wage = Emp_Hrs * empRatePerHour * numOfWorkingDays;
            Console.WriteLine("The Employee Wage for " + company + " is :" + Emp_Wage + " Rupees");
            return Emp_Wage;
        }


    }
}
