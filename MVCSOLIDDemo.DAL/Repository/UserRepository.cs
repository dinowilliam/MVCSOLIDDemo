using MVCSOLIDDemo.DAL.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSOLIDDemo.DAL.Repository
{
    using MVCSOLIDDemo.DAL.Contracts;
    using Repository.Models;
    public class UserRepository : BaseContext<User>, IUnitOfWork<User>
    {

    }
}