using Flunt.Localization;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        public Contract<T> IsNotNullOrEmpty(string val, string key)
        {
            if (string.IsNullOrEmpty(val))
                AddNotification(key, ContractLocalization.IsNotNullOrEmptyErrorMessage(key));

            return this;
        }

        public Contract<T> IsNotNullOrEmpty(string val, string key, string message)
        {
            if (string.IsNullOrEmpty(val))
                AddNotification(key, message);

            return this;
        }
    }
}
