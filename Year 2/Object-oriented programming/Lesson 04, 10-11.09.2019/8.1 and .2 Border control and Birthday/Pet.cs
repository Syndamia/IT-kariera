using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_and._2_Border_control_and_Birthday {
    class Pet : IBirthable {
        public string Name { get; private set; }
        public DateTime BirthDay { get; private set; }

        public Pet(string name, DateTime birthDay) {
            Name = name;
            BirthDay = birthDay;
        }
    }
}
