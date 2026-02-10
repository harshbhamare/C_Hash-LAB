using System;

class Program
{
    static void Main()
    {
        int num, rev = 0;
        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());

        while (num != 0)
        {
            rev = rev * 10 + (num % 10);
            num /= 10;
        }

        Console.WriteLine("Reversed number = " + rev);
    }
}
