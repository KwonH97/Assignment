using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Event_Test3
    {
        public class NumEventArgs : EventArgs
        {
            public int Sum { get; set; }
            public int Value { get; set; }
            public string Mm { get; set; }
            public NumEventArgs(int sum, int value, string m)
            {
                Sum = sum;
                Value = value;
                Mm = m;
            }

        }
        class Calculate // 게시자
        {
            //(object Sender, EventArgs e)
            public event EventHandler<NumEventArgs> Event_ValueChaged; // 이벤트 선언

            public int Sum { get; set; }
            public string Mm { get; set; }

            public void Plus(int value, string Mm)
            {
                Sum += value;
                Event_ValueChaged(this, new NumEventArgs(Sum, value, Mm)); // 이벤트 발생
            }
            public void Minus(int value, string Mm)
            {
                Sum -= value;
                Event_ValueChaged(this, new NumEventArgs(Sum, value, Mm)); // 이벤트 발생
            }

        }
        static void Main(string[] args) // 수신자
        {
            Calculate cal = new Calculate();

            cal.Event_ValueChaged += Cal_Event_ValueChaged;

            cal.Plus(100, "오우오");

            cal.Minus(230, "dldldldl");
        }

        private static void Cal_Event_ValueChaged(Object sender, NumEventArgs e)
        {
            Console.WriteLine($"Sum 값 : {e.Sum}, value 값 : {e.Value}, 문자 : {e.Mm}");
        }
    }
}
