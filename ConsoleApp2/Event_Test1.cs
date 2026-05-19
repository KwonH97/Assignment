using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Event_Test1 //이벤트 게시자
    {
        delegate void Dele_Value(int result, string message); // Delegate 선언

       class Calculate // 게시자
        {
            public event Dele_Value Event_ValueChaged; // 이벤트 선언

            public int Value { get; set; }

            public void Plus(int value)
            {
                Value += value;
                Event_ValueChaged(Value, $"{value}를 더한 결과 입니다."); // 이벤트 발생
            }
            public void Minus(int value)
            {
                Value -= value;
                Event_ValueChaged(Value, $"{value}를 뺀 결과 입니다."); // 이벤트 발생
            }
        }
        static void Main(string[] args) // 수신자
        {
            Calculate cal = new Calculate();
            
            cal.Event_ValueChaged += Cal_Event_ValueChaged;

            cal.Plus(4);

            cal.Minus(20);
        }

        private static void Cal_Event_ValueChaged(int result, string message)
        {
            Console.WriteLine(message + " 헤헤");
            Console.WriteLine($"message : {message} result : {result}");
        }
    }
}
