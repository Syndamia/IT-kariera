using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_ListyIterator {
    class Program {
        static void Main(string[] args) {
            ListyIterator myListyIterator = new ListyIterator();

            while (true) {
                var input = Console.ReadLine().Split().ToArray();
                if (input[0] == "END") break;

                try {
                    switch (input[0]) {
                        case "Create": myListyIterator = new ListyIterator(input.Skip(1).ToArray()); break;
                        case "Move": Console.WriteLine(myListyIterator.Move()); break;
                        case "Print": Console.WriteLine(myListyIterator.Print()); break;
                        case "HasNext": Console.WriteLine(myListyIterator.HasNext()); break;
                    }
                } catch (InvalidOperationException e) {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
