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

        Console.WriteLine("Addition = " + (a + b));
        Console.WriteLine("Subtraction = " + (a - b));
        Console.WriteLine("Multiplication = " + (a * b));
        Console.WriteLine("Division = " + (a / b));
    }
}
