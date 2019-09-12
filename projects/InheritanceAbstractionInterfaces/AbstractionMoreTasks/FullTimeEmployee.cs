using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionMoreTasks
{
    class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;
        private string employeeDepartmen;

        public FullTimeEmployee(string employeeId, string employeeName, string employeeAddress, string employeePosition, string employeeDepartment) : base(employeeId, employeeName, employeeAddress)
        {
            EmployeePosition = employeePosition;
            EmployeeDepartmen = employeeDepartment;
        }

        public string EmployeePosition
        {
            get => employeePosition;
            set => employeePosition = value;
        }
        public string EmployeeDepartmen
        {
            get => employeeDepartmen;
            set => employeeDepartmen = value;
        }

        public string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Show());
            sb.AppendLine(EmployeePosition);
            sb.AppendLine(EmployeeDepartmen);
            return sb.ToString();
        }

        public override decimal CalculateSlary(int workingHours)
        {
            return 250m + workingHours * 10.80m;
        }

        public override string GetDepartmenr()
        {
            return EmployeeDepartmen;
        }
    }
}
