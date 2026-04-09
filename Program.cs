using System;

namespace lab3prem
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter size: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 != 0)
                    sum += arr[i];
            }

            Console.WriteLine("Sum of odd elements = " + sum);
        }
    }
}
