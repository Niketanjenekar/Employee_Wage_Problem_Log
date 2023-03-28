using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log_EmployeeWageProblem
{
    internal class Usecase13_PrintTotalWage
    {
        public interface ParentComputeEmpWage
        {
            void EmployeeWageUC13();
            void PrintDailyWages();
        }

        public class CompanyEmpWage : ParentComputeEmpWage
        {
            List<int> DailyWages = new List<int>();
            public const int IS_FULL_TIME = 1;
            public const int IS_PART_TIME = 2;
            public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            public string CompanyName;
            public int Emp_Hrs;
            public int EmpWagePerHour;
            public int WorkingDaysPerMonth;
            public int TotalWorkingHours;


            public void EmployeeWageBuilder()
            {
                Console.Write("Enter the Company Name: ");
                CompanyName = Console.ReadLine();
                Console.Write("Enter the Employee Wage Per Hour: ");
                EmpWagePerHour = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Total Working Days for an Employee in a Month: ");
                WorkingDaysPerMonth = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Total Working Hours for an Employee in a Month: ");
                TotalWorkingHours = Convert.ToInt32(Console.ReadLine());

            }


            public void EmployeeWageUC13()
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

            public void PrintDailyWages()
            {
                Console.WriteLine("Daily Wages:");
                for (int i = 0; i < DailyWages.Count; i++)
                {
                    Console.WriteLine("Day " + (i + 1) + ": " + DailyWages[i]);
                }
                Console.WriteLine("Total Wage: " + (EmpWagePerHour * Emp_Hrs * WorkingDaysPerMonth));
            }
        }


        
    }
}
