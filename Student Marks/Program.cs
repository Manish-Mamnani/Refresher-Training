using System;

namespace Student_Marks
{
    public class Program
    {
        static void Main(string[] args)
        {
            double m1, m2, m3, m4, m5;

            try
            {
                Console.Write("Subject 1 : ");
                m1 = double.Parse(Console.ReadLine());

                Console.Write("Subject 2 : ");
                m2 = double.Parse(Console.ReadLine());

                Console.Write("Subject 3 : ");
                m3 = double.Parse(Console.ReadLine());

                Console.Write("Subject 4 : ");
                m4 = double.Parse(Console.ReadLine());

                Console.Write("Subject 5 : ");
                m5 = double.Parse(Console.ReadLine());

                if (m1 < 0 || m1 > 100 ||
                    m2 < 0 || m2 > 100 ||
                    m3 < 0 || m3 > 100 ||
                    m4 < 0 || m4 > 100 ||
                    m5 < 0 || m5 > 100)
                {
                    throw new InvalidInputException("Marks should be between 0 and 100.");
                }

                double total = m1 + m2 + m3 + m4 + m5;
                double average = total / 5;
                double percentage = Math.Round((total / 500) * 100, 2);

                Console.WriteLine($"Total : {total}");
                Console.WriteLine($"Average : {average}");
                Console.WriteLine($"Percentage : {percentage}%");
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