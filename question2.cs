using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3prem
{
    class question2
    {
        public static void Main()
        {
            Console.Write("Enter size: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int min = arr[0], max = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
        }
    }
}
