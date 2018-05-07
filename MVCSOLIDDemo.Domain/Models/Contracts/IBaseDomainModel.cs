using System;

namespace MVCSOLIDDemo.Domain.Models.Contracts {

    using MVCSOLIDDemo.Domain.Notification.Contracts;

    public interface IBaseDomainModel {

        Guid Id { get; set; }
        
        DateTime? CreatedAt { get; set; }
        
        DateTime? DisabledAt { get; set; }
        
        DateTime? UpdatedAt { get; set; }
        
        DateTime? DeletedAt { get; set; }
        
        Boolean IsEnabled { get; }
        
        Boolean IsDeleted { get; }
        
        INotification Notification { get; set; }

    }

}
