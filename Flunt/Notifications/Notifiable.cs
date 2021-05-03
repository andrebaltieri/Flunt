using System;
using System.Collections.Generic;
using System.Linq;

namespace Flunt.Notifications
{
    public abstract class Notifiable<T> where T : Notification
    {
        private readonly List<T> _notifications;

        protected Notifiable() => _notifications = new List<T>();

        private T GetNotificationInstance(string key, string message)
        {
            return (T)Activator.CreateInstance(typeof(T), new object[] { key, message });
        }
        
        public IReadOnlyCollection<T> Notifications => _notifications;

        public void AddNotification(string key, string message)
        {
            var notification = GetNotificationInstance(key, message);
            _notifications.Add(notification);
        }

        public void AddNotification(T notification)
        {
            _notifications.Add(notification);
        }

        public void AddNotification(Type property, string message)
        {
            var notification = GetNotificationInstance(property?.Name, message);
            _notifications.Add(notification);
        }

        public void AddNotifications(IReadOnlyCollection<T> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(IList<T> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(ICollection<T> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(Notifiable<T> item)
        {
            AddNotifications(item.Notifications);
        }

        public void AddNotifications(params Notifiable<T>[] items)
        {
            foreach (var item in items)
                AddNotifications(item);
        }

        public void Clear()
        {
            _notifications.Clear();
        }

        public bool IsValid => _notifications.Any() == false;
    }
}
