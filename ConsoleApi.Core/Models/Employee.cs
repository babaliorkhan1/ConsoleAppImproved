using ConsoleApi.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApi.Core.Models
{
    public class Employee:BaseModel1
    {
        private static int id;
        public string Name;
        public int DepartmentId;


        public Employee(string name,int departmentid)
        {
            id++;
            Id = id;
            Name = name;
            DepartmentId= departmentid;


        }
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Departmentid:{DepartmentId}";
        }
    }
}
