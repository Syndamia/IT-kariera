using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_StaticStack {
    public class ArrayStack<T> {
        private const int INITIAL_CAPACITY = 16;

        public int Count { get; private set; }
        private T[] elements;

        public ArrayStack(int capacity = INITIAL_CAPACITY) {
            elements = new T[capacity];
            Count = 0;
        }

        public void Push(T element) {
            if(Count == elements.Length) Grow();

            elements[Count++] = element;
        }

        public T Pop() {
            if (Count == 0) {
                throw new InvalidOperationException("Stack is empty!");
            }

            var toReturn = elements[Count - 1];
            elements[--Count] = default(T);
            return toReturn;
        }

        public T[] ToArray() {
            return elements;
        }

        private void Grow() {
            var biggerElements = new T[elements.Length * 2];
            Array.Copy(elements, biggerElements, elements.Length);
            elements = biggerElements;
        }
    }

}
