using System;

class Program
{
    static int Multiply(int a, int b)
    {

        if (b == 0)
            return 0;
        return a + Multiply(a, b - 1);
    }

    static void Main()
    {
        Console.Write("adad aval ra vared konid : ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("adad dovom ra vared konid: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = Multiply(num1, num2);

        Console.WriteLine($"\nhasel zarb {num1} va {num2} barabar ast ba: {result}");
    }
}
