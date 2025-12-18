using System;

class Calculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition: " + (n1 + n2));
        Console.WriteLine("Subtraction: " + (n1 - n2));
    }
}
