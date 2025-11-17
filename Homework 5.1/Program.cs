using System;

class Program
{
    static double Calculatemohit(double a, double b, double c)
    {
        return a + b + c;
    }

    static double CalculateArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2; 
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    static void Main()
    {
        Console.WriteLine("Please Enter sides of your Triangle:");

        Console.Write("side a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("side b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("side c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double mohit = Calculatemohit(a, b, c);
        double area = CalculateArea(a, b, c);

        Console.WriteLine($"\ntraingle mohit: {mohit}");
        Console.WriteLine($"triangle area: {area}");
    }
}
