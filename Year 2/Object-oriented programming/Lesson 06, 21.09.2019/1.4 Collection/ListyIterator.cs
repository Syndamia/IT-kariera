using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_Collection {
    class ListyIterator : IEnumerable {
        private readonly List<string> elements;
        private int currIndex;

        public ListyIterator(params string[] elements) {
            this.elements = new List<string>(elements);
        }
        public bool HasNext() => currIndex < elements.Count() - 1;

        public bool Move() {
            if (HasNext()) {
                currIndex++;
                return true;
            }
            return false;
        }
        public string Print() {
            if (elements.Count == 0) {
                throw new InvalidOperationException("Invalid Operation!");
            }
            return elements[currIndex];
        }

        public string PrintAll() => string.Join(" ", this.elements);

        public IEnumerator GetEnumerator() {
            foreach (var element in this.elements) yield return element;
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
