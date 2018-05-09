using System.Collections.Generic;
using System.Linq;

namespace MVCSOLIDDemo.Utils.Notification {

    using MVCSOLIDDemo.Utils.Notification.Contracts;

    public class Notification : INotification {

        public Notification(IList<INotificationItem> notifications) {
            Notifications = notifications;
        }

        public IList<INotificationItem> Notifications { get; set; }

        public bool Succeed { get; set; }

        public bool HasErrors {
            get {
                return Notifications.Select(x => x.Type.Equals(NotificationType.Error)).Any();
            }
        }

        public bool HasWarnings {
            get {
                return Notifications.Select(x => x.Type.Equals(NotificationType.Warning)).Any();
            }
        }
       
        public bool HasMessages {
            get {
                return Notifications.Select(x => x.Type.Equals(NotificationType.Message)).Any();
            }
        }
        
    }
}
