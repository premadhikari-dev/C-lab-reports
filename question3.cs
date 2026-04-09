using System;

namespace lab3prem
{
    class question3
    {
        public static void Main()
        {
            int[,] m = new int[3, 3];
            int sum = 0;

            Console.WriteLine("Enter 3x3 matrix:");

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    m[i, j] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
                sum += m[i, i];

            Console.WriteLine("Diagonal Sum = " + sum);
        }
    }
}
