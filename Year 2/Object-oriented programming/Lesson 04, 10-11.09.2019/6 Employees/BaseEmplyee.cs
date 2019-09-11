using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Employees {
    public abstract class BaseEmplyee {
        protected string employeeID { get; set; }
        protected string employeeName { get; set; }
        protected string employeeAddress { get; set; }

        protected BaseEmplyee(string employeeID, string employeeName, string employeeAddress) {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.employeeAddress = employeeAddress;
        }

        public virtual string Show() {
            return $"{employeeName} with ID of {employeeID} lives at {employeeAddress}";
        }

        public abstract double CalculateSalary(int workingHours);

        public abstract string GetDepartment();
    }
}
