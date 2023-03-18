using EmployeeWageComputationalProblem;

namespace log_EmployeeWageProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logging Employee Wage Problem");
            
            log_EmployeeCheck attendence = new log_EmployeeCheck();
            attendence.EmployeeCheck();

        }
    }
}