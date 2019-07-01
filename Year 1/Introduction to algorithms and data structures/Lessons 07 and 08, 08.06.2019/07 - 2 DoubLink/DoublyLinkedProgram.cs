using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___2_DoubLink {
    class DoublyLinkedProgram {
        static void Main(string[] args) {
            //не съм иплементирал IEnumerable<T> защото не сме го учили (и е много напреднал материал), макар и уж да го искат в задачта
            var doubLink = new DoublyLinked<int>();

            doubLink.AddFirst(2);
            doubLink.AddLast(5);
            doubLink.AddFirst(17);
            doubLink.AddLast(24);

            Console.WriteLine(string.Join(" ", doubLink.ToArray()));

            Console.WriteLine($"Removed the last element with value: {doubLink.RemoveLast()}");
            Console.WriteLine($"Removed the first element with value: {doubLink.RemoveFirst()}");
            Console.WriteLine(string.Join(" ", doubLink.ToArray()));
            Console.WriteLine($"Removed the last element with value: {doubLink.RemoveLast()}");
            Console.WriteLine(string.Join(" ", doubLink.ToArray()));

            doubLink.AddFirst(64);
            doubLink.Foreach(e => Console.WriteLine($"Test of foreach. This is element {e}"));
            Console.WriteLine(string.Join(" ", doubLink.ToArray()));
        }
    }
}
