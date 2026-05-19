using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Enum_Test
    {
        static void Main(string[] args)
        {
            IEnumerable<int> GetEnumInt()
            {
                yield return 10;
                yield return 20;
                yield return 30;
            }

            foreach (int i in GetEnumInt())
            {
                Console.WriteLine(i);
            }

            IEnumerable<String> GetEnumStr()
            {
                yield return "aaaa";
                yield return "bbbb";
                yield return "cccc";
            }
            foreach (String i in GetEnumStr())
            {
                Console.WriteLine(i);
            }
        }
        

        

    }
}
