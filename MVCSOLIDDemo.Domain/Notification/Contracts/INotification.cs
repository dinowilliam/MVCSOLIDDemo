using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSOLIDDemo.Domain.Notification.Contracts {
    interface INotification {
        List<INotificationItem> Notifications { get; set; }
        bool Succeed { get; set; }
        bool HasErrors { get; }
        bool HasWarnings { get; }
        bool HasMessages { get; }
    }
}
