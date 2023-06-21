using ConsoleApi.Core.Models.BaseModel;
using ConsoleApi.Data.Repositories.CompanyREpo;
using ConsoleApi.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApi.Service.Services.Implemantations
{
    public class CompanyService : ICompanyService
    {
        CompanyRepositroy company1=new CompanyRepositroy();
        public void Create()
        {
            Company company=new Company();  
            Console.WriteLine("Please enter company name");
            company.Name = Console.ReadLine();

            company1.Create(company);

            
        }

        public List<Company> GetAllCompanies()
        {

            List<Company> companies = company1.GetAll();
           
            return companies;
            
        }
        public void GetAllCompanies1()
        {


            List<Company> companies = company1.GetAll();
            foreach (var item in companies)
            {
                Console.WriteLine(item);
            }
        }


        public void ShowDepartments()
        {
            Console.WriteLine("Enter company id");
            int.TryParse(Console.ReadLine(), out int id);
            Company company = company1.Get(x=>x.Id==id);
            foreach (var item in company.Departments)
            {
                Console.WriteLine(item);
            }

        }
    }
}
