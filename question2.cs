using System;

class question2
{
    static void Main(string[] args)
    {
        int a = int.Parse(args[0]);
        int b = int.Parse(args[1]);

        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
    }
}