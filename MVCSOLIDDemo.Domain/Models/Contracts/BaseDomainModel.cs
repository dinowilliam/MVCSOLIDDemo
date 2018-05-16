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

        protected IContract ValidationContract { get; set; }

        public INotification Notification { get; set; }

        public bool IsValid => Validate(); 

        public bool Validate() {
            bool isValid = false;

            if(ValidationContract == null || ValidationContract.Contract == null)
            {
                isValid = false;
            }
            else if(ValidationContract.Contract.Valid)
            {
                  isValid = true;
            }
            else if(!ValidationContract.Contract.Valid)
            {
                var listNotification = new List<INotificationItem>();
                var notification = new Notification(listNotification);

                foreach(var item in ValidationContract.Contract.Notifications) {

                    var newNotification = new NotificationItem() {
                        Message = item.Message,
                        Description = item.Property
                    };

                    notification.Notifications.Add(newNotification);

                }

                Notification = notification;

            }

            return isValid;

        }

    }

}
