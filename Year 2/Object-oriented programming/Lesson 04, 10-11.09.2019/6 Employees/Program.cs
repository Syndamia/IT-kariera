using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Employees {
    class Program {
        static void Main(string[] args) {
            FullTimeEmplyee Gosho = new FullTimeEmplyee("1A", "Gosho", "ul. Slavqnska", "Programmer", "Software developpment");
            Console.WriteLine(Gosho.Show());
            Console.WriteLine(Gosho.GetDepartment());
            Console.WriteLine(Gosho.CalculateSalary(7));

            ContractEmployee Pesho = new ContractEmployee("2B", "Pesho", "ul. Narodna", "Grpahics of icons", "User interface");
            Console.WriteLine(Pesho.Show());
            Console.WriteLine(Pesho.GetDepartment());
            Console.WriteLine(Pesho.CalculateSalary(5));
        }
    }
}
