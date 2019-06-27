using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___1_StaticRe
{
    public class CustomArrayList
    {
        private object[] arr;

        private int count;

        public int Count {
            get { return count; }
            private set { count = value; }
        }

        private static readonly int INITIAL_CAPACITY = 4;

        public CustomArrayList() {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }

        public void Add(object item) {
            if (Count == arr.Length) Resize();

            arr[Count++] = item;
        }

        public void Insert(int index, object item) {
            //no need for custom OutOfRangeException, the array will throw one automatically
            if (Count == arr.Length) Resize();

            for (int i = arr.Length - 1; i > index; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[index] = item;
            Count++;
        }

        public int IndexOf(object item) {
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(item))
                { index = i; break; }
            }

            return index;
        }

        public void Clear() {
            arr = new object[INITIAL_CAPACITY];
            Count = 0;
        }

        public bool Contains(object item) {
            return arr.Contains(item);
        }

        public object this[int index]{
            get
            {
                CheckIndex(index);

                return arr[index];
            } 
            set
            {
                CheckIndex(index);

                arr[index] = value;
            }
        }

        public object RemoveAt(int index) {
            var toReturn = arr[index];

            arr[index] = default(object);
            Shift(index);

            if (Count <= arr.Length / 2) Shrink();

            return toReturn;
        }

        public int Remove(object item)
        {
            int index = IndexOf(item);
            RemoveAt(index);
            return index;
        }

        private void Resize()
        {
            object[] copy = new object[arr.Length * 2];
            Array.Copy(arr, copy, arr.Length);
            arr = copy;
        }

        private void Shrink()
        {
            object[] copy = new object[arr.Length / 2];
            Array.Copy(arr, copy, copy.Length);
            arr = copy;
        }

        private void Shift(int index)
        {
            for (int i = index; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[--Count] = default(object);
        }

        private void CheckIndex(int index)
        {
            if (index >= Count && index < 0)
            { throw new ArgumentOutOfRangeException(); }
        }
    }
}
