using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_ClassFamily {
    class Program {
        static void Main(string[] args) {
            Family myFamily = new Family();

            for (int i = int.Parse(Console.ReadLine()); i > 0; i--) {
                var input = Console.ReadLine().Split(' ').ToArray();

                myFamily.Add(new Person(input[0], int.Parse(input[1])));
            }

            Console.WriteLine(myFamily.ToString());
        }
    }
}
