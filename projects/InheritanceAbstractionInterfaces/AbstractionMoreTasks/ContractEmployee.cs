using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionMoreTasks
{
    class ContractEmployee : BaseEmployee
    {
        private string employeeTask;
        private string employeeDepartment;

        public ContractEmployee(string employeeId, string employeeName, string employeeAddress, string employeeTask, string employeeDepartment) : base(employeeId, employeeName, employeeAddress)
        {
            EmployeeTask = employeeTask;
            EmployeeDepartment = employeeDepartment;
        }

        public string EmployeeTask
        {
            get => employeeTask;
            set => employeeTask = value;
        }
        public string EmployeeDepartment
        {
            get => employeeDepartment;
            set => employeeDepartment = value;
        }

        public string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Show());
            sb.AppendLine(EmployeeTask);
            return sb.ToString();
        }

        public override decimal CalculateSlary(int workingHours)
        {
            return 250m + workingHours * 20m;
        }

        public override string GetDepartmenr()
        {
            return EmployeeDepartment;
        }
    }
}
