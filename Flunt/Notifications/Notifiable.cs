using System.Collections.Generic;
using System.Linq;

namespace Flunt.Notifications
{
    public abstract class Notifiable
    {
        private List<Notification> _notifications;

        protected Notifiable() => _notifications = new List<Notification>();

        public IReadOnlyCollection<Notification> Notifications { get { return _notifications; } }

        public void AddNotification(string property, string message)
        {
            _notifications.Add(new Notification(property, message));
        }

        public void AddNotification(Notification notification)
        {
            if (_notifications == null)
                _notifications = new List<Notification>();

            _notifications.Add(notification);
        }

        public void AddNotifications(IReadOnlyCollection<Notification> notifications)
        {
            if (_notifications == null)
                _notifications = new List<Notification>();

            _notifications.AddRange(notifications);
        }

        public void AddNotifications(IList<Notification> notifications)
        {
            if (_notifications == null)
                _notifications = new List<Notification>();

            _notifications.AddRange(notifications);
        }

        public void AddNotifications(ICollection<Notification> notifications)
        {
            if (_notifications == null)
                _notifications = new List<Notification>();

            _notifications.AddRange(notifications);
        }

        public void AddNotifications(Notifiable item)
        {
            if (_notifications == null)
                _notifications = new List<Notification>();

            AddNotifications(item.Notifications);
        }

        public void AddNotifications(params Notifiable[] items)
        {
            foreach (var item in items)
                AddNotifications(item);
        }

        public bool Invalid => _notifications.Any();
        public bool Valid => !Invalid;
    }
}