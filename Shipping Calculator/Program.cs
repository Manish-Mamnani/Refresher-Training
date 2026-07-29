// Program.cs

using System;

namespace Shipping_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Package Type (Standard/Express): ");
                string packageType = Console.ReadLine().Trim().ToLower();

                Console.Write("Weight (kg): ");

                if (!double.TryParse(Console.ReadLine(), out double weight))
                {
                    throw new InvalidInputException("Invalid weight.");
                }

                if (weight <= 0)
                {
                    throw new InvalidInputException("Weight must be greater than zero.");
                }

                Console.Write("Distance (km): ");

                if (!double.TryParse(Console.ReadLine(), out double distance))
                {
                    throw new InvalidInputException("Invalid distance.");
                }

                if (distance <= 0)
                {
                    throw new InvalidInputException("Distance must be greater than zero.");
                }

                if (weight > 10000)
                {
                    throw new InvalidInputException("Weight value is unreasonable.");
                }

                if (distance > 100000)
                {
                    throw new InvalidInputException("Distance value is unreasonable.");
                }

                IShippingCalculator shippingCalculator;

                if (packageType == "standard")
                {
                    shippingCalculator = new StandardPackage(weight, distance);
                }
                else if (packageType == "express")
                {
                    shippingCalculator = new ExpressPackage(weight, distance);
                }
                else
                {
                    throw new InvalidInputException("Invalid package type.");
                }

                double shippingCost = Math.Round(shippingCalculator.CalculateShippingCost(), 2);

                Console.WriteLine();
                Console.WriteLine($"Shipping Cost : {shippingCost}");
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Calculation overflow occurred.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}