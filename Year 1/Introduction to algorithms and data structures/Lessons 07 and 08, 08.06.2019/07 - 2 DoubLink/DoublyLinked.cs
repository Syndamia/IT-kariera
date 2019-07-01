using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___2_DoubLink {
    class DoublyLinked<T> {
        private class ListNode<T> {
            public T Value { get; private set; }

            public ListNode<T> NextNode { get; set; }
            public ListNode<T> PrevNode { get; set; }

            public ListNode(T value) {
                Value = value;
            }
        }

        private ListNode<T> head;
        private ListNode<T> tail;

        public int Count { get; private set; }

        public void AddFirst(T element) {
            if (Count == 0) {
                head = tail = new ListNode<T>(element);
            }
            else {
                var newHead = new ListNode<T>(element);

                newHead.NextNode = head;
                head.PrevNode = newHead;
                head = newHead;
            }

            Count++;
        }

        public void AddLast(T element) {
            if (Count == 0) {
                tail = head = new ListNode<T>(element);
            }
            else {
                var newTail = new ListNode<T>(element);

                tail.NextNode = newTail;
                newTail.PrevNode = tail;
                tail = newTail;
            }

            Count++;
        }

        public T RemoveFirst() {
            if (Count == 0) {
                throw new InvalidOperationException("List is empty");
            }

            var toReturn = head.Value;
            if (Count == 1) {
                head = tail = null;
            }
            else {
                head = head.NextNode;
                head.PrevNode = null;
            }
            Count--;
            return toReturn;
        }

        public T RemoveLast() {
            if(Count == 0) {
                throw new InvalidOperationException("List is empty");
            }

            var toReturn = tail.Value;
            if (Count == 1) {
                tail = head = null;
            }
            else {
                tail = tail.PrevNode;
                tail.NextNode = null;
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

        public void Foreach(Action<T> action) {
            var currNode = head;

            while(currNode != null) {
                action(currNode.Value);
                currNode = currNode.NextNode;
            }
        }
    }
}
