using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // 제네릭을 쓰는 이유는 박싱 언박싱을 사용하면 속도가 느려지기 때문에 제네릭을 사용한다
    internal class Stack_Test
    {
        static void Print<T>(T col) where T : IEnumerable
        {
            
            foreach (var i in col)
            {
                Console.WriteLine(i);
            }
            
        }

        // 쓸필요가없음 하나로 열거해서 리턴이 가능함
        /*
        static void Print2<T>(T col) where T : IEnumerable

        {
            foreach (var i in col)
            {
                Console.WriteLine(i);
            }

        }
        */

        static void Main(string[] args)
        {
            // 스택이 작동 되는건 오브젝트로 타입이 지정되어서
            Stack st = new Stack();
            st.Push(1);
            st.Push(2.22);
            st.Push("MmM");

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            // 스택 순서문제
            /*
            int PopItem1 = (int)st.Pop();
            Console.WriteLine(PopItem1);

            double PopItem2 = (double)st.Pop();
            Console.WriteLine(PopItem2);

            string PopItem3 = (string)st.Pop();
            Console.WriteLine(PopItem3);
            */
            string PopItem3 = (string)st.Pop();
            Console.WriteLine(PopItem3);

            double PopItem2 = (double)st.Pop();
            Console.WriteLine(PopItem2);

            int PopItem1 = (int)st.Pop();
            Console.WriteLine(PopItem1);

            Console.WriteLine("Generic_Test");

            Stack<int> st_int = new Stack<int>();
            st_int.Push(1);
            st_int.Push(10);
            st_int.Push(40);

            Print<Stack<int>>(st_int);

            Queue<int> st_queue = new Queue<int>();
            st_queue.Enqueue(10000);
            st_queue.Enqueue(20000);
            st_queue.Enqueue(40000);

            Print<Queue<int>>(st_queue);
        }
    }
}
