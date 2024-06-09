using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface BLLInterface<T>
    {
        public List<T> getAll();
        public int add(T t, ref string err);
        public int delete(T t, ref string err);
        public int update(T t, ref string err);
        public T getById(string id);
    }
}
