using System;

namespace BranchyLoops
{
    class Program
    {

        static void FirstLoop()
        {
            int a = 5;
            int b = 6;
            if (a + b > 10)
            {
                Console.WriteLine("a + b is Greater than 10!");
            }
            else
            {
                Console.WriteLine("a + b  is Less than 10!");
            }
            int d = 5;
            int e = 3;
            if (d + e > 10)
            {
                Console.WriteLine("d + e is Greater than 10!");
            }
            else
            {
                Console.WriteLine("d + e is Less than 10!");
            }
        }
        static void SecondLoop()
        {
            int a = 5;
            int b = 5;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("AndLoop The answer is greater than 10");
                Console.WriteLine("AndLoop And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("AndLoop The answer is not greater than 10");
                Console.WriteLine("AndLoop Or the first number is not equal to the second");
            }
            int d = 5;
            int e = 3;
            int f = 4;
            if ((d + e + f > 10) && (d == e))
            {
                Console.WriteLine("AnotherAndLoop The answer is greater than 10");
                Console.WriteLine("AnotherAndLoopAnd the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("AnotherAndLoop The answer is not greater than 10");
                Console.WriteLine("AnotherAndLoop Or the first number is not equal to the second");
            }


        }

        static void ThirdLoop()
        {
            int a = 5;
            int b = 5;
            int c = 4;
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("OrLoop The answer is greater than 10");
                Console.WriteLine("OrLoop And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("OrLoop The answer is not greater than 10");
                Console.WriteLine("OrLoop Or the first number is not equal to the second");
            }
            int d = 5;
            int e = 3;
            int f = 4;
            if ((d + e + f > 10) || (d == e))
            {
                Console.WriteLine("AnotherOrLoop The answer is greater than 10");
                Console.WriteLine("AnotherOrLoopAnd the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("AnotherOrLoop The answer is not greater than 10");
                Console.WriteLine("AnotherOrLoop the first number is not equal to the second");
            }


        }
        static void Main(string[] args)
        {
            FirstLoop();
            SecondLoop();
            ThirdLoop();

        }
    }
}
