using ConsoleApi.Core.Models.BaseModel;
using ConsoleApi.Core.Repositories.CompanyRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApi.Data.Repositories.CompanyREpo
{
    public class CompanyRepositroy:Repository<Company>,ICompanyRepository
    {

    }
}
