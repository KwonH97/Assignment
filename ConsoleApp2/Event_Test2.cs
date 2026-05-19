using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Event_Test2
    {
        class Calculate // 게시자
        {
            //(object Sender, EventArgs e)
            public event EventHandler Event_ValueChaged; // 이벤트 선언

            public int Value { get; set; }

            public void Plus(int value)
            {
                Value += value;
                Event_ValueChaged(this, EventArgs.Empty); // 이벤트 발생
            }
            public void Minus(int value)
            {
                Value -= value;
                Event_ValueChaged(this, EventArgs.Empty); // 이벤트 발생
            }
        }
        static void Main(string[] args) // 수신자
        {
            Calculate cal = new Calculate();

            cal.Event_ValueChaged += Cal_Event_ValueChaged;

            cal.Plus(4);

            cal.Minus(20);
        }

        private static void Cal_Event_ValueChaged(Object sender, EventArgs e)
        {
            Calculate cal = sender as Calculate;

            Console.WriteLine($"값 : {cal.Value}");
        }
    }
}
