using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_ListyIterator {
    class ListyIterator {
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
    }
}
