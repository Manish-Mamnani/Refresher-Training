
namespace Shipping_Calculator
{
    public class StandardPackage : IShippingCalculator
    {
        public double Weight { get; set; }
        public double Distance { get; set; }

        public StandardPackage(double weight, double distance)
        {
            Weight = weight;
            Distance = distance;
        }

        public double CalculateShippingCost()
        {
            return Weight * Distance * 2;
        }
    }
}