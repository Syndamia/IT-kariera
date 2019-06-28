using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CircularQueue {
    public class CircularQueue<T> {
        private const int DEFAULT_CAPACITY = 16;

        public int Count { get; private set; }
        private T[] elements;
        private int startIndex = 0;
        private int endIndex = 0;

        public CircularQueue(int capacity = DEFAULT_CAPACITY) {
            elements = new T[capacity];
            Count = 0;
            endIndex = startIndex;
        }

        public void Enqueue(T element) {
            if (Count >= elements.Length) Grow();

            elements[endIndex] = element;
            endIndex = (endIndex + 1) % elements.Length;
            Count++;
        }

        private void Grow() {
            var biggerElements = new T[elements.Length * 2];
            CopyAllElementsTo(biggerElements);
            elements = biggerElements;
            startIndex = 0;
            endIndex = Count;
        }

        private void CopyAllElementsTo(T[] biggerElements) {
            for (int destinationIndex = 0, sourceIndex = startIndex; destinationIndex < elements.Length; destinationIndex++) {
                biggerElements[destinationIndex] = elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % elements.Length;
            }
        }

        public T Dequeue() {
            if (Count == 0) {
                throw new InvalidOperationException("The queue is empty!");
            }

            var toReturn = elements[startIndex];
            elements[startIndex] = default(T);

            startIndex = (startIndex + 1) % elements.Length;
            Count--;

            return toReturn;
        }

        public T[] ToArray() {
            var elementsArray = new T[elements.Length];
            CopyAllElementsTo(elementsArray);
            return elementsArray;
        }
    }

}
