using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVCSOLIDDemo.DAL.Contracts {

    public interface IService<T> where T : class  {

        int Save(T model);

        int Update(T model);

        int Delete(object id);
       
        IEnumerable<T> GetAll();

        T GetById(object id);

        IEnumerable<T> UserFilter(string sex, string email, string name);

    }

}
