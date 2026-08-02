

namespace PayrollCalculatorSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Payroll Calculator");
            Console.WriteLine("------------------");

            //Input
            Console.Write("Enter Employee's Name: ");
            string? empName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(empName))
            {
                Console.WriteLine("Employee name is required.");
                return;
            }

            Console.Write("Enter Hours: ");
            string? hoursInput = Console.ReadLine();
            bool isValidHour = decimal.TryParse(hoursInput, out decimal hours);
            if (!isValidHour || hours < 0)
            {
                Console.WriteLine("Invalid Hours");
                return;
            }

            Console.Write("Enter hourly rate: ");
            string? rateInput = Console.ReadLine();
            bool isValidRate = decimal.TryParse(rateInput, out decimal rate);
            if (!isValidRate || rate < 0)
            {
                Console.WriteLine("Invalid Rate");
                return;
            }

            Employee emp = new Employee(empName, hours, rate);
            PayrollCalculator cal = new PayrollCalculator();

            PayrollResult result = cal.CalculatePay(emp);

            Console.WriteLine($"Employee Name : {emp.Name}");
            Console.WriteLine($"Regular Salary: {result.RegularPay:F2}");
            Console.WriteLine($"OverTime Salary: {result.OvertimePay:F2}");
            Console.WriteLine($"Gross Salary: {result.GrossPay:F2}");




        }
    }
}