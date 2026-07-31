namespace Body_Mass_Index
{
    public class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;
            try
            {
                Console.Write("Weight : ");
                weight = double.Parse(Console.ReadLine());

                if(weight <= 0)
                {
                    throw new InvalidInputException("Enter a valid weight value");
                }

                Console.Write("Height : ");
                height = double.Parse(Console.ReadLine());

                if (height <= 0)
                {
                    throw new InvalidInputException("Enter a valid height value");
                }

                double bmi = Math.Round(weight * (height * height));

                Console.WriteLine($"BMI : {bmi}");

                if (bmi < 18.5)
                {
                    Console.WriteLine("Category: Underweight");
                }
                else if (bmi < 25)
                {
                    Console.WriteLine("Category: Normal weight");
                }
                else if (bmi < 30)
                {
                    Console.WriteLine("Category: Overweight");
                }
                else if (bmi < 35)
                {
                    Console.WriteLine("Category: Obesity Class I");
                }
                else if (bmi < 40)
                {
                    Console.WriteLine("Category: Obesity Class II");
                }
                else
                {
                    Console.WriteLine("Category: Obesity Class III");
                }

            }
            catch(InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}