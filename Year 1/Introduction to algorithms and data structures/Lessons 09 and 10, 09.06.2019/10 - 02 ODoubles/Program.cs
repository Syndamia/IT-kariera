using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___2_ODoubles {
    class Program {
        static void Main(string[] args) {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            for (int p = 1; p <= m; p++) {
                for (int q = 1; q <= n; q++) {
                    Console.WriteLine($"({p}, {q})");
                }
            }
        }
    }
}
