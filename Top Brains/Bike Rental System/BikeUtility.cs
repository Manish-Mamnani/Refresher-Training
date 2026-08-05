using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Rental_Assignment
{
    public class BikeUtility
    {
        private Dictionary<int, Bike> BikeDetails { get; set; } = null;

        public BikeUtility()
        {
            BikeDetails = new Dictionary<int, Bike>();
        }

        public void AddBikeDetails(string model,string brand,int pricePerDay)
        {
            Bike temp = new Bike();
            temp.Model = model;
            temp.Brand = brand;
            temp.PricePerDay = pricePerDay;

            BikeDetails.Add(BikeDetails.Count()+1, temp);
        }

        public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
        {
            var result = new SortedDictionary<string, List<Bike>>(BikeDetails.Values.GroupBy(b => b.Brand)
                                                                       .ToDictionary(g => g.Key, g => g.ToList()));

            return result;

        }
    }
}
