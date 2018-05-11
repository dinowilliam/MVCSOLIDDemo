using System;
using System.Collections.Generic;

namespace MVCSOLIDDemo.DAL.Repository
{
    using MVCSOLIDDemo.DAL.Contracts;
    using MVCSOLIDDemo.DAL.DTOs;
    using MVCSOLIDDemo.DAL.Services.Contracts;
    using Nelibur.ObjectMapper;
    using Repository.Entities;

    public class UserService : IUserService {

        IUnitOfWork<Agent> UOWUser { get; set; }

        public UserService(IUnitOfWork<Agent> agentRepository) {
            this.UOWUser =agentRepository;
        }

        public int Save(UserDTO user) {

            TinyMapper.Bind<UserDTO, Agent>();
            var localUser = TinyMapper.Map<Agent>(user);

            return UOWUser.Save(localUser);
        }

        public int Update(UserDTO user) {

            TinyMapper.Bind<UserDTO, Agent>();
            var localUser = TinyMapper.Map<Agent>(user);

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

        public IEnumerable<UserDTO> GetAll() {

            var localListUsers = UOWUser.GetAll();

            TinyMapper.Bind<UserDTO, Agent>();
            var listlUsers = TinyMapper.Map<List<UserDTO>>(localListUsers);

            return listlUsers;
        }

        public UserDTO GetById(object id) {

            var localUser = UOWUser.GetById(id);

            TinyMapper.Bind<UserDTO, Agent>();
            var user = TinyMapper.Map<UserDTO>(localUser);

            return user;

        }

        public IEnumerable<UserDTO> UserFilter(string sex, string email, string name) {

            var localListUsers = UOWUser.Where(m => m.Gender.Contains(sex) && m.Email.Contains(email) && m.Name.Contains(name));

            var listlUsers = TinyMapper.Map<List<UserDTO>>(localListUsers);

            return listlUsers;
        }
    }
}