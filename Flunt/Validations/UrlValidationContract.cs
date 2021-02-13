namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        public Contract<T> IsUrl(string val, string key, string message)
        {
            return this;
        }

        public Contract<T> IsUrlOrEmpty(string val, string key, string message)
        {
            return this;
        }

        public Contract<T> IsNotUrl(string val, string key, string message)
        {
            return this;
        }

        public Contract<T> IsNotUrlOrEmpty(string val, string key, string message)
        {
            return this;
        }
    }
}