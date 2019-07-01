using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___2_LinStack {
    class LinkedStackProgram {
        static void Main(string[] args) {
            var linkStack = new LinkedStack<int>();

            linkStack.Push(2);
            linkStack.Push(7);
            linkStack.Push(13);
            linkStack.Push(18);
            linkStack.Push(26);
            linkStack.Push(33);

            Console.WriteLine($"Elements: {string.Join(" ", linkStack.ToArray())}");

            linkStack.Pop();
            linkStack.Pop();
            linkStack.Pop();
            linkStack.Pop();

            Console.WriteLine($"Elements: {string.Join(" ", linkStack.ToArray())}");
        }
    }
}
