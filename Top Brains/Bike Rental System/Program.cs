using Bike_Rental_Assignment;
using System;
using System.Collections.Generic;

class Program
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();

    static void Main(string[] args)
    {
        BikeUtility utility = new BikeUtility();

        while (true)
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");

            Console.WriteLine();

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:

                    Console.Write("Enter the model: ");
                    string model = Console.ReadLine();

                    Console.Write("Enter the brand: ");
                    string brand = Console.ReadLine();

                    Console.Write("Enter the price per day: ");
                    int price = Convert.ToInt32(Console.ReadLine());

                    utility.AddBikeDetails(model, brand, price);

                    Console.WriteLine();

                    Console.WriteLine("Bike details added successfully");

                    Console.WriteLine();
                    break;

                case 2:

                    var result = utility.GroupBikesByBrand();

                    foreach (var item in result)
                    {
                        foreach (var bike in item.Value)
                        {
                            Console.WriteLine($"{item.Key} {bike.Model}");
                        }
                    }

                    Console.WriteLine();

                    break;

                case 3:
                    return;

                default:
                    
                    Console.WriteLine("Invalid Choice");

                    Console.WriteLine();

                    break;
            }

            Console.WriteLine();
        }
    }
}