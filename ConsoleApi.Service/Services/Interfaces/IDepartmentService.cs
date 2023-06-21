using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApi.Service.Services.Interfaces
{
    public interface IDepartmentService
    {
        public void Create();
        public void Delete();
        public void Get();
        public void GetAll();
        public void Update();
        public void GetDepartmentbyCompanyId();

    }
}
