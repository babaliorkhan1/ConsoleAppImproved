using ConsoleApi.Core.Models;
using ConsoleApi.Core.Repositories.DepartmentRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApi.Data.Repositories.DepartmentRepository
{
    public class DepartmentRepository:Repository<Department>,IDepartmentRepo
    {
    }
}
