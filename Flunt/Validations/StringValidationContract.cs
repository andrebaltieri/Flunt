namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        public Contract<T> IsNull(string val, string key, string message)
        {
            return this;
        }

        public Contract<T> IsNotNull(string val, string key, string message)
        {
            return this;
        }

        public Contract<T> IsNullOrEmpty(string val, string key, string message)
        {
            return this;
        }

        public Contract<T> IsNotNullOrEmpty(string val, string key)
        {
            return this;
        }

        public Contract<T> IsNotNullOrEmpty(string val, string key, string message)
        {
            return this;
        }

        public Contract<T> IsNullOrWhiteSpace(string val, string key, string message)
        {
            return this;
        }

        public Contract<T> IsNotNullOrWhiteSpace(string val, string key, string message)
        {
            return this;
        }

        public Contract<T> AreEquals(string val, object comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> AreNotEquals(string val, object comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> HasLen(string val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> HasLenOrNull(string val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> HasLenOrEmpty(string val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> HasMinLen(string val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> HasMinLenOrNull(string val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> HasMinLenOrEmpty(string val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> HasMaxLen(string val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> HasMaxLenOrNull(string val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> HasMaxLenOrEmpty(string val, int comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> Contains(string val, string comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> NotContains(string val, string comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> IsOnlyNumbers(string val, string comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> IsNotOnlyNumbers(string val, string comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> HasSpecialChars(string val, string comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> HasNoSpecialChars(string val, string comparer, string key, string message)
        {
            return this;
        }
    }
}