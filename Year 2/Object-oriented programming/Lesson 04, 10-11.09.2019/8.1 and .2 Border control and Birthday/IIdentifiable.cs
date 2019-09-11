using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_and._2_Border_control_and_Birthday {
    public interface IIdentifiable {
        string Id { get; }
        bool HasFakeId(string fakeIdEnding);
    }
}
