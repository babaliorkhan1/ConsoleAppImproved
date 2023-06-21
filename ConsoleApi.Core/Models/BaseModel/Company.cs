using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApi.Core.Models.BaseModel
{
    public class Company:BaseModel1
    {
        private static int id;
        public string Name { get; set; }
        public List<Department> Departments;
        public Company()
        {
            id++;
            Id= id; 
            Departments= new List<Department>();    
        }
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} ";
        }

    }
}
