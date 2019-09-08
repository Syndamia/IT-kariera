using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_ClassFamily {
    class Family {
        private List<Person> members;

        public Family() :this(new List<Person>()) { }

        public Family(List<Person> familyMembers) {
            this.members = familyMembers;
        }

        public void Add(Person newMember) {
            members.Add(newMember);
        }

        public override string ToString() {
            StringBuilder output = new StringBuilder();

            foreach (var member in members.OrderBy(p => p.Name)) {
                output.Append(member.ToString() + '\n');
            }

            return output.ToString().TrimEnd('\n');
        }
    }
}
