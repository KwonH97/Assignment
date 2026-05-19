using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // 델리게이트는 반환자와 타입이 반드시 일치해야한다.
    internal class Delegate_Test
    {
        public delegate void Dele_Test(); //Dele_Test()는 함수가 아니라 형(타입)이다.
        public delegate void Dele_Add(int x, int w);
        public delegate int Dele_Sum(int z, int q);
        static void Test()
        {
            Console.WriteLine("MmmmmM");
        }
        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {

            Dele_Test dt = Test;
            dt();
            Dele_Add da = Add;
            da(10, 20);
            Dele_Sum ds = Sum;
            int tt = ds(30, 40);
            Console.WriteLine(tt);
        }
    }
}
