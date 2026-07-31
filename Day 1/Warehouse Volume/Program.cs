using System;

namespace Warehouse_Volume
{
    public class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double height;

            try
            {
                Console.Write("Length : ");
                length = double.Parse(Console.ReadLine());

                if (length <= 0)
                {
                    throw new InvalidInputException("Enter a valid length.");
                }

                Console.Write("Width : ");
                width = double.Parse(Console.ReadLine());

                if (width <= 0)
                {
                    throw new InvalidInputException("Enter a valid width.");
                }

                Console.Write("Height : ");
                height = double.Parse(Console.ReadLine());

                if (height <= 0)
                {
                    throw new InvalidInputException("Enter a valid height.");
                }

                double volume = Math.Round(length * width * height, 2);

                Console.WriteLine($"Volume : {volume}");
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