using System;

namespace lambda
{
    class Program
    {
        public delegate int dataProcessing(Data d);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Data d = new Data(10, 7, "data nr 1");

            dataProcessing DP = dataPF;

            int res=DP(d);
            Console.WriteLine($"res={res}");

            DP = delegate (Data dd) { Console.WriteLine("anonymous"); return dd.x - dd.y; };
            res = DP(d);
            Console.WriteLine($"res={res}");

            DP = (Data dd) =>{ Console.WriteLine("lambda"); return dd.x * dd.y; };
            res = DP(d);
            Console.WriteLine($"res={res}");

            DP = (dd) => { Console.WriteLine("lambda 2"); return dd.x * dd.y; };
            res = DP(d);
            Console.WriteLine($"res={res}");

            //Action
            Action<Data> showData = x => Console.WriteLine($"action showData : {x.name},{x.x},{x.y}");
            showData(d);
        }

        public static int dataPF(Data d)
        {
            Console.WriteLine("dataPF");
            return d.x + d.y;
        }
    }
}
