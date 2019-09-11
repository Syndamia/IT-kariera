using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_and._2_Border_control_and_Birthday {
    class Robot : IIdentifiable {
        public string Id { get; private set; }
        public string Model { get; private set; }

        public Robot(string id, string model) {
            Id = id;
            Model = model;
        }

        public bool HasFakeId(string fakeIdEnding) {
            return Id.ToString().Substring(Id.Length - fakeIdEnding.Length) == fakeIdEnding;
        }
    }
}
