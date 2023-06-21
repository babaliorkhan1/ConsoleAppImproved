using ConsoleApi.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApi.Data.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        static List<T> Items = new List<T>();   
        public void Create(T model)
        {
            Items.Add(model);
        }

        public void Delete(T model)
        {
            Items.Remove(model);    
        }

        public T Get(Func<T, bool> func)
        {
            T model= Items.FirstOrDefault(func);
            return model;
        }

        public List<T> GetAll()
        {
            return Items;   
        }
    }
}
