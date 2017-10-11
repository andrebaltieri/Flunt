namespace Flunt.Validations
{
    public partial class ValidationContract
    {
        #region IsGreaterThan
        public ValidationContract IsGreaterThan(decimal val, double comparer, string property, string message)
        {
            if ((double)val <= comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterThan(double val, double comparer, string property, string message)
        {
            if (val <= comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterThan(float val, double comparer, string property, string message)
        {
            if (val <= comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterThan(int val, double comparer, string property, string message)
        {
            if (val <= comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsGreaterOrEqualsThan
        public ValidationContract IsGreaterOrEqualsThan(decimal val, double comparer, string property, string message)
        {
            if ((double)val < comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterOrEqualsThan(double val, double comparer, string property, string message)
        {
            if (val < comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterOrEqualsThan(float val, double comparer, string property, string message)
        {
            if (val < comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsGreaterOrEqualsThan(int val, double comparer, string property, string message)
        {
            if (val < comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsLowerThan
        public ValidationContract IsLowerThan(decimal val, double comparer, string property, string message)
        {
            if ((double)val >= comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerThan(double val, double comparer, string property, string message)
        {
            if (val >= comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerThan(float val, double comparer, string property, string message)
        {
            if (val >= comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerThan(int val, double comparer, string property, string message)
        {
            if (val >= comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsLowerOrEqualsThan
        public ValidationContract IsLowerOrEqualsThan(decimal val, double comparer, string property, string message)
        {
            if ((double)val > comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerOrEqualsThan(double val, double comparer, string property, string message)
        {
            if (val > comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerOrEqualsThan(float val, double comparer, string property, string message)
        {
            if (val > comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsLowerOrEqualsThan(int val, double comparer, string property, string message)
        {
            if (val > comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region AreEquals
        public ValidationContract AreEquals(decimal val, double comparer, string property, string message)
        {
            if ((double)val != comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreEquals(double val, double comparer, string property, string message)
        {
            if (val != comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreEquals(float val, double comparer, string property, string message)
        {
            if (val != comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreEquals(int val, double comparer, string property, string message)
        {
            if (val != comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region AreNotEquals
        public ValidationContract AreNotEquals(decimal val, double comparer, string property, string message)
        {
            if ((double)val == comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreNotEquals(double val, double comparer, string property, string message)
        {
            if (val == comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreNotEquals(float val, double comparer, string property, string message)
        {
            if (val == comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreNotEquals(int val, double comparer, string property, string message)
        {
            if (val == comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region Between     
        public ValidationContract IsBetween(double val, double from, double to, string property, string message)
        {
            if (!(val > from && val < to))
                AddNotification(property, message);

            return this;
        }        
        #endregion
    }
}
