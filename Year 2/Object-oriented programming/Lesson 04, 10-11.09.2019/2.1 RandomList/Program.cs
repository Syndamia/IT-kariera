using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_RandomList {
    class Program {
        static void Main(string[] args) {
            var arrList = new RandomList();

            arrList.Add("One");
            arrList.Add("Two");
            arrList.Add("Three");

            Console.WriteLine(arrList.RandomString());
            Console.WriteLine();

            foreach (var str in arrList) {
                Console.WriteLine(str);
            }
        }
    }
}
