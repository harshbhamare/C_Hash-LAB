using System;

class Program
{
    static void Main()
    {
        int a, b;
        Console.Write("Enter first number: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = int.Parse(Console.ReadLine());

        if (a > b)
            Console.WriteLine("Largest number is " + a);
        else
            Console.WriteLine("Largest number is " + b);
    }
}
