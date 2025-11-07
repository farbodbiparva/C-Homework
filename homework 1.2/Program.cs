using System;

class Program
{
    static void Main()
    {
        Console.Write("dama ra be celsius vared konid: ");
        double c = double.Parse(Console.ReadLine());

        double f = (c * 9 / 5) + 32;

        Console.WriteLine($"dama be Fahrenheit: {f}");
    }
}
