using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectNumbers {
    class CapacityList {
        private const int InitialCapacity = 2;
        private Pair[] items;
        public int Count { get; private set; } //брои колко двойки участват в класирането, тоест колко са онез сумирани двойки

        private int startIndex = 0; //показва първият индекс, от който започваме да сумираме текущите елементи
        private int nextIndex = 0; //показва поредният индекс, на който можем да поставим елемент

        public CapacityList(int capacity = InitialCapacity) {
            this.items = new Pair[capacity];
            Count = 0;
        }

        private Pair SumIntervalPairs(int sIndex, int eIndex) { //според усовието този метод се ползва само от класа и същого няма в Main, затова го промених да е private
            int firstNum = 0, lastNum = 0;

            for (int i = sIndex; i < eIndex; i++) {
                firstNum += items[i].First;
                lastNum += items[i].Last;
            }

            return new Pair(firstNum, lastNum);
        }

        public Pair Sum() {
            return SumIntervalPairs(0, Count);
        }

        public void Add(Pair item) {
            if (nextIndex == items.Length) {
                items[startIndex] = SumIntervalPairs(startIndex, nextIndex);
                Count++;

                for(int i = ++startIndex; i < items.Length; i++) { //++startIndex първо увеличава startIndex и после дава стойността
                    items[i] = default;
                }

                nextIndex = startIndex;
            }

            items[nextIndex] = item;
            nextIndex++;
        }

        public void PrintCurrentState() {
            for (int i = 0; i < nextIndex; i++) {
                Console.WriteLine(items[i].ToString());
            }
        }
    }

}
