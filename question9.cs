using System;

namespace premlab2
{
    class question9
    {
        static void Main()
        {
            int sum = 0;

            while (true)
            {
                Console.Write("Enter number: ");
                int n = int.Parse(Console.ReadLine());

                if (n < 0)
                    break;

                sum += n;
            }

            Console.WriteLine("Sum = " + sum);

            Console.ReadKey();
        }
    }
}
