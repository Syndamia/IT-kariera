using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___3_MergeLis {
    class Program {
        static void Main(string[] args) {
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //използвам firstList като mergedList
            firstList.AddRange(secondList);
            Console.WriteLine(string.Join(" ", firstList.OrderBy(x => x)));
        }
    }
}
