namespace Flunt.Validations
{
    public partial class Contract
    {
        public Contract IsNull(object obj, string property, string message)
        {
            if (obj != null)
                AddNotification(property, message);

            return this;
        }

        public Contract IsNotNull(object obj, string property, string message)
        {
            if (obj == null)
                AddNotification(property, message);

            return this;
        }

        public Contract AreEquals(object obj, object comparer, string property, string message)
        {
            if (obj != comparer)
                AddNotification(property, message);

            return this;
        }

        public Contract AreNotEquals(object obj, object comparer, string property, string message)
        {
            if (obj == comparer)
                AddNotification(property, message);

            return this;
        }
    }
}