using System;

class Program
{
    static void Main()
    {
        int num, fact = 1;
        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
            fact *= i;

        Console.WriteLine("Factorial = " + fact);
    }
}
