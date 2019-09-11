using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Animal_kingdom {
    class Program {
        static void Main(string[] args) {
            Cat myCat = new Cat("Jerry", 5);
            Console.WriteLine(myCat.MakeNoise());
            Console.WriteLine(myCat.MakeTrick());

            Dog myDog = new Dog("Bob", 10);
            Console.WriteLine(myDog.MakeNoise());
            Console.WriteLine(myDog.MakeTrick());
        }
    }
}
