using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Animal_Kingdom_2 {
    public interface IAnimal : IMakeNoise, IMakeTrick {
        string Perform();
    }
}
