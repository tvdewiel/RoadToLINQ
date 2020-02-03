using System;

namespace delegates
{
    class Program
    {
        public delegate double MathFunction(double value1, double value2);
        static void Main(string[] args)
        {
            double x = 10.0;
            double y = 7.7;
            Console.WriteLine("Hello World!");
            MathFunction doStuff = add; //assignment syntax 1

            Console.WriteLine($"x={x},y={y},function result={add(x, y)}");
            Console.WriteLine($"x={x},y={y},function result={doStuff(x, y)}");

            doStuff = new MathFunction(subtract); //assignment syntax 2
            Console.WriteLine($"x={x},y={y},function result={doStuff(x, y)}");

            doStuff = new MathFunction(multiply);
            Console.WriteLine($"x={x},y={y},function result={doStuff.Invoke(x, y)}"); //invoking delegate

            //delegate as parameter
            Console.WriteLine($"x={x},y={y},function result={calculate(divide, x, y)}");


            //multicast delegate
            doStuff = add;
            doStuff += subtract;
            Console.WriteLine($"x={x},y={y},function result={doStuff(x, y)}");


            //anonymous method
            doStuff = delegate (double q, double b)
            {
                Console.WriteLine($"pow:{q},{b}");
                return Math.Pow(q, b);
            };
            Console.WriteLine($"x={x},y={y},function result={doStuff(x, y)}");
            //anonymous method as parameter
            Console.WriteLine($"x={x},y={y},function result={calculate(delegate (double q, double b) { return Math.Pow(q, b); }, x, y)}");
            Console.ReadKey();
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
        public static double calculate(MathFunction f, double x, double y)
        {
            return f(x, y);
        }
    }
}
