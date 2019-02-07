using System;

namespace HouesOfCoffeeLibrary
{
    public class Employees
    {
        public void Payroll()
        {
            try
            {
                Console.Clear();
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine($"Enter the number of hours worked for Employee {i}:");
                    int p = Convert.ToInt32(Console.ReadLine());
                    if (p <= 40)
                    {
                        double pa = p * 12.50;
                        Console.WriteLine($"Employee {i} payroll: {pa:c}");
                        Console.ReadLine();
                    }
                    else
                    {
                        double pa = p - 40;
                        double t = pa * 18.75;
                        double x = t + 500;
                        Console.WriteLine($"Over Time Hours: {pa}");
                        Console.WriteLine($"Employee {i} payroll: {x:c}");
                        Console.ReadLine();
                    }
                }
                    Console.WriteLine("\nPress enter to go back to menu.");
                    Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("Try again.");
                Console.ReadLine();
                Payroll();
            }
        }
    }
}
