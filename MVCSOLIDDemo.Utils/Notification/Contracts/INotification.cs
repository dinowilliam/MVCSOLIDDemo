using System.Collections.Generic;

namespace MVCSOLIDDemo.Utils.Notification.Contracts {

    public interface INotification {

        IList<INotificationItem> Notifications { get; set; }

        bool Succeed { get; set; }

        bool HasErrors { get; }

        bool HasWarnings { get; }

        bool HasMessages { get; }

    }
}
