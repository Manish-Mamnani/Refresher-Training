using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity_Bill_Calculator
{
    public class Residential : IBillCalculator
    {
        public double UnitsConsumed { get; set; }
        public double Rate { get; set; }
        public double FixedCharges { get; set; }

        public Residential(double units, double rate, double fixedCharges)
        {
            UnitsConsumed = units;
            Rate = rate;
            FixedCharges = fixedCharges;
        }
        public double CalculateBill()
        {
            return (UnitsConsumed * Rate) + FixedCharges;
        }
    }
}
