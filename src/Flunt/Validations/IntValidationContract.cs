namespace Flunt.Validations
{
    public partial class ValidationContract
    {
        #region IsGreaterThan
        public ValidationContract IsGreaterThan(decimal val, int comparer, string property, string message)
        {
            if ((double)val <= comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterThan(double val, int comparer, string property, string message)
        {
            if (val <= comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterThan(float val, int comparer, string property, string message)
        {
            if (val <= comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterThan(int val, int comparer, string property, string message)
        {
            if (val <= comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsGreaterOrEqualsThan
        public ValidationContract IsGreaterOrEqualsThan(decimal val, int comparer, string property, string message)
        {
            if ((double)val < comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterOrEqualsThan(double val, int comparer, string property, string message)
        {
            if (val < comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterOrEqualsThan(float val, int comparer, string property, string message)
        {
            if (val < comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterOrEqualsThan(int val, int comparer, string property, string message)
        {
            if (val < comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsLowerThan
        public ValidationContract IsLowerThan(decimal val, int comparer, string property, string message)
        {
            if ((double)val >= comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerThan(double val, int comparer, string property, string message)
        {
            if (val >= comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerThan(float val, int comparer, string property, string message)
        {
            if (val >= comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerThan(int val, int comparer, string property, string message)
        {
            if (val >= comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsLowerOrEqualsThan
        public ValidationContract IsLowerOrEqualsThan(decimal val, int comparer, string property, string message)
        {
            if ((double)val > comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerOrEqualsThan(double val, int comparer, string property, string message)
        {
            if (val > comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerOrEqualsThan(float val, int comparer, string property, string message)
        {
            if (val > comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerOrEqualsThan(int val, int comparer, string property, string message)
        {
            if (val > comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region AreEquals
        public ValidationContract AreEquals(decimal val, int comparer, string property, string message)
        {
            if ((double)val != comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreEquals(double val, int comparer, string property, string message)
        {
            if (val != comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreEquals(float val, int comparer, string property, string message)
        {
            if (val != comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreEquals(int val, int comparer, string property, string message)
        {
            if (val != comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region AreNotEquals
        public ValidationContract AreNotEquals(decimal val, int comparer, string property, string message)
        {
            if ((double)val == comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreNotEquals(double val, int comparer, string property, string message)
        {
            if (val == comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreNotEquals(float val, int comparer, string property, string message)
        {
            if (val == comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreNotEquals(int val, int comparer, string property, string message)
        {
            if (val == comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region Between      
        public ValidationContract IsBetween(int val, int from, int to, string property, string message)
        {
            if (!(val > from && val < to))
                AddNotification(property, message);

            return this;
        }
        #endregion
    }
}
