using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    public class DirectReport :Employee
    {
        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }
        public Employee Employee;
        //public int eID;
        public DirectReport(Employee managerEmpObj,string pCode) :Employee( int eID, string eName, string eLevel, DateTime eDoJ)
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }
    }
}
