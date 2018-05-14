using System;

namespace MVCSOLIDDemo.Domain.Models
{
    using FluentValidator.Validation;
    using MVCSOLIDDemo.Domain.Models.Contracts;
    using MVCSOLIDDemo.Utils.Notification;
    using MVCSOLIDDemo.Utils.Notification.Contracts;
    using System.Collections.Generic;

    public abstract class BaseDomainModel : IBaseDomainModel
    {

        public Guid Id { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? DisabledAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public Boolean IsEnabled
        {

            get
            {

                if(CreatedAt.HasValue && DisabledAt.HasValue == false && DeletedAt.HasValue == false)
                {

                    return true;
                }
                else
                {

                    return false;
                }

            }
        }

        public Boolean IsDeleted
        {

            get
            {

                if(DeletedAt.HasValue == false)
                {

                    return true;
                }
                else
                {

                    return false;
                }
            }

        }

        public INotification Notification { get; set; }

        public bool IsValid { get; }

        private bool Validate(Type valContract) {

            IContract validationContract = (IContract) Activator.CreateInstance(valContract, this);

            if(!validationContract.Contract.Valid)
            {
                var listNotification = (IList<INotificationItem>) new List<NotificationItem>();
                var notification = new Notification(listNotification);

                foreach(var item in validationContract.Contract.Notifications)
                {

                    var newNotification = new NotificationItem()
                    {
                        Message = item.Message,
                        Description = item.Property
                    };

                    notification.Notifications.Add(newNotification);

                }
            }

            return validationContract.Contract.Valid;

        }

    }

}
