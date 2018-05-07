using MVCSOLIDDemo.Domain.Notification.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSOLIDDemo.Domain.Notification {
    public class Notification : INotification {

        public Notification() {
            Notifications = new List<NotificationItem>().ToList<INotificationItem>();
        }


        public List<INotificationItem> Notifications { get; set; }
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
