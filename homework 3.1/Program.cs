using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1-7): ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine("shanbe");
                break;
            case 2:
                Console.WriteLine("yekshanbe");
                break;
            case 3:
                Console.WriteLine("doshanbe");
                break;
            case 4:
                Console.WriteLine("seshanbe");
                break;
            case 5:
                Console.WriteLine("chaharshanbe");
                break;
            case 6:
                Console.WriteLine("panjshanbe");
                break;
            case 7:
                Console.WriteLine("jome");
                break;
            default:
                Console.WriteLine("END!");
                break;
        }
    }
}