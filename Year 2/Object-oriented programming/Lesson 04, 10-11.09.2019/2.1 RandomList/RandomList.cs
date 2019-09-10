using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_RandomList {
    class RandomList : ArrayList{
        public string RandomString() { //ArrayList works with objects but the task wants string
            var rnd = new Random();

            string myElement = (string)this[rnd.Next(this.Count)];
            this.Remove(myElement);
            return myElement;
        }
    }
}
