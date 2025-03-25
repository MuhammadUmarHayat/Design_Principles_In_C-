
using System;
using System.Collections.Generic;

namespace SolidPricipleExample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Dependency injection
            var emailNotifier = new EmailNotifier();
            var logger = new ConsoleLogger();
            var notificationService = new NotificationService(emailNotifier);
            var notificationManager = new NotificationManager(notificationService, logger);

            // Adding notifications
            notificationManager.AddNotification(new Notification { Recipient = "hafizmohemmedumar@gmail.com", Message = "Welcome to our service!" });
            notificationManager.AddNotification(new Notification { Recipient = "923334380922", Message = "Your OTP is 1234." });

            // Sending notifications
            notificationManager.SendAllNotifications();

            Console.WriteLine("\nSwitching to SMS Notifier...\n");

            // Switching notifier (OCP in action)
            var smsNotifier = new SmsNotifier();
            notificationManager = new NotificationManager(new NotificationService(smsNotifier), logger);

            notificationManager.AddNotification(new Notification { Recipient = "923334380922", Message = "Your OTP is 5678." });
            notificationManager.SendAllNotifications();

            Console.ReadKey();

        }
    }
}
