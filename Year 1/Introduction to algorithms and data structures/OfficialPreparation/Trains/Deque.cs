using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains {
    public class Deque<T> {
        private const int DEFAULT_CAPACITY = 16;
        private int capacity; //показва капацитета
        public int Count; //показва броят елементи
        private List<T> trains;

        public Deque() : this(DEFAULT_CAPACITY) 
        { }

        public Deque(IEnumerable<T> collection) : this(collection.Count()) {
            trains = collection.ToList();
        }

        public Deque(int capacity) {
            if(trains == null) trains = new List<T>(capacity);
        }
        
        public void AddFront(T item) {
            trains.Insert(0, item);
            Count++;
        }

        public void AddBack(T item) {
            trains.Add(item);
            Count++;
        }

        public string RemoveFront() {
            var toReturn = trains[0];
            trains.RemoveAt(0);
            Count--;
            return toReturn.ToString();
        }

        public string RemoveBack() {
            var toReturn = trains[Count - 1];
            trains.RemoveAt(Count - 1);
            Count--;
            return toReturn.ToString();
        }

        public T GetFront() {
            return trains.First();
        }

        public T GetBack() {
            return trains.Last();
        }

        public int Capacity {
            get {
                return trains.Capacity;
            }
        }
    }
}
