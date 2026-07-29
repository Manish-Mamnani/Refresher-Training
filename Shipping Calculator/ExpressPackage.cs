
namespace Shipping_Calculator
{
    public class ExpressPackage : IShippingCalculator
    {
        public double Weight { get; set; }
        public double Distance { get; set; }

        public ExpressPackage(double weight, double distance)
        {
            Weight = weight;
            Distance = distance;
        }

        public double CalculateShippingCost()
        {
            return Weight * Distance * 3.5;
        }
    }
}