﻿using System;

namespace NumbersInCSharpe
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
            Console.WriteLine(a + b);
            c = a - b;
            Console.WriteLine(c);

            c = a * b;
            Console.WriteLine(c);

            c = a / b;
            Console.WriteLine(c);

            c = a + b ^ 2;
            Console.WriteLine(c);

            c = a % b;
            Console.WriteLine(c + "last one");



        }

        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h + "this is H");

        }

        static void RemainderExpression()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;

            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of people {min}-------{max}");
            int what = max + 3;
            Console.WriteLine($"Example of OverFlow: {what} AMAZING WORK!");



        }
        static void DoubleExpressions()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);
            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"RANGE DOUBLED IS {min}-----{max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }


        static void Main(string[] args)
        {
            WorkingWithIntegers();
            OrderPrecedence();
            RemainderExpression();
            DoubleExpressions();

            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;

            Console.WriteLine($"Decimal range is {min}-----{max}");
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            double radius = 2.5;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
            Console.WriteLine(area + 2);
            Console.WriteLine("DONE");





        }
    }
}

