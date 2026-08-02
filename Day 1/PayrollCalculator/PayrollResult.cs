using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCalculatorSystem
{
    public class PayrollResult
    {
        public decimal RegularPay { get; set; }
        public decimal OvertimePay { get; set; }
        public decimal GrossPay { get; set; }

        public PayrollResult(decimal regularPay, decimal overtimePay, decimal grossPay)
        {
            RegularPay = regularPay;
            OvertimePay = overtimePay;
            GrossPay = grossPay;
        }
    }
}
