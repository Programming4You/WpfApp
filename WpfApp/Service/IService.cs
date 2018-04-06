using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Service
{
    public interface IService<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T obj);
        void Edit(T obj);
        void Remove(int id);
    }
}
