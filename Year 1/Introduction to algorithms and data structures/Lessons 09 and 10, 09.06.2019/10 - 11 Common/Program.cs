using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___11_Common {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ', ',').Where(x => x != "").Select(int.Parse).ToArray();

            foreach(var n in numbers.OrderBy(x => x).Distinct()) {
                Console.WriteLine($"{n} - {numbers.Count(x => x == n)} пъти");
            }
        }
    }
}
