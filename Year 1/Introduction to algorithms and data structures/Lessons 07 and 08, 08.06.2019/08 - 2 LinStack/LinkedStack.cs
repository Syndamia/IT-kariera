using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___2_LinStack {
    class LinkedStack<T> {
        private class Node<T> {
            public T Value { get; private set; }
            public Node<T> NextNode { get; set; }

            public Node(T value, Node<T> nextNode = null) {
                Value = value;
                NextNode = nextNode;
            }
        }

        private Node<T> firstNode;
        public int Count { get; private set; }

        public void Push(T element) { //добавя елемент
            var newNode = new Node<T>(element);
            if (Count == 0) {
                firstNode = newNode;
            }
            else {
                for(var currNode = firstNode; ; currNode = currNode.NextNode) {
                    if(currNode.NextNode == null) {
                        currNode.NextNode = newNode;
                        break;
                    }
                }
            }
            Count++;
        }

        public T Pop() { //премахва и връща (стойността на) най-горния елемент
            if(Count == 0) {
                throw new InvalidOperationException("List is empty");
            }

            var toReturn = firstNode.Value;
            if (Count == 1) {
                firstNode = null;
            }
            else {
                for(var currNode = firstNode.NextNode; ; currNode = currNode.NextNode) {
                    if(currNode.NextNode.NextNode == null) {
                        toReturn = currNode.NextNode.Value;
                        currNode.NextNode = null;
                        break;
                    }
                }
            }
            Count--;
            return toReturn;
        }

        public T[] ToArray() {
            var arr = new T[Count];
            var currNode = firstNode;

            for (int i = 0; i < Count; i++) {
                arr[i] = currNode.Value;
                currNode = currNode.NextNode;
            }
            return arr;
        }
    }
}
