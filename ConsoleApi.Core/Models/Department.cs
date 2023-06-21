using ConsoleApi.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApi.Core.Models
{
    public class Department:BaseModel1
    {

        private static int id;
        public string Name;
        public int EmployeeLimit;
       public  List<Employee> Employees;
        public int CompanyId;
        public Department()
        {
            id++;
            Id= id;
            Employees= new List<Employee>();

        }
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Limit:{EmployeeLimit} CompanyId{CompanyId}";
        }
    }
}
