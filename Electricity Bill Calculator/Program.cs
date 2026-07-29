using System;

namespace Electricity_Bill_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Customer Type (Residential/Commercial): ");
                string customerType = Console.ReadLine().Trim().ToLower();

                Console.Write("Units Consumed: ");

                if (!double.TryParse(Console.ReadLine(), out double units))
                {
                    throw new InvalidInputException("Invalid units.");
                }

                if (units < 0)
                {
                    throw new InvalidInputException("Units cannot be negative.");
                }

                Console.Write("Rate Per Unit: ");

                if (!double.TryParse(Console.ReadLine(), out double rate))
                {
                    throw new InvalidInputException("Invalid rate.");
                }

                if (rate < 0)
                {
                    throw new InvalidInputException("Rate cannot be negative.");
                }

                Console.Write("Fixed Charges: ");

                if (!double.TryParse(Console.ReadLine(), out double fixedCharges))
                {
                    throw new InvalidInputException("Invalid fixed charges.");
                }

                if (fixedCharges < 0)
                {
                    throw new InvalidInputException("Fixed charges cannot be negative.");
                }

                IBillCalculator customer;

                if (customerType == "residential")
                {
                    customer = new Residential(units, rate, fixedCharges);
                }
                else if (customerType == "commercial")
                {
                    customer = new Commercial(units, rate, fixedCharges);
                }
                else
                {
                    throw new InvalidInputException("Invalid customer type.");
                }

                double bill = Math.Round(customer.CalculateBill(), 2);

                Console.WriteLine($"Total Bill = {bill}");
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}