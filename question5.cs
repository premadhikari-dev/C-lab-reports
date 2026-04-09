using System;

namespace lab3prem
{
    class question5
    {
        public static void Main()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 2 };
            arr[1] = new int[] { 3, 4, 5 };
            arr[2] = new int[] { 6 };

            foreach (var row in arr)
            {
                foreach (var val in row)
                    Console.Write(val + " ");
                Console.WriteLine();
            }
        }
    }
}
