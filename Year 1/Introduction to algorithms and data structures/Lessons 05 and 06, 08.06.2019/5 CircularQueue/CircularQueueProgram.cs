using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CircularQueue {
    class CircularQueueProgram {
        static void Main(string[] args) {
            CircularQueue<string> myCQueue = new CircularQueue<string>(2);

            myCQueue.Enqueue("Programming");
            myCQueue.Enqueue("is");
            myCQueue.Enqueue("very");
            myCQueue.Enqueue("fun");

            myCQueue.Dequeue();
            myCQueue.Dequeue();

            Console.WriteLine(myCQueue.Count);

            myCQueue.Enqueue("C#");

            Console.WriteLine(string.Join("|", myCQueue.ToArray()));
            Console.WriteLine();
        }
    }
}
