using MVCSOLIDDemo.Utils.Notification.Contracts;

namespace MVCSOLIDDemo.Utils.Notification {

    public class NotificationItem : INotificationItem {
       
        public string Message { get; set; }

        public string Description { get; set; }

        public NotificationType Type { get; set; }

        public bool IsValid { get; set; }

        public string Tag { get; set; }

    }
}