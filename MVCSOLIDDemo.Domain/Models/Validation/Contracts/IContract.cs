using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSOLIDDemo.Domain.Models.Validation.Contracts
{
    public interface IContract<T> : IContract where T : class  {
    
    
    }
}
