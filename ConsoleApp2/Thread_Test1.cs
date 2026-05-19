using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Thread_Test1
    {
        static void Dowork()
        {
            Console.WriteLine("Sub : {0} ", System.Threading.Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Sub Thread : Do Work의 i 변수 : {i}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main : {0} ", System.Threading.Thread.CurrentThread.ManagedThreadId);

            // 둘중하나
            Thread thread = new Thread(new ThreadStart(Dowork));
            //Thread thread = new Thread(Dowork);

            thread.Start();

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Main Thread : Main의 i 변수 : {i}");
            }
            Console.ReadKey();
        }
    }
}
