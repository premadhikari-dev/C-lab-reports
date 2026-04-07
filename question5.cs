using System;

class question5
{
    static void Main()
    {
        Console.Write("Enter 3 numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int largest = (a > b) ? (a > c ? a : c) : (b > c ? b : c);
        int smallest = (a < b) ? (a < c ? a : c) : (b < c ? b : c);

        Console.WriteLine("Largest = " + largest);
        Console.WriteLine("Smallest = " + smallest);
    }
}