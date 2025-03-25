using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPricipleExample
{
    // Liskov Substitution Principle (LSP)
    // Subtypes (EmailNotifier, SmsNotifier) can replace their base type (INotifier) without breaking functionality.
    class NotificationService
    {
        private readonly INotifier _notifier;

        public NotificationService(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void SendNotification(Notification notification)
        {
            _notifier.Send(notification);
        }
    }
}
