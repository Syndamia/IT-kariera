using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___1_ArrayLis
{
    class ArrayListProgram
    {
        static void Main(string[] args)
        {
            ArrayList<int> list = new ArrayList<int>();

            list.Add(5);
            list.Add(-18);
            list.Add(99);
            list.Add(1828);

            list[2] += 1;

            Console.WriteLine($"Removed item: {list.RemoveAt(1)}");
            Console.WriteLine($"Count: {list.Count}");
            Console.WriteLine($"Length: {list.Length}");
        }
    }
}
