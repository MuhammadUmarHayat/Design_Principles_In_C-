using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPricipleExample
{
    internal class SmsNotifier : INotifier
    {
        public void Send(Notification notification)
        {
            Console.WriteLine($"SMS sent to {notification.Recipient} with message: {notification.Message}");
        }
    }
}
