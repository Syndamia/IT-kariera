using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Employees {
    class ContractEmployee : BaseEmplyee {
        private string employeeTask { get; set; }
        private string employeeDepartment { get; set; }

        public ContractEmployee(string emplyeeID, string employeeName, string employeeAddress, string employeeTask, string employeeDepartment)
            : base(emplyeeID, employeeName, employeeAddress) {
            this.employeeTask = employeeTask;
            this.employeeDepartment = employeeDepartment;
        }

        public override string Show() {
            return base.Show() + $"\nEmployee task: {employeeTask}";
        }

        public override double CalculateSalary(int workingHours) {
            return 250 + workingHours * 20;
        }

        public override string GetDepartment() {
            return this.employeeDepartment;
        }
    }
}
