using System;
using System.Collections.Generic;

// Single Responsibility Principle (SRP)
// Each class has a single reason to change.
class Notification
{
    public string Message { get; set; }
    public string Recipient { get; set; }
}

interface INotifier
{
    void Send(Notification notification);
}

// Open/Closed Principle (OCP)
// New notifier types can be added without modifying existing code.
class EmailNotifier : INotifier
{
    public void Send(Notification notification)
    {
        Console.WriteLine($"Email sent to {notification.Recipient} with message: {notification.Message}");
    }
}

class SmsNotifier : INotifier
{
    public void Send(Notification notification)
    {
        Console.WriteLine($"SMS sent to {notification.Recipient} with message: {notification.Message}");
    }
}

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

// Interface Segregation Principle (ISP)
// Interfaces are specific to the needs of the client. No unused methods.
interface ILogger
{
    void Log(string message);
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}

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

// Program to demonstrate the SOLID principles in action.
class Program
{
    static void Main(string[] args)
    {
        // Dependency injection
        var emailNotifier = new EmailNotifier();
        var logger = new ConsoleLogger();
        var notificationService = new NotificationService(emailNotifier);
        var notificationManager = new NotificationManager(notificationService, logger);

        // Adding notifications
        notificationManager.AddNotification(new Notification { Recipient = "email@example.com", Message = "Welcome to our service!" });
        notificationManager.AddNotification(new Notification { Recipient = "sms@example.com", Message = "Your OTP is 1234." });

        // Sending notifications
        notificationManager.SendAllNotifications();

        Console.WriteLine("\nSwitching to SMS Notifier...\n");

        // Switching notifier (OCP in action)
        var smsNotifier = new SmsNotifier();
        notificationManager = new NotificationManager(new NotificationService(smsNotifier), logger);

        notificationManager.AddNotification(new Notification { Recipient = "sms@example.com", Message = "Your OTP is 5678." });
        notificationManager.SendAllNotifications();

        Console.ReadKey();
    }
}
