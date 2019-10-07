using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_Collection {
    class Program {
        static void Main(string[] args) {
            Logic();
        }

        public static void Logic() {
            ListyIterator myListyIt = new ListyIterator();

            while (true) {
                var info = Console.ReadLine().Split().ToArray();
                
                try {
                    switch (info[0]) {
                        case "END": return;
                        case "Create": myListyIt = new ListyIterator(info.Skip(1).ToArray()); break;
                        case "PrintAll": Console.WriteLine(myListyIt.PrintAll()); break;
                        case "Print": Console.WriteLine(myListyIt.Print()); break;
                        case "Move": Console.WriteLine(myListyIt.Move()); break;
                        case "HasNext": Console.WriteLine(myListyIt.HasNext()); break;
                    }
                } catch (InvalidOperationException e) {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
