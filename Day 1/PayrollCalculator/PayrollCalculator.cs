using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCalculatorSystem
{
    public class PayrollCalculator
    {
        public PayrollResult CalculatePay(Employee emp)
        {
            decimal extraHours = 0;
            decimal regularHours = emp.HoursWorked;
            if (emp.HoursWorked > 40)
            {
                extraHours = emp.HoursWorked - 40;
                regularHours = 40;

            }
            decimal overtimePay = extraHours * (emp.HourlyRate * (decimal)1.5);
            decimal regularPay = emp.HoursWorked * emp.HourlyRate;
            decimal grossSalary = regularPay + overtimePay;

            return new PayrollResult(regularPay, overtimePay, grossSalary);
        }

    }
}
