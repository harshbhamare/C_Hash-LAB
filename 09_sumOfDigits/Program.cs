using System;

class Program
{
    static void Main()
    {
        int num, sum = 0;
        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());

        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }

        Console.WriteLine("Sum of digits = " + sum);
    }
}
