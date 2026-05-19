using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Enum_Test02
    {
        class Collection 
        {
            public IEnumerator<int> GetEnumerator()
            {
                yield return 1;
                yield return 2;
                yield return 3;
            }
        }

        static void Main(string[] args)
        {
            Collection cl = new Collection();
            
            foreach(int i in cl)
            {
                Console.WriteLine(i);
            }
        }
    }
}
