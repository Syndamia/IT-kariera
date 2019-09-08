using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_ClassPerson {
    class Person {
        private string name;
        private int age;

        public Person(string name, int age) {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString() {
            return $"{Name} {Age}";
        }

        public string Name {
            get { return name; }
            set {
                if (value == "" || value.All(c => c == ' ')) {
                    throw new ArgumentException("Name cannot be empty string or consisting only of blank spaces.");
                }
                name = value;
            }
        }

        public int Age {
            get { return age; }
            set {
                if (value < 0) {
                    throw new ArgumentException("Age cannot be negative.");
                }
                age = value;
            }
        }
    }
}
