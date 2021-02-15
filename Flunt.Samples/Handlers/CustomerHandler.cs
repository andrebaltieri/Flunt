using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Notifications;
using Flunt.Samples.Entities;
using Flunt.Samples.Handlers.Requests;
using Flunt.Samples.ValueObjects;

namespace Flunt.Samples.Handlers
{
    public class CustomerHandler : Notifiable<Notification>
    {
        public bool Handle(CreateCustomerRequest request)
        {
            if (request.IsValid == false)
            {
                AddNotifications(request.Notifications);
                return false;
            }

            var email = new Email(request.Email);
            var customer = new Customer(request.Name, email);

            AddNotifications(email.Notifications);
            AddNotifications(customer.Notifications);

            return IsValid;

        }
    }
}
