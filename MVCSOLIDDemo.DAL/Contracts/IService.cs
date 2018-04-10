using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVCSOLIDDemo.DAL.Contracts {
    public interface IService {
        public int Save();

        int Update(T);

        int Delete(object id);
       
       T GetAll();

        T GetById(object id);

        public IEnumerable<T> UserFilter(string sex, string email, string name);
    }

}
