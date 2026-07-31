using System;

namespace Bank_Balance
{
    public class Program
    {
        static void Main(string[] args)
        {
            double openingBalance;
            double deposits;
            double withdrawals;

            try
            {
                Console.Write("Opening Balance : ");
                openingBalance = double.Parse(Console.ReadLine());

                if (openingBalance < 0)
                {
                    throw new InvalidInputException("Opening balance cannot be negative.");
                }

                Console.Write("Deposits : ");
                deposits = double.Parse(Console.ReadLine());

                if (deposits < 0)
                {
                    throw new InvalidInputException("Deposits cannot be negative.");
                }

                Console.Write("Withdrawals : ");
                withdrawals = double.Parse(Console.ReadLine());

                if (withdrawals < 0)
                {
                    throw new InvalidInputException("Withdrawals cannot be negative.");
                }

                double availableBalance = openingBalance + deposits;

                if (withdrawals > availableBalance)
                {
                    throw new InvalidInputException("Withdrawal amount exceeds available balance.");
                }

                double finalBalance = availableBalance - withdrawals;

                Console.WriteLine($"Final Balance : {Math.Round(finalBalance, 2)}");
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