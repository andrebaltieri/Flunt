using System.Collections.Generic;

namespace Flunt.Notifications
{
    public interface INotifiable
    {
        void AddNotifications(IEnumerable<Notification> notifications);
    }
}
