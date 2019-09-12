using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionMoreTasks
{
    abstract class BaseEmployee
    {
        private string employeeId;
        private string employeeName;
        private string employeeAddress;

        public BaseEmployee(string employeeId, string employeeName, string employeeAddress)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.employeeAddress = employeeAddress;
        }

        public string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID - {employeeId}");
            sb.AppendLine($"Name - {employeeName}");
            sb.AppendLine($"Address - {employeeAddress}");

            return sb.ToString();
        }

        public abstract decimal CalculateSlary(int workingHours);

        public abstract string GetDepartmenr();
    }
}
