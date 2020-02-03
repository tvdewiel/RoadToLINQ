using System;

namespace FuncAction
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.0;
            double y = 7.8;
            Console.WriteLine("Hello World!");
            Func<double, double, double> mathF;
            Action<double, double> printMathRes;
            Action<Func<double, double, double>, double, double> printMathWithFuncRes;

            mathF = add;
            Console.WriteLine($"x={x},y={y},function result={mathF(x, y)}");

            printMathRes = print1;
            printMathRes(x, y);

            printMathWithFuncRes = print2;
            printMathWithFuncRes(subtract, x, y);

        }
        public static void print1(double a, double b)
        {
            Console.WriteLine($"printing1:{a},{b}->{a * b}");
        }
        public static void print2(Func<double, double, double> f, double a, double b)
        {
            Console.WriteLine($"printing:{a},{b}->{f(a, b)}");
        }
        public static double add(double a, double b)
        {
            Console.WriteLine($"add:{a},{b}");
            return a + b;
        }
        public static double subtract(double a, double b)
        {
            Console.WriteLine($"subtract:{a},{b}");
            return a - b;
        }
        public static double multiply(double a, double b)
        {
            Console.WriteLine($"multiply:{a},{b}");
            return a * b;
        }
        public static double divide(double a, double b)
        {
            Console.WriteLine($"divide:{a},{b}");
            return a / b;
        }
    }
}
