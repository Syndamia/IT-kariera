using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_and._2_Border_control_and_Birthday {
    class Citizen : IIdentifiable, IBirthable {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public DateTime BirthDay { get; private set; }

        public Citizen(string name, int age, string id, DateTime birthDay) {
            Name = name;
            Age = age;
            Id = id;
            this.BirthDay = birthDay;
        }

        public bool HasFakeId(string fakeIdEnding) {
            return Id.Substring(Id.Length - fakeIdEnding.Length) == fakeIdEnding.ToString();
        }
    }
}
