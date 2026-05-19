using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Generic
    {
        public static void Swap_int(ref int a, ref int b)
        {
            int tem;
            tem = a;
            a = b;
            b = tem;

        }
        public static void Swap_double(ref double a, ref double b)
        {
            double tem;
            tem = a;
            a = b;
            b = tem;

        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 100;
            Swap_int(ref a, ref b);

            Console.WriteLine($"a={a}, b={b}");

            double c = 10.1;
            double d = 100.3;
            Swap_double(ref c, ref d);
            Console.WriteLine($"c={c}, d={d}");

            a = 1;
            b = 2;
            Swap(ref a, ref b);
            Console.WriteLine($"a={a}, b={b}");

            c = 1.3;
            d = 5.5;
            Swap(ref c, ref d);
            Console.WriteLine($"c={c}, d={d}");

            char f = 'a';
            char g = 'b';
            Swap(ref f, ref g);
            Console.WriteLine($"f={f}, g={g}");
        }
    }
}
