using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSOLIDDemo.Domain.Models.Contracts {
    interface IBaseDomainModel {
        Guid Id { get; set; }
        DateTime? CreatedAt { get; set; }
        DateTime? DisabledAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        DateTime? DeletedAt { get; set; }
        Boolean IsEnabled { get; }
        Boolean IsDeleted { get; }
    }
}
