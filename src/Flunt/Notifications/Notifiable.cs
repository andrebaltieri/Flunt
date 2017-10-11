using System.Collections.Generic;
using System.Linq;

namespace Flunt.Notifications
{
    public abstract class Notifiable
    {
        private readonly List<Notification> _notifications;

        protected Notifiable() { _notifications = new List<Notification>(); }

        public IReadOnlyCollection<Notification> Notifications =>
            new List<Notification>(_notifications).Concat(GetNotificationsFromValidations()).ToList();

        public void AddNotification(string property, string message)
        {
            _notifications.Add(new Notification(property, message));
        }

        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        public void AddNotifications(IReadOnlyCollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(IList<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(ICollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(Notifiable item)
        {
            AddNotifications(item.Notifications);
        }

        public void AddNotifications(params Notifiable[] items)
        {
            foreach (var item in items)
                AddNotifications(item);
        }

        protected virtual IEnumerable<Notification> Validations() => null;

        private IEnumerable<Notification> GetNotificationsFromValidations()
        {
            return Validations() ?? new List<Notification>();
        }

        public bool Invalid => _notifications.Any() || GetNotificationsFromValidations().Any();
        public bool Valid => !Invalid;
    }
}