using System;

class Program
{
    static void Main()
    {
        Console.Write("yek addad vared konid: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 7 == 0)
            Console.WriteLine("YES!");
        else
            Console.WriteLine(number * 3);
    }
}
