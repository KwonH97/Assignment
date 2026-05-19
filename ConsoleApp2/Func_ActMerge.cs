using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Func_ActMerge
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Minus(int x, int y)
        {
            return x - y;
        }
        static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Sub(int a,int b)
        {
            Console.WriteLine(a - b);
        }
        static void AddOper(int a, int b, Func<int,int,int> op)
        {
            int result = op(a,b);
            Console.WriteLine(result);
        }
        static void AddOper2(int a, int b, Action<int, int> op2)
        {
            op2(a, b);
        }
        static void Main(string[] args)
        {
            Func<int, int, int> func1 = Add;
            Func<int, int, int> func2 = Minus;
            func1 += func2;
            int result = func1(10, 20);
            Console.WriteLine(result);

            Console.WriteLine("===========================Action Test");

            Action<int, int> act1 = Sum;
            Action<int, int> act2 = Sub;
            act1 += act2;
            act1(10, 20);

            Console.WriteLine("===========================Func Parameter");

            AddOper(3, 4, Add);

            Console.WriteLine("===========================Action Parameter");

            AddOper2(2, 1, Sum);
        }
    }
}
