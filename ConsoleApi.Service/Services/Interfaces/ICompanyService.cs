using ConsoleApi.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApi.Service.Services.Interfaces
{
    public interface ICompanyService
    {
        public void Create();
        public List<Company> GetAllCompanies();
        public void ShowDepartments();
        public void GetAllCompanies1();
    }
}
