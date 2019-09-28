using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Animal_Farm {
    public interface IAnimal {
        string makeSound();
        void eat(IFood foodToEat);
    }
}
