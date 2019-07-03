using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CalSequenceWQueue {
    class Program {
        static void Main(string[] args) {
            var S1 = int.Parse(Console.ReadLine());
            var numSeq = new Queue<int>(new int[] { S1 });

            for (int i = 0; numSeq.Count() <= 50; i++) {
                var s = numSeq.ElementAt(i);
                for(int t = 0; t < 3 && numSeq.Count() <= 50; t++) {
                    switch(t) {
                        case 0: numSeq.Enqueue(s + 1); break;
                        case 1: numSeq.Enqueue(2 * s + 1); break;
                        case 2: numSeq.Enqueue(s + 2); break;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numSeq));
        }
    }
}
