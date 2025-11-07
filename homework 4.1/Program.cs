using System;

class Program
{
    static void Main()
    {
        int zoj = 0;
        int fard = 0;

        Console.WriteLine("10 adad vared konid:");

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"number {i}: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
                zoj++;
            else
                fard++;
        }
        Console.WriteLine($"tedad adad zoj: {zoj}");
        Console.WriteLine($"tedad adad fard: {fard}");
    }
}
