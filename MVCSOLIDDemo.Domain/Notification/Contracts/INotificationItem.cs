namespace MVCSOLIDDemo.Domain.Notification.Contracts {
    public interface INotificationItem {
        string Message { get; set; }
        string Description { get; set; }
        NotificationType Type { get; set; }
        bool IsValid { get; set; }
        string Tag { get; set; }
    }
}