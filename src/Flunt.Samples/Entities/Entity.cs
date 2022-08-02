using Flunt.Notifications;

namespace Flunt.Samples.Entities;

public abstract class Entity : Notifiable
{
    protected Entity() 
        => Id =Guid.NewGuid();
    
    public Guid Id { get; }
}