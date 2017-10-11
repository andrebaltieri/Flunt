namespace Flunt.Validations
{
    public partial class ValidationContract
    {
        public ValidationContract IsNull(object obj, string property, string message)
        {
            if (obj != null)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsNotNull(object obj, string property, string message)
        {
            if (obj == null)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreEquals(object obj, object comparer, string property, string message)
        {
            if (obj != comparer)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract AreNotEquals(object obj, object comparer, string property, string message)
        {
            if (obj == comparer)
                AddNotification(property, message);

            return this;
        }
    }
}