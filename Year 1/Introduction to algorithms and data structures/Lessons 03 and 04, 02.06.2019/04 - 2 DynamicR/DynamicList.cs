using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___2_DynamicR
{
    public class DynamicList
    {
        private class Node
        {
            private object element;
            private Node next;

            public object Element {
                get { return element; }
                set { element = value; }
            }

            public Node Next {
                get { return next; }
                set { next = value; }
            }

            public Node(object element) {
                Element = element;
                next = null;
            }

            public Node(object element, Node prevNode) {
                Element = element;
                prevNode.Next = this;
                next = null;
            }
        }

        private Node head;
        private Node tail;
        public int Count { get; private set; }

        public DynamicList() {
            this.head = null;
            this.tail = null;
            Count = 0;
        }

        public void Add(object item) {
            
            if (head == null) {
                var newNode = new Node(item);
                head = newNode;
                tail = newNode;
            }
            else {
                var newNode = new Node(item, tail);
                tail = newNode;
            }
            Count++;
        }

        public object RemoveAt(int index) {
            CheckIndex(index);

            var currNode = head;
            object toReturn = null;

            if (index == 0) {
                toReturn = head.Element;
                head = head.Next;
            }
            else {
                for (int i = 0; i < index; i++) {
                     if (i == index - 1) {
                        toReturn = currNode.Next.Element;

                        if(i == Count - 2) {
                            tail = currNode;
                            tail.Next = null;
                        }
                        else currNode.Next = currNode.Next.Next;

                        break;
                     }
                    currNode = currNode.Next;
                }
            }
            Count--;

            return toReturn;
        }

        public int Remove(object item) {
            int index = IndexOf(item);
            RemoveAt(index);
            return index;
        }

        public int IndexOf(object item) {
            var currNode = head;

            for(int i = 0; i < Count; i++) {
                if(currNode.Element.Equals(item)) {
                    return i;
                }

                currNode = currNode.Next;
            }
            return -1;
        }

        public bool Contains(object item) {
            return IndexOf(item) != -1;
        }

        public object this[int index] {
            get {
                CheckIndex(index);

                return nodeAt(index).Element;
            }
            set {
                CheckIndex(index);

                nodeAt(index).Element = value;
            }
        }

        private void CheckIndex(int index) {
            if(index >= Count || index < 0) {
                throw new IndexOutOfRangeException();
            }
        }

        private Node nodeAt(int index) {
            var currNode = head;

            for(int i = 0; i <= index; i++) {
                if(i == index) return currNode;
                currNode = currNode.Next;
            }

            return null;
        }
    }

}
