using System;

namespace lab3prem
{
    class question10
    {
        public static void Main()
        {
            int[,] m = new int[3, 3];

            Console.WriteLine("Enter matrix:");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    m[i, j] = int.Parse(Console.ReadLine());

            int det =
                m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1])
              - m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0])
              + m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);

            Console.WriteLine("Determinant = " + det);
        }
    }
}
