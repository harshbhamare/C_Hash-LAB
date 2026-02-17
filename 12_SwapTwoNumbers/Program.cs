using System;

class Program
{
    static void Main()
    {
        int a = 10, b = 20, temp;

        temp = a;
        a = b;
        b = temp;

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
