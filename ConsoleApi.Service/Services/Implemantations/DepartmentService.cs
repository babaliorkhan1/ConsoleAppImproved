using ConsoleApi.Core.Models;
using ConsoleApi.Core.Models.BaseModel;
using ConsoleApi.Data.Repositories.CompanyREpo;
using ConsoleApi.Data.Repositories.DepartmentRepository;
using ConsoleApi.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApi.Service.Services.Implemantations
{
    public class DepartmentService : IDepartmentService
    {
        DepartmentRepository departmentRepository=new DepartmentRepository();
        CompanyRepositroy company2 = new CompanyRepositroy();
        CompanyService company1=new CompanyService();   
        public void Create()
        {
            List<Company> companies = company1.GetAllCompanies();
            if (companies.Count==0)
            {
                Console.WriteLine("Company is not Created");
                return;
            }

            Department department=new Department(); 
            Console.WriteLine("Enter department Name");
            department.Name = Console.ReadLine();
            Console.WriteLine("Enter department EmployeeLimit");
            int.TryParse(Console.ReadLine(), out int employeelimit);
            if (employeelimit<10 || employeelimit>20)
            {
                Console.WriteLine("Department limit must be between 10-20");
                return;
            }
            department.EmployeeLimit = employeelimit;

            departmentRepository.Create(department);
            Console.WriteLine("Enter which you want added company");
            int.TryParse(Console.ReadLine(), out int result1);
            Company company = company2.Get(x => x.Id == result1);
            department.CompanyId = company.Id;
            company.Departments.Add(department);

        }

        public void Delete()
        {
            Console.WriteLine("please enter id");
            int.TryParse(Console.ReadLine(), out int result);
            Department department = departmentRepository.Get(x => x.Id == result);
            if (department==null)
            {
                Console.WriteLine("Duzgun deyer daxil edin");
                return;
            }
            departmentRepository.Delete(department);
        }

        public void Get()
        {
            Console.WriteLine("please enter id");
            int.TryParse(Console.ReadLine(), out int result);
            Department department = departmentRepository.Get(x => x.Id == result);
            Console.WriteLine(department);


        }

        public void GetAll()
        {
            List<Department> departments = departmentRepository.GetAll();
            foreach (var item in departments)
            {
                Console.WriteLine(item);
            }
        }
        public void Update()
        {
            Console.WriteLine("Enter id Which you want update");
            int.TryParse(Console.ReadLine(), out int result);
            Department department = departmentRepository.Get(x=>x.Id==result);
            if (department!=null)
            {
                Console.WriteLine("Again add department name");
                department.Name = Console.ReadLine();
                Console.WriteLine("Again add department limit");
                int.TryParse(Console.ReadLine(), out int result1);
                department.EmployeeLimit = result1;
                Console.WriteLine("SuccesFully Updated");
            }
          

        }
        public void GetDepartmentbyCompanyId()
        {
            Console.WriteLine("Enter Compnay Id");
            int.TryParse(Console.ReadLine(),out int result);
        }
    }
}
