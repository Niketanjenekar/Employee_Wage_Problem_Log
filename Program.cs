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


            EmpWageforMultipleCompanies_UseCase8.EmployeeWageUC8("Dmart", 20, 10, 90);
            EmpWageforMultipleCompanies_UseCase8.EmployeeWageUC8("Reliance", 40, 35, 80);


        }
    }
}