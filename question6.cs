using System;

class question6
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("AND: " + (a & b));
        Console.WriteLine("OR: " + (a | b));
        Console.WriteLine("XOR: " + (a ^ b));
        Console.WriteLine("Left Shift: " + (a << 1));
        Console.WriteLine("Right Shift: " + (a >> 1));
    }
}