using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        public delegate int Transformer(int x); //Doesn't have to be called Transformer can have any name
        public delegate void Void(int x);

        private static void Main(string[] args)
        {
            Transformer t1 = Add; //Square;

            //anonymous delegate
            Transformer t2 = delegate (int x) { return x * x; };

            //New .net replaced delegate keyword with the lambda expression =>
            Transformer t3 = x => { return x * x; };

            //Pure lambda function doesn't need the return statement if it only takes one line
            Transformer t4 = x => x * x;

            //Local function: a function within a function
            int LocalSquare(int x)
            {
                return x * x;
            }

            Transformer t5 = LocalSquare;

            Console.WriteLine(t1(3));
            Console.WriteLine(t2(3));
            Console.WriteLine(t3(3));
            Console.WriteLine(t4(3));
            Console.WriteLine(t5(3));

            Func<int, int> func = i => i + 1;
            Func<string, int> func2 = s => s.Length;
            Console.WriteLine(func(100));
            Console.WriteLine(func2("100"));

            Void voids = Console.WriteLine;
            voids += Console.WriteLine;
            voids += Console.WriteLine;

            voids(2);
        }

        public static int Square(int x)
        {
            return x * x;
        }

        public static int Add(int x)
        {
            return x + x;
        }
    }
}
