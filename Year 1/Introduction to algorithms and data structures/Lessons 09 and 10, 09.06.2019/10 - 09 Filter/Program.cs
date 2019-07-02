using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___9_Filter {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ', ',').Where(x => x != "").Select(int.Parse).Where(n => n > -1).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
