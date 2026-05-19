using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FuncAct_Test
    {
        static string Add(int x, int y)
        {
            return (x + y).ToString();
        }
        static void Plus(int x, int y)
        {
            Console.WriteLine($"Action 호출 : {x + y}");
        }

        static void Main(string[] args)
        {
            Func<int, int, string> func1 = Add;
            Console.WriteLine($"Func 호출 : {func1(1, 2)}");

            Action<int, int> act1 = Plus;
            act1(4,5);

            Func<int, int, string> func2 = (x,y) => (x + y).ToString();
            Console.WriteLine($"Func 호출 : {func2(10, 20)}");

            Action<int, int> act2 = (x,y) => Console.WriteLine($"Action 호출 : {x + y}");
            act2(30, 40);



        }
    }
}
