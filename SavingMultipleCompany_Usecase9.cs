using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log_EmployeeWageProblem
{
    public class SavingMultipleCompany_Usecase9
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;


        public void EmpWager1()
        {
            empRatePerHour = 350;
            numOfWorkingDays = 10;
            maxHoursPerMonth = 200;
            Console.WriteLine("Total Company Wage: " + (empRatePerHour * maxHoursPerMonth));
        }

        public void EmpWager2()
        {
            empRatePerHour = 500;
            numOfWorkingDays = 23;
            maxHoursPerMonth = 320;
            Console.WriteLine("Total Company Wage: " + (empRatePerHour * maxHoursPerMonth));
        }
        public void EmpWager3()
        {
            empRatePerHour = 700;
            numOfWorkingDays = 16;
            maxHoursPerMonth = 376;
            Console.WriteLine("Total Company Wage: " + (empRatePerHour * maxHoursPerMonth));
        }
        public void EmployeeWageUC9()
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
            
        }
    }
       
}


