using System;

namespace lab3prem
{
    class question8
    {
        static int Sum(params int[] nums)
        {
            int s = 0;
            foreach (int n in nums)
                s += n;
            return s;
        }

        public static void Main()
        {
            Console.WriteLine(Sum(1, 2, 3, 4));
        }
    }
}
