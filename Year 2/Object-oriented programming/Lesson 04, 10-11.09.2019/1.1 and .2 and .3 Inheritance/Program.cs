using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_and._2_and._3_Inheritance {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Task 1.1 test:");

            Dog myDog = new Dog();
            Console.WriteLine(myDog.Eat());
            Console.WriteLine(myDog.Bark());

            Console.WriteLine();


            Console.WriteLine("Task 1.2 test:");

            Puppy myPuppy = new Puppy();
            Console.WriteLine(myPuppy.Eat());
            Console.WriteLine(myPuppy.Bark());
            Console.WriteLine(myPuppy.Weep());

            Console.WriteLine();


            Console.WriteLine("Task 1.3 test:");

            Dog myDog1 = new Dog(); //kind of redundant, but for the sake of following the task
            Console.WriteLine(myDog1.Eat());
            Console.WriteLine(myDog1.Bark());

            Cat myCat = new Cat();
            Console.WriteLine(myCat.Eat());
            Console.WriteLine(myCat.Meow());
        }
    }
}
