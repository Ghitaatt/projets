using System;

class EmailService
{
    public void SendEmail(string recipient, string message)
    {
        Console.WriteLine($"Sending email to {recipient}: {message}");
        
    }
}

class NotificationService
{
    private readonly EmailService emailService;

    public NotificationService()
    {
        emailService = new EmailService(); // Dependency on concrete implementation
    }

    public void SendNotification(string recipient, string message)
    {
        emailService.SendEmail(recipient, message);
        
    }
}

/*class Program
{
    static void Main(string[] args)
    {
        NotificationService notificationService = new NotificationService();
        notificationService.SendNotification("user@example.com", "Hello!");
        Console.ReadKey();
    }
}
*/