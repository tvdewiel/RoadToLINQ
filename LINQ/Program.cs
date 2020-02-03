using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p1 = new Person(175, 75, "Lowie",'M');
            Person p2 = new Person(159, 60, "Veerle",'F');
            Person p3 = new Person(185, 104, "Charel",'M');
            Person p4 = new Person(162, 49, "Mark",'M');
            Person p5 = new Person(178, 72, "Ingrid",'M');
            Person p6 = new Person(172, 62, "Inge", 'F');
            List<Person> l = new List<Person>();
            l.Add(p1); l.Add(p2); l.Add(p3); l.Add(p4); l.Add(p5); l.Add(p6);
            Console.WriteLine("All:");
            foreach (Person p in l)
            {
                Console.WriteLine(p);
            }

            //filtered
            Console.WriteLine("filtered:");
            foreach (var x in l.Where(x => x.length < 180))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("filtered:");
            foreach (var x in l.Where(x => x.length < 180).Select(y=>new { y.name,y.length}))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("filtered:");
            foreach (var x in l.GroupBy(x=>x.sex))
            {
                Console.WriteLine($"{x.Key.ToString()},{x.Count()},{x.Sum(y=>y.weight)},{x.Average(y=>y.weight)}");
            }
        }
    }
}
