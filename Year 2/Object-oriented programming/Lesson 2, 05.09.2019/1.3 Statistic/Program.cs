using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_Statistic {
    class Program {
        static void Main(string[] args) {
            var PeopleOver30 = new List<Person>();

            for (int i = int.Parse(Console.ReadLine()); i > 0; i--) {
                var input = Console.ReadLine().Split(' ').ToArray();

                if (int.Parse(input[1]) > 30) PeopleOver30.Add(new Person(input[0], int.Parse(input[1])));
            }

            foreach (var pers in PeopleOver30.OrderBy(p => p.Name)) {
                Console.WriteLine(pers.ToString());
            }
        }
    }
}
