using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPricipleExample
{
    // Dependency Inversion Principle (DIP)
    // High-level modules (NotificationManager) depend on abstractions (INotifier, ILogger), not concrete implementations.
    class NotificationManager
    {
        private readonly List<Notification> _notifications;
        private readonly NotificationService _notificationService;
        private readonly ILogger _logger;

        public NotificationManager(NotificationService notificationService, ILogger logger)
        {
            _notifications = new List<Notification>();
            _notificationService = notificationService;
            _logger = logger;
        }

        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
            _logger.Log($"Notification added for recipient: {notification.Recipient}");
        }

        public void SendAllNotifications()
        {
            foreach (var notification in _notifications)
            {
                _notificationService.SendNotification(notification);
                _logger.Log($"Notification sent to {notification.Recipient}");
            }
        }
    }

}
