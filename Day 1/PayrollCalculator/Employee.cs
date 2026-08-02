using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCalculatorSystem
{
    public class Employee
    {
        public string? Name { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }

        public Employee(string name, decimal hoursWorked, decimal hourlyRate)
        {
            this.Name = name;
            this.HoursWorked = hoursWorked;
            this.HourlyRate = hourlyRate;
        }

    }
}
