using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___8_Reverse {
    class Program {
        static void Main(string[] args) {
            var numbers = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            //stack e "Last in, first out"
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
