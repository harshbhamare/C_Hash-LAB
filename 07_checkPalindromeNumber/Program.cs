using System;

class Program
{
    static void Main()
    {
        int num, temp, rev = 0;
        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());

        temp = num;
        while (num != 0)
        {
            rev = rev * 10 + (num % 10);
            num /= 10;
        }

        if (temp == rev)
            Console.WriteLine("Palindrome number");
        else
            Console.WriteLine("Not a palindrome");
    }
}
