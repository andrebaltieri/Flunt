using Flunt.Samples.Entities;
using Flunt.Samples.Handlers;
using Flunt.Samples.ValueObjects;

// HappyWay();
// InvalidValueObjects();

// InvalidHandler();
ValidHandler();

static void HappyWay()
{
    var name = new Name("John", "Sullivan");
    var email = new Email("jsullivan@email.com");
    var customer = new Customer(name, email);

    Console.WriteLine($"Customer Notifications");
    foreach (var notification in customer.Notifications)
        Console.WriteLine($"{notification.Key} - {notification.Message}");
    Console.WriteLine($"---");
}

static void InvalidValueObjects()
{
    var name = new Name("", "");
    var email = new Email("invalidemail.com");
    var customer = new Customer(name, email);

    Console.WriteLine($"Name Notifications");
    foreach (var notification in name.Notifications)
        Console.WriteLine($"{notification.Key} - {notification.Message}");
    Console.WriteLine($"---");

    Console.WriteLine($"Email Notifications");
    foreach (var notification in email.Notifications)
        Console.WriteLine($"{notification.Key} - {notification.Message}");
    Console.WriteLine($"---");

    Console.WriteLine($"Customer Notifications");
    foreach (var notification in customer.Notifications)
        Console.WriteLine($"{notification.Key} - {notification.Message}");
    Console.WriteLine($"---");
}

static void InvalidHandler()
{
    var handler = new Handler();
    var request = new Request("", "", "invalidemail.com");
    try
    {
        var response = handler.Handle(request);
        Console.WriteLine(response.Message);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        Console.WriteLine($"Handler Notifications");
        foreach (var notification in handler.Notifications)
            Console.WriteLine($"{notification.Key} - {notification.Message}");
        Console.WriteLine($"---");
    }
}

static void ValidHandler()
{
    var handler = new Handler();
    var request = new Request("John", "Sullivan", "jsullivan@email.com");
    try
    {
        var response = handler.Handle(request);
        Console.WriteLine(response.Message);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        Console.WriteLine($"Handler Notifications");
        foreach (var notification in handler.Notifications)
            Console.WriteLine($"{notification.Key} - {notification.Message}");
        Console.WriteLine($"---");
    }
}