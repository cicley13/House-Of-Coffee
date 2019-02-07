using System;

namespace HouesOfCoffeeLibrary
{
    public class MenuCal
    {
       
        Prices p = new Prices();
        CalculateTotals ct = new CalculateTotals();

        public void AddCoffee()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Enter the amount of small coffee's sold:");
                ct.NumberSold = Convert.ToInt32(Console.ReadLine());
                CalculateTotals.CalculateCoffee(ct.NumberSold, p.CoffeeCost, p.CoffeePrice, Products.Coffeesize.small);


                Console.WriteLine("Enter the amount of medium coffee's sold:");
                ct.NumberSold = Convert.ToInt32(Console.ReadLine());
                CalculateTotals.CalculateCoffee(ct.NumberSold, p.CoffeeCost, p.CoffeePrice, Products.Coffeesize.medium);

                Console.WriteLine("Enter the amount of large coffee's sold:");
                ct.NumberSold = Convert.ToInt32(Console.ReadLine());
                CalculateTotals.CalculateCoffee(ct.NumberSold, p.CoffeeCost, p.CoffeePrice, Products.Coffeesize.large);

                Console.WriteLine($"\tCoffee Gross of Sales:\t\t{CalculateTotals.CoffeeGrossTotals:c}");
                Console.WriteLine($"\tCoffee Cost Of Good sold:\t{CalculateTotals.CoffeeCostTotals:c}");
                Console.WriteLine($"\tCoffee Profit:\t\t\t{(CalculateTotals.CoffeeGrossTotals - CalculateTotals.CoffeeCostTotals):c}");
                Console.WriteLine("\nPress enter to go back to menu.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Try again.");
                Console.ReadLine();
                AddCoffee();
            }

        }

        public void AddSandwich()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Enter the amount of Egg Sandwich's sold:");
                ct.NumberSold = Convert.ToInt32(Console.ReadLine());
                CalculateTotals.CalculateSandwich(ct.NumberSold, p.SandwichCost, p.SandwichPrice, Products.SandwichTypes.EggSandwich);


                Console.WriteLine("Enter the amount of Chicken Biscuit's sold:");
                ct.NumberSold = Convert.ToInt32(Console.ReadLine());
                CalculateTotals.CalculateSandwich(ct.NumberSold, p.SandwichCost, p.SandwichPrice, Products.SandwichTypes.ChickenBiscuit);

                Console.WriteLine($"\tCoffee Gross of Sales:\t\t{CalculateTotals.SandwichGrossTotals:c}");
                Console.WriteLine($"\tCoffee Cost Of Good sold:\t{CalculateTotals.SandwichCostTotals:c}");
                Console.WriteLine($"\tCoffee Profit:\t\t\t{(CalculateTotals.SandwichGrossTotals - CalculateTotals.SandwichCostTotals):c}");
                Console.WriteLine("\nPress enter to go back to menu.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Try again.");
                Console.ReadLine();
                AddSandwich();
            }
        }

        public void TotalSales()
        {

            Console.Clear();
            if (CalculateTotals.SandwichGrossTotals + CalculateTotals.CoffeeGrossTotals==0) {
                Console.WriteLine("No data provided, please imput today's sales.");
            }
            else
            { 
                Console.WriteLine($"Total Gross: {(CalculateTotals.SandwichGrossTotals+CalculateTotals.CoffeeGrossTotals):c}");
                Console.WriteLine($"Total Cost of Goods: {(CalculateTotals.SandwichCostTotals + CalculateTotals.CoffeeCostTotals):c}"); ;
                Console.WriteLine($"Total Profit: {(CalculateTotals.SandwichGrossTotals-CalculateTotals.SandwichCostTotals) +(CalculateTotals.CoffeeGrossTotals-CalculateTotals.CoffeeCostTotals):c}");
                Console.WriteLine("\nPress enter to go back to menu.");

            }
            Console.ReadLine();
        }
    }
}
