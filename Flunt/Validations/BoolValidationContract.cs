namespace Flunt.Validations
{
    public partial class Contract
    {
        public Contract IsFalse(bool val, string property, string message)
        {
            if (val)
                AddNotification(property, message);

            return this;
        }

        public Contract IsTrue(bool val, string property, string message) =>
            IsFalse(!val, property, message);
    }
}