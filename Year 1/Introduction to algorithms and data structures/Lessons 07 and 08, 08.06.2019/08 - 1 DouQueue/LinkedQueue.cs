using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___1_DouQueue {
    class LinkedQueue<T> {
        private class QueueNode<T> {
            public T Value { get; private set; }

            public QueueNode<T> NextNode { get; set; }
            public QueueNode<T> PrevNode { get; set; }

            public QueueNode(T value) {
                Value = value;
            }
        }

        QueueNode<T> head;
        QueueNode<T> tail;
        public int Count { get; private set; }

        public void Enqueue(T element) { //добавя нов tail
            var newTail = new QueueNode<T>(element);

            if (Count == 0) {
                tail = head = newTail;
            }
            else {
                tail.NextNode = newTail;
                newTail.PrevNode = tail;
                tail = newTail;
            }

            Count++;
        }

        public T Dequeue() { //изважда head
            if(Count == 0) {
                throw new InvalidOperationException("List is empty");
            }

            var toReturn = head.Value;
            if (Count == 1) {
                head = tail = null;
            }
            else {
                head.NextNode.PrevNode = null;
                head = head.NextNode;
            }
            Count--;
            return toReturn;
        }

        public T[] ToArray() {
            var arr = new T[Count];
            var currNode = head;

            for (int i = 0; i < Count; i++) {
                arr[i] = currNode.Value;
                currNode = currNode.NextNode;
            }
            return arr;
        }
    }
}
