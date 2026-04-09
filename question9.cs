using System;

namespace lab3prem
{
    class question9
    {
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) return false;
            return true;
        }

        public static void Main()
        {
            Console.Write("Enter size: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime elements:");
            foreach (int x in arr)
                if (IsPrime(x))
                    Console.Write(x + " ");
        }
    }
}
