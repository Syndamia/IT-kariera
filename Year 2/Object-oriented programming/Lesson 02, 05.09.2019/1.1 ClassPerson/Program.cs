using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_ClassPerson {
    class Program {
        static void Main(string[] args) {
            //this code (next 3 lines) is wanted by the task. The result should be 0.
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            Person Pesho = new Person("Pesho", 20);
            Person Gosho = new Person("Gosho", 18);
            Person Stamat = new Person("Stamat", 43);

            Console.WriteLine(Pesho.ToString());
            Console.WriteLine(Gosho.ToString());
            Console.WriteLine(Stamat.ToString());
        }
    }
}
