# Flunt
Flunt is a fluent way to use Notification Pattern with your entities, concentrating every change you made and easy accessing it when you need.


| Package |  Version | Downloads |
| ------- | ----- | ----- |
| `Flunt` | [![NuGet](https://img.shields.io/nuget/v/Flunt.svg)](https://nuget.org/packages/Flunt) | [![Nuget](https://img.shields.io/nuget/dt/Flunt.svg)](https://nuget.org/packages/Flunt) |


### Dependencies
.NET Standard 2.0

You can check supported frameworks here:

https://docs.microsoft.com/pt-br/dotnet/standard/net-standard

### Instalation
This package is available through Nuget Packages: https://www.nuget.org/packages/Flunt


**Nuget**
```
Install-Package Flunt
```

**.NET CLI**
```
dotnet add package Flunt
```

## How to use
```csharp
public class Customer : Notifiable<Notification>
{
  ...
}

var customer = new Customer();
customer.AddNotification("Name", "Invalid name");

if(customer.IsValid)
  ...
```

Just check our [Wiki](https://github.com/andrebaltieri/Flunt/wiki) for more details and samples of how to use Flunt in your applications.

## Extensions
* [Flunt.Extensions.Br](https://github.com/andrebaltieri/Flunt.Extensions.Br)
* [Flunt.Extensions.AspNet](https://github.com/andrebaltieri/Flunt.Extensions.AspNet)

## Mods
* [Flunt.Br](https://github.com/lira92/flunt.br)
* [Flunt for Java](https://github.com/carlosbritojun/jflunt)
* [Flunt for JavaScript](https://github.com/jhonesgoncal/flunt)

## About the Art
All logo, icons, colors and fonts were provided with love by Gregory Buso
