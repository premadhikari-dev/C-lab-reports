using System;

namespace lab3prem
{
    class question7
    {
        static void Show(string name = "Prem", int age = 20)
        {
            Console.WriteLine(name + " " + age);
        }

        public static void Main()
        {
            Show();
            Show(age: 25, name: "Ram");
        }
    }
}
