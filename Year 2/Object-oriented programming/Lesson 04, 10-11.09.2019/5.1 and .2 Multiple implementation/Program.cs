using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_and._2_Multiple_implementation {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Task 5.1 test:");

            Type personInterface = typeof(Citizen).GetInterface("IPerson");
            PropertyInfo[] properties = personInterface.GetProperties();
            Console.WriteLine(properties.Length);
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age, "", "");
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            Console.WriteLine();
            Console.WriteLine("Task 5.2 test:");

            Type identifiableInterface = typeof(Citizen).GetInterface("IIdentifiable");
            Type birthableInterface = typeof(Citizen).GetInterface("IBirthable");
            properties = identifiableInterface.GetProperties();
            Console.WriteLine(properties.Length);
            Console.WriteLine(properties[0].PropertyType.Name);
            properties = birthableInterface.GetProperties();
            Console.WriteLine(properties.Length);
            Console.WriteLine(properties[0].PropertyType.Name);
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable birthable = new Citizen(name, age, id, birthdate);

        }
    }
}
