using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___9_FOddOcc {
    class Program {
        static void Main(string[] args) {
            var numbers = Console.ReadLine().Split(' ', ',').Where(x => x != "").Select(int.Parse).ToList();

            var distinctNumbers = numbers.Distinct().ToList();
            for (int i = 0; i < distinctNumbers.Count(); i++) {
                if(numbers.Count(x => x == distinctNumbers[i]) % 2 != 0) numbers.RemoveAll(x => x == distinctNumbers[i]);
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
