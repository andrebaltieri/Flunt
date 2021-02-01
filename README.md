![Flunt](https://raw.githubusercontent.com/andrebaltieri/flunt/main/media/flunt-share.png)

# Flunt
Flunt is a fluent way to use Notification Pattern with your entities, concentrating every change you made and easy accessing it when you need.

## Dependencies
.NET Standard 1.3+

You can check supported frameworks here:

https://docs.microsoft.com/pt-br/dotnet/standard/net-standard

## Instalation
This package is available through Nuget Packages: https://www.nuget.org/packages/Flunt

Note: For Brazilian validations like (CPF, CNPJ) you also need to install another lib with the necessary extensions: https://github.com/lira92/flunt.br

**Nuget**
```
Install-Package Flunt
```

**.NET CLI**
```
dotnet add package Flunt
```

# How to Use
Just check our Wiki

https://github.com/andrebaltieri/Flunt/wiki




### Getting Started
The first thing you need to do is inherit from **Notifiable** class, which is in **Flunt.Notifications** namespace.

```csharp
using Flunt.Notifications;

namespace FluntSamples.Entities
{
    public class Customer : Notifiable
    {

    }
}
```
Now you are ready to add notifications to your class.

### Adding Notification
After inherited from **Notifiable** class you can use **AddNotification** or **AddNotifications** methods, which will add a key/value to your class.

The first parameter is the **property** or **key** and the last is **your message**. Here is a sample:

```csharp
public Customer(string firstName, string lastName)
{
    if (firstName != "Bruce" && lastName != "Wayne")
        AddNotification("Name", "You're not Batman!");
}
```

You can call **AddNotification(s)** methods everywhere inside your class, since it's inherited from **Notifiable**.

### Check if your class is valid
Now that you have a notification set, you can just use the property **Valid** ou **Invalid** to check if you're good to go or not.

```csharp
var customer = new Customer("André", "Baltieri");

if (customer.Invalid)
{
    // Ops, something went wrong
}
```

### Displying the notifications
You can also check everything that happened just iterating the **Notifications** property. Check the sample below.

```csharp
var customer = new Customer("André", "Baltieri");

if (customer.Invalid)
{
    foreach (var notification in customer.Notifications)
    {
        Console.WriteLine($"{notification.Property} - {notification.Message}");
    }
}
```

### Concatenating Notifications
You can use **Notifiable** in any class you want, including parent classes, to group notifications.

Let's supose you have more than one class to validade, you can easily use **AddNotifications** method and just pass the **Notifiable** classes, as the sample below:

```csharp
class Program : Notifiable
{
    void Main(string[] args)
    {
        var customer = new Customer("André", "Baltieri");
        var order = new Order(customer);

        AddNotifications(customer, order);
        
        if (Invalid)
        {
            foreach (var notification in customer.Notifications)
            {
                Console.WriteLine($"{notification.Property} - {notification.Message}");
            }
        }

        Console.WriteLine("Hello World!");
    }
}
```

The **AddNotifications** method accepts any number of **Notifiable** classes you want.
Last we can just call **Invalid** from our parent/base class and check all the notifications (Customer and Order).

### Contracts
Now that you know what you can do with notifications, check the [Design By Contracts](https://github.com/andrebaltieri/flunt/wiki/04.-Design-By-Contract) to make your code even better!













# Wiki
https://www.facebook.com/flunt.io

# Flunt for Java
You can find a port of this library to Java here: https://github.com/carlosbritojun/jflunt

# About the Art
All logo, icons, colors and fonts were provided with love by Gregory Buso
