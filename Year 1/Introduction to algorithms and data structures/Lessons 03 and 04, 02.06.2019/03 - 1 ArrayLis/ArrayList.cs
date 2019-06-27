using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___1_ArrayLis
{
    class ArrayList<T>
    {
        public int Count { get; private set; }
        public int Length
        {
            get { return items.Length; }
        }

        private T[] items;
        private const int Initial_Capacity = 2;

        public ArrayList()
        {
            items = new T[Initial_Capacity];
        }

        public T this[int index]
        {
            get
            {
                CheckIndex(index);

                return items[index];
            }
            set
            {
                CheckIndex(index);

                items[index] = value;
            }
        }

        public void Add(T item)
        {
            if (Count == items.Length) Resize();

            items[Count++] = item;
        }

        private void Resize()
        {
            T[] copy = new T[items.Length * 2];
            Array.Copy(items, copy, items.Length);
            items = copy;
        }

        public T RemoveAt(int index)
        {
            CheckIndex(index);

            T itemToReturn = items[index];
            items[index] = default(T);
            Shift(index);
            Count--;

            if (Count <= items.Length / 2) Shrink();

            return itemToReturn;
        }

        private void Shift(int indexOfRemovedItem)
        {
            for (int i = indexOfRemovedItem; i < items.Length - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void Shrink()
        {
            T[] copy = new T[items.Length / 2];
            Array.Copy(items, copy, copy.Length);
            items = copy;
        }

        private void CheckIndex(int index)
        {
            if (index >= Count && index < 0)
            { throw new ArgumentOutOfRangeException(); }
        }
    }
}
