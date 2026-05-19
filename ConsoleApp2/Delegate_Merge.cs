using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Delegate_Merge
    {
        public delegate void Dele_Merge(int a, int b);

        static void Plus(int a, int b)
        {
            Console.WriteLine($"Plus : {a + b}");
        }
        static void Minus(int a, int b)
        {
            Console.WriteLine($"Minus : {a - b}");
        }

        static void Main(string[] args)
        {
            Dele_Merge dm = new Dele_Merge(Plus);
            dm += new Dele_Merge(Minus);
            

            dm(10, 20);

            Console.WriteLine("===============================================================");
            dm -= Plus;

            dm(30, 20);
        }

    }
}
