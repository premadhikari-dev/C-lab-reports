using System;

class question3
{
    static void Main()
    {
        Console.Write("Enter length: ");
        int l = int.Parse(Console.ReadLine());

        Console.Write("Enter breadth: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Area = " + (l * b));
        Console.WriteLine("Perimeter = " + (2 * (l + b)));
    }
}