namespace Flunt.Validations
{
    public partial class ValidationContract
    {
        public ValidationContract IsTrue(bool val, string property, string message)
        {
            if (!val)
                AddNotification(property, message);

            return this;
        }

        public ValidationContract IsFalse(bool val, string property, string message)
        {
            if (val)
                AddNotification(property, message);

            return this;
        }
    }
}