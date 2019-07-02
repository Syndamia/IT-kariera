using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___14_Majoran {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ', ',').Where(x => x != "").Select(int.Parse).ToArray();

            if (numbers.Any(x => numbers.Count(y => y == x) >= numbers.Length / 2 + 1)) {
                Console.WriteLine(numbers.First(x => numbers.Count(y => y == x) >= numbers.Length / 2 + 1));
            }
            else Console.WriteLine("The majorant does not exists!");
        }
    }
}
