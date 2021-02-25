using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    public class Manager : Employee
    {
        public List<Employee> DirectReports { get; set; }
        public string CostCode { get; set; }
        public Employee Employee;
        public Manager(List<Employee> drEmployeesLst, string cCode) :Employee(int eID, string eName, string eLevel, DateTime eDoJ)
        {
            DirectReports = drEmployeesLst;
            CostCode = cCode;

        }

        public List<string> GetMyReports()
        {
            return DirectReports.Select(x => x.EmpName).ToList();
        }

    }
}
