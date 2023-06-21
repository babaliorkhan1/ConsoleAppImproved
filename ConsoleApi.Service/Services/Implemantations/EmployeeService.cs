using ConsoleApi.Core.Models;
using ConsoleApi.Core.Models.BaseModel;
using ConsoleApi.Data.Repositories.DepartmentRepository;
using ConsoleApi.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApi.Service.Services.Implemantations
{
    public class EmployeeService : IEmployeeService
    {
        DepartmentRepository department1=new DepartmentRepository();
        CompanyService service1=new CompanyService();    
        public void Create()
        {
            List<Company> companies =service1.GetAllCompanies();
            foreach (Company company in companies) 
            {
                if (company.Departments.Count==0)
                {
                    Console.WriteLine("Department is not Created");
                    return;
                }
                
            }
            
            Console.WriteLine("Enter Employee name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter Department id");
            int.TryParse(Console.ReadLine(), out int result);
            

            Employee employee = new Employee(name,result);


            Department department = department1.Get(x=>x.Id==result);
            
            if (department==null)
            {
                Console.WriteLine("Bashqa islem giriniz");
                return;
            }
            department.Employees.Add(employee);
            Console.WriteLine("Succesfully created");
            

        }

        public void Delete()
        {
            Console.WriteLine("Enter Employee id");
            int.TryParse(Console.ReadLine(), out int result);
            List<Department> departments=department1.GetAll();
            foreach (var item in departments)
            {
                Employee employee = item.Employees.FirstOrDefault(x => x.Id == result);
                if (employee!=null)
                {
                    item.Employees.Remove(employee);
                    Console.WriteLine("Succcesfully Removed");
                }
            }
            Console.WriteLine("Id is not valid");
        }

        public void Get()
        {
            Console.WriteLine("Enter employee id");
            int.TryParse(Console.ReadLine(), out int result);
            List<Department> departments = department1.GetAll();
            foreach (var item in departments)
            {
                Employee employee = item.Employees.FirstOrDefault(x => x.Id == result);
                if (employee != null)
                {
                    Console.WriteLine(employee);
                }
            }
        }

        public void GetAll()
        {
            List<Department> departments = department1.GetAll();
            List<Employee> employees = new List<Employee>();
            foreach (var item in departments)
            {
               employees.AddRange(item.Employees);
            }
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }

        public void GetDepartmentId()
        {
            Console.WriteLine("Enter Department id for Employees");
            int.TryParse(Console.ReadLine(), out int result);
            Department department = department1.Get(x=>x.Id==result);
            foreach (var item in department.Employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
