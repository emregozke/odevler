using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CrudOdev
{
    public abstract class BaseClass<T>
    {
        public BaseClass()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public abstract string Create(T model);
        public abstract string Update(T model);
        public abstract string Delete(int id);
        public abstract T GetById(int id);
        public abstract List<T> GetList();
    }
}
