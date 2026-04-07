using System;

namespace premlab2
{
    class question8
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine("Nth term = " + (n == 0 ? a : b));

            Console.ReadKey();
        }
    }
}
