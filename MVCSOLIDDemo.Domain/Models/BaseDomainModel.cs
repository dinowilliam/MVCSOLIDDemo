using System;

namespace MVCSOLIDDemo.Domain.Models {

    using MVCSOLIDDemo.Domain.Models.Contracts;
    using MVCSOLIDDemo.Domain.Notification.Contracts;

    public abstract class BaseDomainModel : IBaseDomainModel {

        public Guid Id { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? DisabledAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public Boolean IsEnabled{

            get{

                if(CreatedAt.HasValue && DisabledAt.HasValue == false && DeletedAt.HasValue == false){

                    return true;
                }
                else{

                    return false;
                }

            }
        }

        public Boolean IsDeleted{
            
            get{

                if(DeletedAt.HasValue == false){

                    return true;
                }
                else{

                    return false;
                }
            }

        }

        public INotification Notification { get; set; }

    }

}
