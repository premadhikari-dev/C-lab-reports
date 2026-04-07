using System;

namespace premlab2
{
    class question5
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (n <= 1)
                isPrime = false;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");

            Console.ReadKey();
        }
    }
}
