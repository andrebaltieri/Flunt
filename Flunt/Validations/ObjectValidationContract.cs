namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        public Contract<T> IsNull(object val, string key, string message)
        {
            return this;
        }

        public Contract<T> IsNotNull(object val, string key, string message)
        {
            return this;
        }

        public Contract<T> AreEquals(object val, object comparer, string key, string message)
        {
            return this;
        }

        public Contract<T> AreNotEquals(object val, object comparer, string key, string message)
        {
            return this;
        }
    }
}
