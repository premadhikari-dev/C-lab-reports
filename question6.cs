using System;

namespace premlab2
{
    class question6
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            int original = n, sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit * digit;
                n /= 10;
            }

            if (sum == original)
                Console.WriteLine("Armstrong");
            else
                Console.WriteLine("Not Armstrong");

            Console.ReadKey();
        }
    }
}
