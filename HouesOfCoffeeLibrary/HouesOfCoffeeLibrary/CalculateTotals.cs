namespace HouesOfCoffeeLibrary
{
    public struct CalculateTotals
    {
        public static double CoffeeGrossTotals, SandwichGrossTotals, CoffeeCostTotals, SandwichCostTotals, EmployeeTotals;
        public int NumberSold;

        public static void CalculateCoffee(int numberSold, double[] CoffeePriceNet, double[] coffeePriceGross, Products.Coffeesize size)
        {
            CoffeeGrossTotals += coffeePriceGross[(int)size-1] * numberSold;
            CoffeeCostTotals += CoffeePriceNet[(int)size-1] * numberSold;

        }


        public static void CalculateSandwich(int numberSold, double[] SandwichPriceNet, double [] SandwichPriceGross, Products.SandwichTypes types)
        {
            SandwichGrossTotals += SandwichPriceGross[(int)types-1]*numberSold;
            SandwichCostTotals += SandwichPriceNet[(int)types - 1] * numberSold;
        }
        
    }
}
