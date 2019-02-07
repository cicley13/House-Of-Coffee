using System;

namespace HouesOfCoffeeLibrary
{
    public class Menu
    {
        public void Options()
        {
            MenuCal m = new MenuCal();
            Employees e = new Employees();
            Console.WriteLine("House Of Coffee");
            Console.WriteLine("Menu:");
            Console.WriteLine("1: Add Coffee Sales");
            Console.WriteLine("2: Add Sandwich Sales");
            Console.WriteLine("3: Total Coffee & Sandwich Sales");
            Console.WriteLine("4: Add Employee Payroll");
            Console.WriteLine("5: Exit");
            string Selection = Console.ReadLine();

            switch ((Products.MenuOptions)Convert.ToInt32(Selection))
            {
                case Products.MenuOptions.Coffee:
                    m.AddCoffee();
                    Console.Clear();
                    Options();
                    break;

                case Products.MenuOptions.Sandwich:
                    m.AddSandwich();
                    Console.Clear();
                    Options();
                    break;

                case Products.MenuOptions.DailyTotal:
                    m.TotalSales();
                    Console.Clear();
                    Options();
                    break;

                case Products.MenuOptions.Employees:
                    e.Payroll();
                    break;
                default:
                    Environment.Exit(0);
                    break;

            }
        }
    }
}
