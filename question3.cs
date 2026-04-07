using System;

namespace premlab2
{
    class Question3
    {
        public static void Main()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            int largest;

            if (a > b)
            {
                if (a > c)
                    largest = a;
                else
                    largest = c;
            }
            else
            {
                if (b > c)
                    largest = b;
                else
                    largest = c;
            }

            Console.WriteLine("Largest = " + largest);
        }
    }
}