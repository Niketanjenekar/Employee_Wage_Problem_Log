using EmployeeWageComputationalProblem;

namespace log_EmployeeWageProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logging Employee Wage Problem");

            //log_EmployeeCheck attendence = new log_EmployeeCheck();
            //attendence.EmployeeCheck();

            //log_EmployeedailyWageProblem Wage = new log_EmployeedailyWageProblem();
            //Wage.DailyEmployeeWage();

            //log_EmployeeParttime employeeParttime = new log_EmployeeParttime();
            //employeeParttime.Employeeparttime();

            //log_EmployeeWageUsingSwitchCase Wageusingswitchcase = new log_EmployeeWageUsingSwitchCase();
            //Wageusingswitchcase.EmployeeWageSwitchCase();

            //log_CalculatingWagesForaMonth Monthlywage = new log_CalculatingWagesForaMonth();
            //Monthlywage.WagesforMonth();

            //log_CalculateWagesForCondition wagesForCondition = new log_CalculateWagesForCondition();
            //wagesForCondition.WagesTillConditionIsReached();

            //log_EmployeeWageUseCase7.EmployeeWageUseCase7();

            //log_EmployeeWageUseCase7 obj = new log_EmployeeWageUseCase7();
            //obj.EmployeeWageUseCase7();


            //EmpWageforMultipleCompanies_UseCase8.EmployeeWageUC8("Dmart", 20, 10, 90);
            //EmpWageforMultipleCompanies_UseCase8.EmployeeWageUC8("Reliance", 40, 35, 80);


            SavingMultipleCompany_Usecase9 savingmultiple = new SavingMultipleCompany_Usecase9();
            Console.WriteLine("Enter the company Name : \n1. Company1\n2.Comany2\n3.Company3");
            int company = Convert.ToInt32(Console.ReadLine());
            switch (company)
            {
                case 1:
                    savingmultiple.EmpWager1();
                    savingmultiple.EmployeeWageUC9();
                    break;
                case 2:
                    savingmultiple.EmpWager2();
                    savingmultiple.EmployeeWageUC9();
                    break;
                case 3:
                    savingmultiple.EmpWager3();
                    savingmultiple.EmployeeWageUC9();
                    break;
                default:
                    Console.WriteLine("The company you entered is not correct");
                    break;

            }
            
        }
    }
}