using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPricipleExample
{
    public class EmailNotifier : INotifier
    {
        public void Send(Notification notification)
        {
            Console.WriteLine($"Email sent to {notification.Recipient} with message: {notification.Message}");
        }
    }
}
