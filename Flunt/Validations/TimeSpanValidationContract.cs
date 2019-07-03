using System;

namespace Flunt.Validations
{
    public partial class Contract
    {
        public Contract IsGreaterThan(TimeSpan val, TimeSpan comparer, string property, string message)
        {
            if (val <= comparer)
                AddNotification(property, message);

            return this;
        }

        public Contract IsGreaterOrEqualsThan(TimeSpan val, TimeSpan comparer, string property, string message)
        {
            if (val < comparer)
                AddNotification(property, message);

            return this;
        }

        public Contract IsLowerThan(TimeSpan val, TimeSpan comparer, string property, string message)
        {
            if (val >= comparer)
                AddNotification(property, message);

            return this;
        }

        public Contract IsLowerOrEqualsThan(TimeSpan val, TimeSpan comparer, string property, string message)
        {
            if (val > comparer)
                AddNotification(property, message);

            return this;
        }

        public Contract IsBetween(TimeSpan val, TimeSpan from, TimeSpan to, string property, string message)
        {
            if (!(val >= from && val <= to))
                AddNotification(property, message);

            return this;
        }
    }
}