namespace Flunt.Validations
{
    public partial class ValidationContract
    {
        #region IsGreaterThan
        public ValidationContract IsGreaterThan(decimal val, decimal comparer, string property, string message)
        {
            if (val <= comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterThan(double val, decimal comparer, string property, string message)
        {
            if (val <= (double)comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterThan(float val, decimal comparer, string property, string message)
        {
            if (val <= (float)comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterThan(int val, decimal comparer, string property, string message)
        {
            if (val <= comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsGreaterOrEqualsThan
        public ValidationContract IsGreaterOrEqualsThan(decimal val, decimal comparer, string property, string message)
        {
            if (val < comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterOrEqualsThan(double val, decimal comparer, string property, string message)
        {
            if (val < (double)comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterOrEqualsThan(float val, decimal comparer, string property, string message)
        {
            if (val < (float)comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterOrEqualsThan(int val, decimal comparer, string property, string message)
        {
            if (val < comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsLowerThan
        public ValidationContract IsLowerThan(decimal val, decimal comparer, string property, string message)
        {
            if (val >= comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerThan(double val, decimal comparer, string property, string message)
        {
            if (val >= (double)comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerThan(float val, decimal comparer, string property, string message)
        {
            if (val >= (float)comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerThan(int val, decimal comparer, string property, string message)
        {
            if (val >= comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsLowerOrEqualsThan
        public ValidationContract IsLowerOrEqualsThan(decimal val, decimal comparer, string property, string message)
        {
            if (val > comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerOrEqualsThan(double val, decimal comparer, string property, string message)
        {
            if (val > (double)comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerOrEqualsThan(float val, decimal comparer, string property, string message)
        {
            if (val > (float)comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerOrEqualsThan(int val, decimal comparer, string property, string message)
        {
            if (val > comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region AreEquals
        public ValidationContract AreEquals(decimal val, decimal comparer, string property, string message)
        {
            if (val != comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreEquals(double val, decimal comparer, string property, string message)
        {
            if (val != (double)comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreEquals(float val, decimal comparer, string property, string message)
        {
            if (val != (float)comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreEquals(int val, decimal comparer, string property, string message)
        {
            if (val != comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region AreNotEquals
        public ValidationContract AreNotEquals(decimal val, decimal comparer, string property, string message)
        {
            if (val == comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreNotEquals(double val, decimal comparer, string property, string message)
        {
            if (val == (double)comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreNotEquals(float val, decimal comparer, string property, string message)
        {
            if (val == (float)comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreNotEquals(int val, decimal comparer, string property, string message)
        {
            if (val == comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region Between
        public ValidationContract IsBetween(decimal val, decimal from, decimal to, string property, string message)
        {
            if (!(val > from && val < to))
                AddNotification(property, message);

            return this;
        }      
        #endregion
    }
}
