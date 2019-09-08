using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___2_QuickSor {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Quick.Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
