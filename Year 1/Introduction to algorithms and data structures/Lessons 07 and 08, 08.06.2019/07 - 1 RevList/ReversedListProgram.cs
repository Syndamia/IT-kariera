using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___1_RevList {
    class ReversedListProgram {
        static void Main(string[] args) {
            //не съм иплементирал IEnumerable<T> защото не сме го учили (и е много напреднал материал), макар и уж да го искат в задачта
            var revList = new ReversedList<int>();

            revList.Add(5);
            revList.Add(7);
            revList.Add(19);
            revList.Add(39);
            revList.Add(67);

            Console.WriteLine(revList);

            revList.RemoveAt(5); //tests normal shift and shrink of array
            Console.WriteLine(revList);

            revList.RemoveAt(1); //tests shift when having to change 0 position
            Console.WriteLine(revList);
        }
    }
}
