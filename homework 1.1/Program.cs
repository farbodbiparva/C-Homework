using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the radius: ");
        double r = double.Parse(Console.ReadLine());

        double masahat = 3.14 * r * r;
        double mohit = 2 * 3.14 * r;

        Console.WriteLine($"masahat: {masahat}");
        Console.WriteLine($"Circumference: {mohit}");
    }
}
