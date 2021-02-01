using System.Collections.Generic;

namespace Flunt.Validations
{
    public partial class Contract
    {
        public Contract IsNull<T>(IList<T> list, string property, string message)
        {
            if (list?.Count > 0)
                AddNotification(property, message);

            return this;
        }

        public Contract IsNotNull<T>(IList<T> list, string property, string message)
        {
            if (list?.Count == 0)
                AddNotification(property, message);

            return this;
        }
    }
}