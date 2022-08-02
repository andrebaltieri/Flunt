using Flunt.Notifications;
using Flunt.Samples.Entities;
using Flunt.Samples.ValueObjects;

namespace Flunt.Samples.Handlers;

public class Handler : Notifiable
{
    public Response Handle(Request request)
    {
        // Fail Fast
        // If request is not valid, return
        if (!request.IsValid)
        {
            AppendNotifications(request);
            throw new Exception("Request is not valid!");
        }

        // Generate VOs and Entities
        var name = new Name(request.FirstName, request.LastName);
        var email = new Email(request.Email);
        var customer = new Customer(name, email);

        // Append notifications from VOs and Entities to Handler
        // As customer already unify name and email notifications
        // there is no need to add them here
        AppendNotifications(customer);
        
        // Now we can check if handler is valid
        if (!IsValid)
            throw new Exception("Entities or value objects are not valid");

        // You can add notifications to handler directly
        AddNotification("SomeKey", "Some message");
        
        return new Response("Customer created!");
    }
}