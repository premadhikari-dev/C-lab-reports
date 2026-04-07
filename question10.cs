using System;

namespace premlab2
{
    class question10
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;

        start:
            if (i > n)
                goto end;

            Console.WriteLine("Cube of " + i + " = " + (i * i * i));
            i++;
            goto start;

        end:
            Console.ReadKey();
        }
    }
}
