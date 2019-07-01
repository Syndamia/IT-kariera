using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___1_RevList {
    class ReversedList<T> {
        private const int INITAL_CAPACITY = 2;
        private T[] elements;
        public int Count { get; private set; }

        public ReversedList(int capacity = INITAL_CAPACITY) {
            elements = new T[capacity];
            Count = 0;
        }

        public T this[int index] {
            get {
                CheckIndex(index);

                return elements[index];
            }
            set {
                CheckIndex(index);

                elements[index] = value;
            }
        }

        public void Add(T item) {
            if (Count == elements.Length) {
                Enlarge();
            }

            elements[Capacity - 1 - Count] = item;
            Count++;
        }

        private void Enlarge() {
            var biggerArray = new T[Capacity * 2];

            for (int i = biggerArray.Length - 1; i >= Count; i--) {
                biggerArray[i] = elements[i - Count];
            }

            elements = biggerArray;
        }
        
        public void RemoveAt(int index) {
            CheckIndex(index);

            elements[index] = default;
            Shift(index);
            Count--;

            if (Count == Capacity / 2) Shrink();
        }

        private void Shift(int index) {
            for (int i = index; i >= Capacity - Count; i--) {

                if (i > 0) elements[i] = elements[i - 1];
                else elements[0] = default;
            }
        }

        private void Shrink() {
            var smallerArray = new T[Capacity / 2];

            for(int i = smallerArray.Length - 1; i >= 0; i--) {
                smallerArray[i] = elements[Count + i];
            }

            elements = smallerArray;
        }

        public int Capacity {
            get { return elements.Length; }
        }

        public override string ToString() {
            return string.Join(" ", elements);
        }

        private void CheckIndex(int index) {
            if(index < Capacity - Count || index >= Capacity) {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
