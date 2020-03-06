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
        static void FourthLoop()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello Count Dracula! The counter is {counter}");
                counter++;
            }
            int backwards = 10;
            while (backwards > 0)
            {
                Console.WriteLine($"Hello Count! Lets Count backwards {backwards}");
                backwards--;
            }

        }
        static void FifthLoop()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Hello Count! The Counter is {counter}");
            }
        }
        static void SixthLoop()
        {
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The Summary is {sum}");

        }

        static void BooLoop()
        {
            bool condition = true;
            if (condition)
            {
                Console.WriteLine("Variable is True");
            }
            else
            {
                Console.WriteLine("Variable is False");
            }
        }
        static void IntBooLoop()
        {
            int m = 9;
            int n = 18;

            if (m > 10)
            {
                if (n > 20)
                {
                    Console.WriteLine("Result1");
                }
                else
                {
                    Console.WriteLine("Result2");
                }
            }
            else
            {
                Console.WriteLine("Result3");
            }
        }

        static void Main(string[] args)
        {
            FirstLoop();
            SecondLoop();
            ThirdLoop();
            FourthLoop();
            FifthLoop();
            SixthLoop();
            BooLoop();
            IntBooLoop();


        }
    }
}
