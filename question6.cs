using System;

namespace lab3prem
{
    class question6
    {
        static void ByValue(int x)
        {
            x = 100;
        }

        static void ByRef(ref int x)
        {
            x = 100;
        }

        public static void Main()
        {
            int a = 10;
            ByValue(a);
            Console.WriteLine("By Value: " + a);

            ByRef(ref a);
            Console.WriteLine("By Ref: " + a);
        }
    }
}
