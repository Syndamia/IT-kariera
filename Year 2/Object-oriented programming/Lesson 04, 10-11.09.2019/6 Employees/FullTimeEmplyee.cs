using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Employees {
    class FullTimeEmplyee :BaseEmplyee {
        private string employeePosition { get; set; }
        private string employeeDepartment { get; set; }

        public FullTimeEmplyee(string emplyeeID, string employeeName, string emplyeeAddress, string employeePosition, string employeeDepartment)
            :base (emplyeeID, employeeName, emplyeeAddress) {
            this.employeePosition = employeePosition;
            this.employeeDepartment = employeeDepartment;
        }

        public override string Show() {
            return base.Show() + $"\nEmployee position: {this.employeePosition}" + $"\nEmplyee department: {this.employeeDepartment}";
        }

        public override double CalculateSalary(int workingHours) {
            return 250 + workingHours * 10.8;
        }

        public override string GetDepartment() {
            return this.employeeDepartment;
        }
    }
}
