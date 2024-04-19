using System;

interface INotificationService
{
    void SendNotification(string recipient, string message);
}

class EmailServicee : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"Sending email to {recipient}: {message}");
    }
}

class NotificationServicee
{
    private readonly INotificationService notificationService;

    public NotificationServicee(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }

    public void SendNotification(string recipient, string message)
    {
        notificationService.SendNotification(recipient, message);
    }
}

class After
{
    static void Main(string[] args)
    {
        INotificationService emailService = new EmailServicee();
        NotificationServicee notificationService = new NotificationServicee(emailService);
        notificationService.SendNotification("user@example.com", "Hello!");
        Console.ReadKey();
    }
}

