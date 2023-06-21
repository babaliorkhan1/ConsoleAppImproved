using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApi.Core.Repositories
{
    public interface IRepository<T>
    {
        public void Create(T model);
        public void Delete(T model);
        public List<T> GetAll();
        public T Get( Func<T,bool> func);
    }
}
