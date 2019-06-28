using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_StaticStack {
    class StaticStackProgram {
        static void Main(string[] args) {
            var myStack = new ArrayStack<char>();

            myStack.Push('A');
            myStack.Push('B');
            myStack.Push('C');
            myStack.Push('D');
            myStack.Push('*');

            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Count);

            myStack.Push('E');
            Console.WriteLine(string.Join(" ", myStack.ToArray()));

            Console.WriteLine();
        }
    }
}
