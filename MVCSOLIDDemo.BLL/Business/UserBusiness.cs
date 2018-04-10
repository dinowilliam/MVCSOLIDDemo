using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MVCSOLIDDemo.DAL.Repository;
using MVCSOLIDDemo.Domain.Models;

namespace MVCSOLIDDemo.BLL.Business {
    public class UserBusiness {
        UserService userService { get; set; }

        public UserBusiness() {
            this.userService = new UserService();
        }

        public int Save(User user) {           
            return userService.Save(user);
        }

        public int Update(User user) {
            return userService.Update(user);
        }

        public int Delete(object id) {
            return userService.Delete(id);
        }

        public IEnumerable<User> GetAll() {
            return userService.GetAll();
        }

        public User GetById(object id) {
            return userService.GetById(id);
        }

        public IEnumerable<User> UserFilter(string sex, string email, string name) {

            return userService.UserFilter(sex, email, name);
        }
    }
}
