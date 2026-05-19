using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Delegate_Para
    {
        public delegate int Del_Para(int a, int b);

        static int Plus(int a, int b)
        {
            return a + b;
        }
        static int Minus(int a, int b)
        {
            return a - b;
        }

        static void Dele_Para_Test(int a, int b, Del_Para dp)
        {
            int result = dp(a, b);
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Dele_Para_Test(10, 20, new Del_Para(Plus));
            Dele_Para_Test(10, 20, new Del_Para(Minus));
        }
    }
}
