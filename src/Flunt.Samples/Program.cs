using Flunt.Notifications;
using Flunt.Validations;

var name = new Name("John", "Petrucci", "john@dreamtheater.net", "https://dreamtheater.net");
if (name.IsValid == false)
{
    foreach (var notification in name.Notifications)
        Console.WriteLine($"{notification.Key} - {notification.Message}");
}

Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();

name.UpdateEmail("invalid");
if (name.IsValid == false)
{
    foreach (var notification in name.Notifications)
        Console.WriteLine($"{notification.Key} - {notification.Message}");
}

Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();

name = new Name("In", "Va", "lid", "name");
if (name.IsValid == false)
{
    foreach (var notification in name.Notifications)
        Console.WriteLine($"{notification.Key} - {notification.Message}");
}

name.Clear();

Console.WriteLine();
Console.WriteLine("End!");

public class Name : Notifiable
{
    public Name(
        string firstName,
        string lastName,
        string email,
        string webSite)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email.Trim().ToLower();
        WebSite = webSite;

        Assert(this.CanCreateName());
    }

    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; private set; }
    public string WebSite { get; }
    
    public void UpdateEmail(string email)
    {
        Email = email.Trim().ToLower();
        Assert(this.CanUpdateEmail());
    }
}

public static class NameAssertions
{
    public static Contract CanCreateName(this Name name)
        => new Contract()
            .IsNotNull(name.FirstName, "SomeKey", "Custom message")
            .IsGreaterOrEqualsThan(name.FirstName.Length, 3, "Name", "Name should have more than 3 chars")
            .IsLowerOrEqualsThan(name.FirstName.Length, 20)
            .IsNotNull(name.LastName, "LastName")
            .IsGreaterOrEqualsThan(name.LastName.Length, 3)
            .IsLowerOrEqualsThan(name.LastName.Length, 20)
            .IsEmail(name.Email, "Email")
            .IsUrl(name.WebSite);
    
    public static Contract CanUpdateEmail(this Name name)
        => new Contract()
            .IsEmail(name.Email, "UpdatedEmail", "Updated email is not valid");
}