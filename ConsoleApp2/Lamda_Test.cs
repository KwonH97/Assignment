using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Lamda_Test
    {
        public delegate void Runner();
        static void RunnerCall(Runner run) => run();
        /* 같은 거
        static void RunnerCall(Runner run)
        {
            run();
        }
        */
        static void Go() => Console.WriteLine("Go");
        static void Stop() => Console.WriteLine("Stop");
        static void Back() => Console.WriteLine("Back");

        static void Main(string[] args)
        {
            RunnerCall(new Runner(Go));
            RunnerCall(new Runner(Stop));
            RunnerCall(new Runner(Back));
        }
    }
}
