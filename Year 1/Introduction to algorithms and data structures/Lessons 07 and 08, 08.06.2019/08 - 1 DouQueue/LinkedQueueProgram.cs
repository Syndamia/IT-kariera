using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___1_DouQueue {
    class LinkedQueueProgram {
        static void Main(string[] args) {
            var linkQueue = new LinkedQueue<int>();

            linkQueue.Enqueue(6);
            linkQueue.Enqueue(8);
            linkQueue.Enqueue(14);

            Console.WriteLine($"Count: {linkQueue.Count} | Elements: {string.Join(" ", linkQueue.ToArray())}");

            Console.WriteLine($"Dequed: {linkQueue.Dequeue()}");
            Console.WriteLine($"Count: {linkQueue.Count} | Elements: {string.Join(" ", linkQueue.ToArray())}");

            Console.WriteLine($"Dequed: {linkQueue.Dequeue()}");
            Console.WriteLine($"Count: {linkQueue.Count} | Elements: {string.Join(" ", linkQueue.ToArray())}");

            linkQueue.Enqueue(17);
            Console.WriteLine($"Count: {linkQueue.Count} | Elements: {string.Join(" ", linkQueue.ToArray())}");

            Console.WriteLine($"Dequed: {linkQueue.Dequeue()}");
            Console.WriteLine($"Count: {linkQueue.Count} | Elements: {string.Join(" ", linkQueue.ToArray())}");
        }
    }
}
