using System;

class Program
{
    static void Main()
    {
        int p = -1;

        Console.WriteLine("5 adad vared konid:");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Number {i}: ");
            int n = int.Parse(Console.ReadLine());

            if (n == 2 && p == -1)
            {
                p = i;
            }
        }
        if (p != -1)
            Console.WriteLine($"jaygah adad 2: {p}");
        else
            Console.WriteLine("yaft nashod");
    }
}