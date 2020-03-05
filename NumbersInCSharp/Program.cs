using System;

namespace NumnbersInCSharp
{
    class Program
    {

        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(a + c);
            Console.WriteLine(a + b + c);
            c = a - b;
            Console.WriteLine(c);

            c = a * b;
            Console.WriteLine(c);

            c = a / b;
            Console.WriteLine(c);

            c = a + b ^ 2;
            Console.WriteLine(c);

            c = a % b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            WorkingWithIntegers();
        }
    }
}
