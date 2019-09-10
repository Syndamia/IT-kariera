using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_StackOfStrings {
    class Program {
        static void Main(string[] args) {
            var mySOS = new StackOfStrings();
            mySOS.Push("One");
            mySOS.Push("Two");
            mySOS.Push("Three");

            Console.WriteLine("Popped " + mySOS.Pop());
            Console.WriteLine(mySOS);
            Console.WriteLine("Peeked " + mySOS.Peek());
            Console.WriteLine(mySOS);
            Console.WriteLine("Is empty " + mySOS.IsEmpty());
            mySOS.Pop();
            mySOS.Pop();
            Console.WriteLine("Is empty " + mySOS.IsEmpty());
        }
    }
}
