using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___4_Students {
    class Program {
        static void Main(string[] args) {
            var students = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            SelectionSort.Sort(students);
            var positions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine($"{students[positions[0] - 1]} {students[positions[1] - 1]}");
        }
    }
}
