using MVCSOLIDDemo.DAL.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSOLIDDemo.DAL.Repository
{
    using MVCSOLIDDemo.DAL.Contracts;
    using MVCSOLIDDemo.DAL.Repository.Entities;
    
    public class AgentRepository : BaseContext<Agent>, IUnitOfWork<Agent>
    {

    }
}