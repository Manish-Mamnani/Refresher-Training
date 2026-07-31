namespace Retail_Store_App
{
    public class Program
    {
        public static void Main(string[] args)
        { 

            try
            {
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (price <= 0)
                {
                    throw new NegativeInputException("Price cannot be less than or equal to 0.");
                }

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                if (quantity <= 0)
                {
                    throw new NegativeInputException("Quanity cannot be less than or equal to 0.");
                }

                Console.Write("Discount: ");
                int discount = int.Parse(Console.ReadLine());

                if(discount < 0)
                {
                    throw new NegativeInputException("Discount cannot be negative.");
                }

                double subTotal = price * quantity;
                double discountAmount = (subTotal * discount)/100;
                double payableAmount = subTotal - discountAmount;

                Console.WriteLine($"Sub Total : {Math.Round(subTotal,2)}");
                Console.WriteLine($"Discount Amount : {Math.Round(discountAmount,2)}");
                Console.WriteLine($"Payable Amount : {Math.Round(payableAmount,2)}");

            }
            catch(NegativeInputException ex)
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