using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_StackOfStrings {
    class StackOfStrings{
        private List<string> data;

        public StackOfStrings() {
            this.data = new List<string>();
        }

        public void Push(string item) {
            data.Add(item);
        }

        public string Pop() {
            var myElement = Peek();
            data.Remove(myElement);
            return myElement;
        }

        public string Peek() {
            return data.Last();
        }

        public bool IsEmpty() {
            return data.Count == 0;
        }

        public override string ToString() { //I added that, makes life much easier
            var toReturn = new StringBuilder();
            data.ForEach(e => toReturn.Append(e + " "));
            return toReturn.ToString();
        }
    }
}
