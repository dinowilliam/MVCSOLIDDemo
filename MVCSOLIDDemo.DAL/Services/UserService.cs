using MVCSOLIDDemo.DAL.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCSOLIDDemo.Domain.Models;

namespace MVCSOLIDDemo.DAL.Repository {
    using MVCSOLIDDemo.DAL.Contracts;
    using Nelibur.ObjectMapper;
    using Repository.Models;
    using System.Linq.Expressions;

    public class UserService {

        IUnitOfWork<User> UOWUser { get; set; }

        public UserService() {
            this.UOWUser = new UserRepository();
        }

        public int Save(Domain.Models.User user) {

            TinyMapper.Bind<Domain.Models.User, User>();
            var localUser = TinyMapper.Map<User>(user);

            return UOWUser.Save(localUser);
        }

        public int Update(Domain.Models.User user) {

            TinyMapper.Bind<Domain.Models.User, User>();
            var localUser = TinyMapper.Map<User>(user);

            return UOWUser.Update(localUser);
        }

        public int Delete(object id) {
            int deleteReturn;

            var localUser = UOWUser.GetById(id);

            try {
                UOWUser.Delete(localUser);
                deleteReturn = 0;
            }
            catch(Exception ex) {
                deleteReturn = 1;
            }

            return deleteReturn;
        }

        public IEnumerable<Domain.Models.User> GetAll() {

            var localListUsers = UOWUser.GetAll();

            TinyMapper.Bind<Domain.Models.User, User>();
            var listlUsers = TinyMapper.Map<List<Domain.Models.User>>(localListUsers);

            return listlUsers;
        }

        public Domain.Models.User GetById(object id) {

            var localUser = UOWUser.GetById(id);

            TinyMapper.Bind<Domain.Models.User, User>();
            var user = TinyMapper.Map<Domain.Models.User>(localUser);

            return user;

        }

        public IEnumerable<Domain.Models.User> UserFilter(string sex, string email, string name) {

            var localListUsers = UOWUser.Where(m => m.Sex.Contains(sex) && m.Email.Contains(email) && m.Name.Contains(name));

            var listlUsers = TinyMapper.Map<List<Domain.Models.User>>(localListUsers);

            return listlUsers;
        }
    }
}