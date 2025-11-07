using System;

class Program
{
    static void Main()
    {
        Console.Write("yek addad vared konid: ");
        int x = int.Parse(Console.ReadLine());

        if (x < 10 && x % 2 == 0)
            Console.WriteLine("TRUE!");
        else
            Console.WriteLine("FALSE!");

    }
}
